FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DesignPattern_Decorator/DesignPattern_Decorator.csproj", "DesignPattern_Decorator/"]
RUN dotnet restore "DesignPattern_Decorator/DesignPattern_Decorator.csproj"
COPY . .
WORKDIR "/src/DesignPattern_Decorator"
RUN dotnet build "DesignPattern_Decorator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPattern_Decorator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPattern_Decorator.dll"]
