FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DesignPattern_Builder/DesignPattern_Builder.csproj", "DesignPattern_Builder/"]
RUN dotnet restore "DesignPattern_Builder/DesignPattern_Builder.csproj"
COPY . .
WORKDIR "/src/DesignPattern_Builder"
RUN dotnet build "DesignPattern_Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPattern_Builder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPattern_Builder.dll"]
