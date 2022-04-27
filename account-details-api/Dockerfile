#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["account-details-api/account-details-api.csproj", "account-details-api/"]
RUN dotnet restore "account-details-api/account-details-api.csproj"
COPY . .
WORKDIR "/src/account-details-api"
RUN dotnet build "account-details-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "account-details-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "account-details-api.dll"]