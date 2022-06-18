FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/SISECommerce.Shared/*.csproj Shared/SISECommerce.Shared/
COPY Services/Basket/SISEcommerce.Services.Basket/*.csproj Services/Basket/SISEcommerce.Services.Basket/
RUN dotnet restore Services/Basket/SISEcommerce.Services.Basket/*.csproj
COPY . .
RUN dotnet publish Services/Basket/SISEcommerce.Services.Basket/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "SISEcommerce.Services.Basket.dll" ]

