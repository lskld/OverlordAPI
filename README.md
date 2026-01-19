# OverlordAPI

A .NET 10 Web API for managing your evil empire. Minions, lairs, and world-domination missions included.

## About

This project was created to practice building a **clean, layered API architecture**. It demonstrates:

- **Repository Pattern** – Abstracts data access logic
- **Service Layer** – Contains business logic, separate from controllers
- **Dependency Injection** – All services and repositories are registered and injected
- **DTOs (Data Transfer Objects)** – Keeps API responses clean and avoids circular references
- **Entity Framework Core** – Code-first approach with SQL Server
- **Swagger/OpenAPI** – Interactive API documentation

## Project Structure

## Entities

| Entity     | Description                                      |
|------------|--------------------------------------------------|
| **Minion** | Evil henchmen with a name, type, and evil level  |
| **EvilLair** | Secret bases where minions reside              |
| **Mission** | World-domination tasks with difficulty ratings  |

### Minion Types
`Apprentice` · `Scientist` · `Soldier` · `Janitor` · `Infiltrator` · `Mystic`

## Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (or LocalDB)

### Setup

1. **Clone the repository**
2. **Configure the connection string**  
   Update `appsettings.json`:
3. **Apply migrations**
4. **Run the API**
5. **Explore the API**  
Navigate to `https://localhost:<port>/swagger` to view the interactive Swagger UI.

## API Endpoints

| Method | Endpoint                                                       | Description              |
|--------|----------------------------------------------------------------|--------------------------|
| GET    | `/api/minions`                                                 | Get all minions          |
| GET    | `/api/minions/{id}`                                            | Get a minion by ID       |
| POST   | `/api/minions`                                                 | Create a new minion      |
| GET    | `/api/missions`                                                | Get all missions         |
| POST   | `/api/missions/{id}`                                           | Create a new mission     |
| GET    | `/api/missions/{id}/minions`                                   | Get all missions         |
| POST   | `/api/missions/assign/minion/minionId}/mission/{missionId}`    | Create a new mission     |
              

## Technologies

- **.NET 10** / ASP.NET Core
- **Entity Framework Core** (SQL Server)
- **Swagger / Swashbuckle**
- **C# 14**

## What I Learned

- Structuring an API with separation of concerns
- Using interfaces to decouple layers
- Handling navigation properties and avoiding circular JSON references
- Dependency injection in ASP.NET Core
- Writing clean, maintainable code
