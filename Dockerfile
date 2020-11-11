FROM mcr.microsoft.com/dotnet/core/sdk AS build-env

RUN mkdir -p /usr/share/man/man1 /usr/share/man/man2

RUN apt-get update && \
    apt-get install -y --no-install-recommends \
    openjdk-11-jre

RUN dotnet tool install --global dotnet-sonarscanner --version 4.10.0
ENV PATH="${PATH}:/root/.dotnet/tools"
ENV JAVA_TOOL_OPTIONS -Dfile.encoding=UTF8

COPY . ./build
WORKDIR /build

RUN dotnet restore

RUN dotnet test BowlingGameScore.Tests\
    /p:CollectCoverage=true \
    /p:CoverletOutputFormat=opencover

RUN dotnet sonarscanner begin /k:"vanessaidenny_BowlingGameScore" \
    /d:sonar.host.url="http://9.65.211.40:9000" \
    /d:sonar.verbose=true \
    /v:1.0.0 \
    /d:sonar.login="c6cf5f93c50b8cb3110175bd8cec63e16ec7832e" \
    /d:sonar.cs.opencover.reportsPaths="./coverage.opencover.xml"

RUN dotnet build
RUN dotnet sonarscanner end /d:sonar.login="c6cf5f93c50b8cb3110175bd8cec63e16ec7832e"