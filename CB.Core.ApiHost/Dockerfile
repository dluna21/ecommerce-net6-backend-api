#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CB.Core.ApiHost/CB.Core.ApiHost.csproj", "CB.Core.ApiHost/"]
RUN dotnet restore "CB.Core.ApiHost/CB.Core.ApiHost.csproj"
COPY . .
WORKDIR "/src/CB.Core.ApiHost"
RUN dotnet build "CB.Core.ApiHost.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CB.Core.ApiHost.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CB.Core.ApiHost.dll"]