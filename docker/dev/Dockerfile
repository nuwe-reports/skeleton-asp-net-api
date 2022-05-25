FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY ["src/WebApi/", "src/WebApi/"]
COPY ["src/Application/", "src/Application/"]
COPY ["src/Domain/", "src/Domain/"]
COPY ["src/Infrastructure/", "src/Infrastructure/"]
WORKDIR /src/WebApi
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.WebApi.dll"]