#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Ocelot.Client2/Ocelot.Client2.csproj", "Ocelot.Client2/"]
COPY ["Consul_Common/Consul_Common.csproj", "Consul_Common/"]
RUN dotnet restore "Ocelot.Client2/Ocelot.Client2.csproj"
COPY . .
WORKDIR "/src/Ocelot.Client2"
RUN dotnet build "Ocelot.Client2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocelot.Client2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocelot.Client2.dll"]