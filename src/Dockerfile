#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src

COPY ["Iti.AppDemo.API/Iti.AppDemo.API.csproj", "src/Iti.AppDemo.API/"]
RUN dotnet restore "src/Iti.AppDemo.API/Iti.AppDemo.API.csproj"

COPY . .

WORKDIR "/src/Iti.AppDemo.API"
RUN dotnet build "Iti.AppDemo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iti.AppDemo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iti.AppDemo.API.dll"]