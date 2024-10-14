#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Gmobile.Migrator/Gmobile.Migrator.csproj", "src/Gmobile.Migrator/"]
COPY ["src/Gmobile.EntityFrameworkCore/Gmobile.EntityFrameworkCore.csproj", "src/Gmobile.EntityFrameworkCore/"]
COPY ["src/Gmobile.Core/Gmobile.Core.csproj", "src/Gmobile.Core/"]
COPY ["src/Gmobile.Core.Shared/Gmobile.Core.Shared.csproj", "src/Gmobile.Core.Shared/"]
RUN dotnet restore "src/Gmobile.Migrator/Gmobile.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Gmobile.Migrator"
RUN dotnet build "Gmobile.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gmobile.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gmobile.Migrator.dll", "-s"]
