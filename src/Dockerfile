FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY *.sln .
COPY Framework.Challenge.Api/*.csproj ./Framework.Challenge.Api/
COPY Framework.Challenge.Service/*.csproj ./Framework.Challenge.Service/
COPY Framework.Challenge.Test/*.csproj ./Framework.Challenge.Test/

RUN dotnet restore

COPY Framework.Challenge.Api/. ./Framework.Challenge.Api/
COPY Framework.Challenge.Service/. ./Framework.Challenge.Service/
COPY Framework.Challenge.Test/. ./Framework.Challenge.Test/

WORKDIR /app/Framework.Challenge.Api
RUN dotnet publish -c Release -o out

WORKDIR /app/Framework.Challenge.Api/out
COPY . ./
ENTRYPOINT ["dotnet", "Framework.Challenge.Api.dll"]