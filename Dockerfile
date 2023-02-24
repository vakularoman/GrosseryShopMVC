FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GrosseryShopMVC/GrosseryShopMVC/GrosseryShopMVC.csproj", "GrosseryShopMVC/"]

RUN dotnet restore "GrosseryShopMVC/GrosseryShopMVC.csproj"
COPY . .
WORKDIR "/src/GrosseryShopMVC"
RUN dotnet build "GrosseryShopMVC/GrosseryShopMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrosseryShopMVC/GrosseryShopMVC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "GrosseryShopMVC.dll"]
