FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DesignPattern_Factory/DesignPattern_Factory.csproj", "DesignPattern_Factory/"]
RUN dotnet restore "DesignPattern_Factory/DesignPattern_Factory.csproj"
COPY . .
WORKDIR "/src/DesignPattern_Factory"
RUN dotnet build "DesignPattern_Factory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPattern_Factory.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPattern_Factory.dll"]
