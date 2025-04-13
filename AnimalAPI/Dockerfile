FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY AnimalAPI/*.csproj ./AnimalAPI/

WORKDIR /app/AnimalAPI
RUN dotnet restore

COPY AnimalAPI/ ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/AnimalAPI/out .

ENV ASPNETCORE_URLS=https://+:80

ENTRYPOINT [ "dotnet", "AnimalAPI.dll" ]

