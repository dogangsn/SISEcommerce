FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/SISECommerce.Shared/*.csproj Shared/SISECommerce.Shared/

COPY Services/Order/SISEcommerce.Services.Order.Application/*.csproj Services/Order/SISEcommerce.Services.Order.Application/
COPY Services/Order/SISEcommerce.Services.Order.Core/*.csproj Services/Order/SISEcommerce.Services.Order.Core/
COPY Services/Order/SISEcommerce.Services.Order.Domain/*.csproj Services/Order/SISEcommerce.Services.Order.Domain/
COPY Services/Order/SISEcommerce.Services.Order.Infrastructure/*.csproj Services/Order/SISEcommerce.Services.Order.Infrastructure/

COPY Services/Order/SISEcommerce.Services.Order.API/*.csproj Services/Order/SISEcommerce.Services.Order.API/
RUN dotnet restore Services/Order/SISEcommerce.Services.Order.API/*.csproj
COPY . .
RUN dotnet publish Services/Order/SISEcommerce.Services.Order.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "SISEcommerce.Services.Order.API.dll" ]

