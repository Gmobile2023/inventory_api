#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Inventory.Migrator/Inventory.Migrator.csproj", "src/Inventory.Migrator/"]
COPY ["src/Inventory.EntityFrameworkCore/Inventory.EntityFrameworkCore.csproj", "src/Inventory.EntityFrameworkCore/"]
COPY ["src/Inventory.Core/Inventory.Core.csproj", "src/Inventory.Core/"]
COPY ["src/Inventory.Core.Shared/Inventory.Core.Shared.csproj", "src/Inventory.Core.Shared/"]
RUN dotnet restore "src/Inventory.Migrator/Inventory.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Inventory.Migrator"
RUN dotnet build "Inventory.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inventory.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.Migrator.dll", "-s"]
