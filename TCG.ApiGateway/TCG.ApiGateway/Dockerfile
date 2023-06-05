#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TCG.ApiGateway/TCG.ApiGateway.csproj", "TCG.ApiGateway/"]
RUN dotnet restore "TCG.ApiGateway/TCG.ApiGateway.csproj"
COPY . .
WORKDIR "/src/TCG.ApiGateway"
RUN dotnet build "TCG.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TCG.ApiGateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TCG.ApiGateway.dll"]