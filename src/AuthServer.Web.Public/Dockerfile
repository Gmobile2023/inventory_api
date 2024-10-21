#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/AuthServer.Web.Public/AuthServer.Web.Public.csproj", "src/AuthServer.Web.Public/"]
COPY ["src/AuthServer.Web.Core/AuthServer.Web.Core.csproj", "src/AuthServer.Web.Core/"]
COPY ["src/AuthServer.Application/AuthServer.Application.csproj", "src/AuthServer.Application/"]
COPY ["src/AuthServer.Application.Shared/AuthServer.Application.Shared.csproj", "src/AuthServer.Application.Shared/"]
COPY ["src/AuthServer.Core.Shared/AuthServer.Core.Shared.csproj", "src/AuthServer.Core.Shared/"]
COPY ["src/AuthServer.Core/AuthServer.Core.csproj", "src/AuthServer.Core/"]
COPY ["src/AuthServer.EntityFrameworkCore/AuthServer.EntityFrameworkCore.csproj", "src/AuthServer.EntityFrameworkCore/"]
COPY ["src/AuthServer.GraphQL/AuthServer.GraphQL.csproj", "src/AuthServer.GraphQL/"]
RUN dotnet restore "src/AuthServer.Web.Public/AuthServer.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/AuthServer.Web.Public"
RUN dotnet build "AuthServer.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthServer.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthServer.Web.Public.dll"]
