FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StackOverflow/StackOverflow.csproj", "StackOverflow/"]
RUN dotnet restore "StackOverflow/StackOverflow.csproj"
COPY . .
WORKDIR "/src/StackOverflow"
RUN dotnet build "StackOverflow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StackOverflow.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StackOverflow.dll"]
