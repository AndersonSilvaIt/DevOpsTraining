# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copiar o arquivo csproj para o diretório /app/MeuProjetoApi/
COPY PersonApi/*.csproj ./PersonApi/
# Entrar no diretório da aplicação
WORKDIR /app/PersonApi
RUN dotnet restore

# Copiar todo o restante dos arquivos e compilar a aplicação
COPY PersonApi/ ./
RUN dotnet publish -c Release -o out

# Etapa 2: Criação da imagem final para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
# Copia o resultado da publicação da etapa anterior

COPY --from=build-env /app/PersonApi/out .

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "PersonApi.dll"]
