FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["aitrainsimulation/aitrainsimulation.csproj", "aitrainsimulation/"]
RUN dotnet restore "aitrainsimulation\aitrainsimulation.csproj" -r linux-musl-x64
COPY "./aitrainsimulation" .
WORKDIR "/src/aitrainsimulation"
# RUN dotnet build "aitrainsimulation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "aitrainsimulation.csproj" -c Release -o /app/publish -r linux-musl-x64 --self-contained false --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aitrainsimulation.dll"]
