#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 6080

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["./Consul_Service02.csproj", ""]
RUN dotnet restore "Consul_Service02.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "Consul_Service02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Consul_Service02.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Consul_Service02.dll"]