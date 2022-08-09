<img align="left"  width="150" height="150" src=".github/rviewer_logo--dark.png" />

## Rviewer skeleton: C#, ASP.NET Core & PostgreSQL

[![Twitter](https://img.shields.io/badge/rviewer__-%231DA1F2.svg?style=for-the-badge&logo=Twitter&logoColor=white)](https://twitter.com/Rviewer_/)

[![Rviewer Discord](https://badgen.net/discord/members/VVN4ur8FaQ)](https://discord.gg/VVN4ur8FaQ)

<br/>

This repository is a C# skeleton with ASP.NET Core & PostgreSQL designed for quickly getting started developing an
API.
Check the [Getting Started](#getting-started) for full details.

## Technologies

* [.NET 6](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6)
* [ASP.NET Core 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
* [EntityFramework Core 6](https://docs.microsoft.com/en-us/ef/core/)
* [NUnit 3](https://nunit.org/)
* [Docker](https://www.docker.com/)
* [Make](https://www.gnu.org/software/make/manual/make.html)

## Getting Started

Within the [Makefile](Makefile) you can handle the entire flow to get everything up & running:

1. Install `make` on your computer, if you do not already have it.
2. Start the application: `make up`
3. Run the application tests: `make test`

As you could see on the [Makefile](Makefile) script and the [Docker-Compose File](docker-compose.yml), the whole API
is containerized with Docker and the API is using the internal DNS to connect to the PostgreSQL instance.

Go to [http://localhost:8080/api/health](http://127.0.0.1:8080/api/health) to see that everything is up & running! You
can also check the API definition on the [Swagger UI page](http://localhost:8080/swagger/index.html)

## Overview

This skeleton is based on
a [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) approach, so you
could find the first basic layers:

> You could find here two amazing articles ([here](https://www.educative.io/blog/clean-architecture-tutorial)
> and [here](https://www.freecodecamp.org/news/modern-clean-architecture/)) explaining the Clean Architecture with Java!
> (credits to [@bertilMuth](https://twitter.com/BertilMuth) and [@ryanthelin](https://dev.to/ryanthelin)).

### Infrastructure

Here you will find the different files to interact with the outside. In this folder you there are two different folders:

* `Controllers`: Here you will have the classes that handle the REST endpoints and the Request/Response
* `Repositories`: Here is the persistence layer, which interact with the PostgreSQL database, decoupling the rest of the
  application

You can use this as a starting point to continue with this architecture, or adapt it to your preferences.

### Domain

Any of your domain Entities, or Services, that models your business logic. These classes should be completely isolated
of any external dependency or framework, but interact with them. This layer should follow the Dependency Inversion
principle.

### Application

It defines application-specific business rules. They encapsulate and implement all of the approved use cases for the
application. The use cases control the flow to and from entities and can call on entities to use their enterprise-scale
rules to complete certain user tasks.

## Support

If you are having problems or need anything else, please let us know by
[raising a new issue](https://github.com/Rviewer-Challenges/skeleton-java-spring-rest/issues/new/choose).

## License

This project is licensed with the [MIT license](LICENSE).

---

<p align="center">
  Made with ❤️ by <a href="https://rviewer.io">Rviewer</a>
</p>
