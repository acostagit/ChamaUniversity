#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/services/Chama.Curso.API/Chama.Curso.API.csproj", "src/services/Chama.Curso.API/"]
RUN dotnet restore "src/services/Chama.Curso.API/Chama.Curso.API.csproj"
COPY . .
WORKDIR "/src/src/services/Chama.Curso.API"
RUN dotnet build "Chama.Curso.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chama.Curso.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chama.Curso.API.dll"]