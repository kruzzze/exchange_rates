FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

COPY ExchangeRates.Api/bin/Release/netcoreapp3.1/ app/
WORKDIR /app


EXPOSE 5050

ENTRYPOINT ["dotnet", "app/ExchangeRates.Api.dll"]