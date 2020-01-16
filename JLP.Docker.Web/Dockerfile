FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./JLP.Docker.Web.csproj", "./"]
RUN dotnet restore "./JLP.Docker.Web.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "JLP.Docker.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JLP.Docker.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JLP.Docker.Web.dll"]