FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80
COPY Shared/SISECommerce.Shared/*.csproj Shared/SISECommerce.Shared/
COPY IdentityServer/SISECommerce.IdentityServer/*.csproj IdentityServer/SISECommerce.IdentityServer/
RUN dotnet restore IdentityServer/SISECommerce.IdentityServer/*.csproj 
COPY . .
RUN dotnet publish  IdentityServer/SISECommerce.IdentityServer/*.csproj  -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "SISECommerce.IdentityServer.dll" ]

