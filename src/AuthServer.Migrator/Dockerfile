#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/AuthServer.Migrator/AuthServer.Migrator.csproj", "src/AuthServer.Migrator/"]
COPY ["src/AuthServer.EntityFrameworkCore/AuthServer.EntityFrameworkCore.csproj", "src/AuthServer.EntityFrameworkCore/"]
COPY ["src/AuthServer.Core/AuthServer.Core.csproj", "src/AuthServer.Core/"]
COPY ["src/AuthServer.Core.Shared/AuthServer.Core.Shared.csproj", "src/AuthServer.Core.Shared/"]
RUN dotnet restore "src/AuthServer.Migrator/AuthServer.Migrator.csproj"
COPY . .
WORKDIR "/src/src/AuthServer.Migrator"
RUN dotnet build "AuthServer.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthServer.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthServer.Migrator.dll", "-s"]
