FROM mcr.microsoft.com/dotnet/sdk:8.0 as build-env
WORKDIR /app

COPY ProductAPI/*.csproj ./ProductAPI/

WORKDIR /app/ProductAPI
RUN dotnet restore

COPY ProductAPI/ ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/ProductAPI/out .

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT [ "dotnet", "ProductAPI.dll" ]
