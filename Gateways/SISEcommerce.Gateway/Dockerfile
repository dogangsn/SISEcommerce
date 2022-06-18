FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY Gateways/SISEcommerce.Gateway/*.csproj Gateways/SISEcommerce.Gateway/
RUN dotnet restore Gateways/SISEcommerce.Gateway/*.csproj
COPY . .
RUN dotnet publish Gateways/SISEcommerce.Gateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "SISEcommerce.Gateway.dll" ]

