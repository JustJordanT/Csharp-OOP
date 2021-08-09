FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Songs/Songs.csproj", "Songs/"]
RUN dotnet restore "Songs/Songs.csproj"
COPY . .
WORKDIR "/src/Songs"
RUN dotnet build "Songs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Songs.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Songs.dll"]
