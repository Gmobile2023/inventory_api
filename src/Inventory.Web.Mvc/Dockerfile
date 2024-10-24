#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Inventory.Web.Mvc/Inventory.Web.Mvc.csproj", "src/Inventory.Web.Mvc/"]
COPY ["src/Inventory.Web.Core/Inventory.Web.Core.csproj", "src/Inventory.Web.Core/"]
COPY ["src/Inventory.Application/Inventory.Application.csproj", "src/Inventory.Application/"]
COPY ["src/Inventory.Application.Shared/Inventory.Application.Shared.csproj", "src/Inventory.Application.Shared/"]
COPY ["src/Inventory.Core.Shared/Inventory.Core.Shared.csproj", "src/Inventory.Core.Shared/"]
COPY ["src/Inventory.Core/Inventory.Core.csproj", "src/Inventory.Core/"]
COPY ["src/Inventory.EntityFrameworkCore/Inventory.EntityFrameworkCore.csproj", "src/Inventory.EntityFrameworkCore/"]
COPY ["src/Inventory.GraphQL/Inventory.GraphQL.csproj", "src/Inventory.GraphQL/"]
RUN dotnet restore "src/Inventory.Web.Mvc/Inventory.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/Inventory.Web.Mvc"
RUN dotnet build "Inventory.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inventory.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.Web.Mvc.dll"]
