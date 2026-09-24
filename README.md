# SupportAI API

An ASP.NET Core API for storing and listing support tickets after an external workflow has analyzed them. The repository targets .NET 10 and uses Entity Framework Core with SQLite.

## Implemented endpoints

- POST /api/tickets accepts a ticket DTO, stores the customer email and AI analysis, and returns the created database ID.
- GET /api/tickets lists stored tickets.

The API receives the analysis as input. n8n, an AI provider, and Telegram notifications are described in the original project concept but are not implemented by this API repository.

## Run

Install the .NET 10 SDK, then run:

~~~bash
dotnet restore
dotnet run
~~~

The project includes EF Core migrations and an application configuration file. Review and configure the database settings for your own environment.
