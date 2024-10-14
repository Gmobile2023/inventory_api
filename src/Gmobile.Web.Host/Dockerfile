#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Gmobile.Web.Host/Gmobile.Web.Host.csproj", "src/Gmobile.Web.Host/"]
COPY ["src/Gmobile.Web.Core/Gmobile.Web.Core.csproj", "src/Gmobile.Web.Core/"]
COPY ["src/Gmobile.Application/Gmobile.Application.csproj", "src/Gmobile.Application/"]
COPY ["src/Gmobile.Application.Shared/Gmobile.Application.Shared.csproj", "src/Gmobile.Application.Shared/"]
COPY ["src/Gmobile.Core.Shared/Gmobile.Core.Shared.csproj", "src/Gmobile.Core.Shared/"]
COPY ["src/Gmobile.Core/Gmobile.Core.csproj", "src/Gmobile.Core/"]
COPY ["src/Gmobile.EntityFrameworkCore/Gmobile.EntityFrameworkCore.csproj", "src/Gmobile.EntityFrameworkCore/"]
COPY ["src/Gmobile.GraphQL/Gmobile.GraphQL.csproj", "src/Gmobile.GraphQL/"]
RUN dotnet restore "src/Gmobile.Web.Host/Gmobile.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Gmobile.Web.Host"
RUN dotnet build "Gmobile.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gmobile.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gmobile.Web.Host.dll"]
