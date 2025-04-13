FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY PersonApi/*.csproj ./PersonApi/

WORKDIR /app/PersonApi
RUN dotnet restore


COPY PersonApi/ ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app


COPY --from=build-env /app/PersonApi/out .

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "PersonApi.dll"]
