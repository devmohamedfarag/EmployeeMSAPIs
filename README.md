# EmployeeMS – Employee Management System.

## Overview
**EmployeeMS** is a robust and enterprise-grade **Employee Management System** designed to handle employee data, departments, and professions with efficiency and scalability.  
It is built using **ASP.NET Core 8** and adheres strictly to the **Clean Architecture** principles to achieve maximum separation of concerns, testability, and maintainability.

The system follows the **CQRS (Command Query Responsibility Segregation)** pattern, leveraging **MediatR** for in-process messaging, **Entity Framework Core** for data persistence, **AutoMapper** for object mapping, and **FluentValidation** for powerful and expressive data validation.

### Key Highlights:
- **Clean Architecture** — each layer has a clear responsibility (Domain, Application, Infrastructure, API, Shared).
- **CQRS Pattern** — separates reads (queries) from writes (commands) for better scalability and maintainability.
- **MediatR Integration** — decouples business logic from controllers and enforces the single responsibility principle.
- **Entity Framework Core** — provides a modern ORM with LINQ-based data access.
- **AutoMapper** — simplifies mapping between entities, DTOs, and commands.
- **FluentValidation** — enforces consistent and reusable validation logic.
- **Swagger Integration** — automatically documents APIs for easy testing and collaboration.

The goal of **EmployeeMS** is to provide a clean, extendable, and production-ready foundation for any organization to manage its employees, departments, and related operations efficiently.

---

## Technologies Used
- **.NET 8 / ASP.NET Core Web API**
- **Entity Framework Core**
- **CQRS Pattern with MediatR**
- **AutoMapper**
- **FluentValidation**
- **SQL Server**
- **Swagger / OpenAPI**
- **Dependency Injection**
- **Localization (Multilingual support)**

---

## Features
- ✅ CRUD operations for Departments and Employees  
- ✅ Get Department with all related Employees  
- ✅ Centralized exception handling  
- ✅ Validation with FluentValidation  
- ✅ Read-only and write repositories  
- ✅ AutoMapper for DTO mapping  
- ✅ Clean Architecture separation  
- ✅ Localized messages and error handling 

---

## Running the Project

1. **Clone the repository:**
   ```bash
    https://github.com/devmohamedfarag/EmployeeMSAPIs.git
2. Open the solution in Visual Studio or VS Code.
3. Update the connection string in appsettings.json.
4. Run database migrations:
    ```bash
   dotnet ef database update
5. Set EmployeeMS.API as the startup project.
6. Run the application:
   ```bash
   dotnet run
7. Open Swagger UI:
   ```bash
   https://localhost:44323/swagger
   
---

## Clean Architecture Benefits:
- Separation of concerns.
- High testability.
- Easy to extend or replace components.
- Business logic independent from infrastructure.

