FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EliaGroup.API.csproj", "./"]
RUN dotnet restore "./EliaGroup.API.csproj"
COPY . .
RUN dotnet build "EliaGroup.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EliaGroup.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EliaGroup.API.dll"]