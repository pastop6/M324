FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ToDo-App M324/ToDo-App M324.csproj", "./ToDo-App M324/"]
COPY ["ToDoApp-API/ToDoApp-API.csproj", "./ToDoApp-API/"]
RUN dotnet restore "./ToDoApp-API/ToDoApp-API.csproj"

COPY . .
WORKDIR "./ToDoApp-API"
RUN dotnet publish "./ToDoApp-API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ToDoApp-API.dll"]