FROM mcr.microsoft.com/dotnet/sdk:6.0

RUN apt-get update                                                      && \
    apt-get dist-upgrade -y                                             && \
    apt-get install -y openjdk-11-jre                                   ;
    
RUN dotnet tool install --global dotnet-sonarscanner
RUN dotnet tool install --global dotnet-reportgenerator-globaltool

ENV PATH="${PATH}:/root/.dotnet/tools"

COPY ["src/WebApi/", "src/WebApi/"]
COPY ["src/Application/", "src/Application/"]
COPY ["src/Domain/", "src/Domain/"]
COPY ["src/Infrastructure/", "src/Infrastructure/"]
COPY ["tests/Application.E2ETests", "tests/Application.E2ETests"]
COPY ["tests/Domain.UnitTests", "tests/Domain.UnitTests"]
COPY *.sln .

COPY ["docker/test/github-actions.sh", "github-actions.sh"]

RUN chmod +x github-actions.sh