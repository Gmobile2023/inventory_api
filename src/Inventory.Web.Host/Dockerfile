# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Inventory.Web.Host/Inventory.Web.Host.csproj", "src/Inventory.Web.Host/"]
COPY ["src/Inventory.Web.Core/Inventory.Web.Core.csproj", "src/Inventory.Web.Core/"]
COPY ["src/Inventory.GraphQL/Inventory.GraphQL.csproj", "src/Inventory.GraphQL/"]
COPY ["src/Inventory.Application.Shared/Inventory.Application.Shared.csproj", "src/Inventory.Application.Shared/"]
COPY ["src/Inventory.Core.Shared/Inventory.Core.Shared.csproj", "src/Inventory.Core.Shared/"]
COPY ["src/Inventory.Core/Inventory.Core.csproj", "src/Inventory.Core/"]
COPY ["src/Inventory.Application/Inventory.Application.csproj", "src/Inventory.Application/"]
COPY ["src/Inventory.EntityFrameworkCore/Inventory.EntityFrameworkCore.csproj", "src/Inventory.EntityFrameworkCore/"]
RUN dotnet restore "./src/Inventory.Web.Host/Inventory.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Inventory.Web.Host"
RUN dotnet build "./Inventory.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Inventory.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.Web.Host.dll"]