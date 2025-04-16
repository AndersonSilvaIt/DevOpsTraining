FROM mcr.microsoft.com/dotnet/sdk:8.0 as build-env
WORKDIR /app

COPY SchoolAPI/*.csproj ./SchoolAPI/

WORKDIR /app/SchoolAPI
RUN dotnet restore

COPY SchoolAPI/ ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/SchoolAPI/out .

ENV ASPNETCORE_URLS=https://+:80

ENTRYPOINT ["dotnet", "SchoolAPI.dll"]