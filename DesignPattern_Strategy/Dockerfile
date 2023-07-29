FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DesignPattern_Strategy/DesignPattern_Strategy.csproj", "DesignPattern_Strategy/"]
RUN dotnet restore "DesignPattern_Strategy/DesignPattern_Strategy.csproj"
COPY . .
WORKDIR "/src/DesignPattern_Strategy"
RUN dotnet build "DesignPattern_Strategy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPattern_Strategy.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPattern_Strategy.dll"]
