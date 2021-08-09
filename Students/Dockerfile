FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Students/Students.csproj", "Students/"]
RUN dotnet restore "Students/Students.csproj"
COPY . .
WORKDIR "/src/Students"
RUN dotnet build "Students.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Students.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Students.dll"]
