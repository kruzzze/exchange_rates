FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5050

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore ExchangeRates.Api/ExchangeRates.Api.csproj
COPY . .
WORKDIR /src
RUN dotnet build ExchangeRates.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ExchangeRates.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ExchangeRates.Api.dll"]