.PHONY: up down test

up: .build
	docker compose up --remove-orphans -d netcore-skeleton-api

down:
	docker compose down --remove-orphans

test: .build
	docker compose run dotnet-skeleton-tests bash -c "dotnet test  --collect:'XPlat Code Coverage' && \
	reportgenerator -reports:./tests/**/coverage.cobertura.xml -targetdir:./CoverageReport -reporttypes:TextSummary"

sonarqube: .build
	docker compose run -e REPO_NAME="${REPO_NAME}" -e SONAR_HOST_URL="${SONAR_HOST_URL}" -e SONAR_TOKEN="${SONAR_TOKEN}" -it dotnet-skeleton-tests bash -c './github-actions.sh'

.build:
	docker compose build