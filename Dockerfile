FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ToDo-App M324/ToDo-App M324.csproj", "./ToDo-App M324/"]
RUN dotnet restore "./ToDo-App M324/ToDo-App M324.csproj"

COPY . .
WORKDIR "./ToDo-App M324"
RUN dotnet publish "./ToDo-App M324.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ToDo-App M324.dll"]