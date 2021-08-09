FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StopWatch/StopWatch.csproj", "StopWatch/"]
RUN dotnet restore "StopWatch/StopWatch.csproj"
COPY . .
WORKDIR "/src/StopWatch"
RUN dotnet build "StopWatch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StopWatch.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StopWatch.dll"]
