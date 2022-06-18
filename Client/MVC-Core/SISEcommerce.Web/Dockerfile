FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/SISECommerce.Shared/*.csproj Shared/SISECommerce.Shared/
COPY Client/MVC-Core/SISEcommerce.Web/*.csproj Client/MVC-Core/SISEcommerce.Web/
RUN dotnet restore Client/MVC-Core/SISEcommerce.Web/*.csproj 
COPY . .
RUN dotnet publish  Client/MVC-Core/SISEcommerce.Web/*.csproj  -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "SISEcommerce.Web.dll" ]

