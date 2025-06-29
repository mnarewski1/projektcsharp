# Medical Appointments Sample

This repository contains a simplified skeleton demonstrating a possible structure for a medical appointments system built with ASP.NET Core and Blazor. The code is intentionally minimal and does not represent a complete working solution.

Projects included:

- **SharedKernel** – base classes shared across projects.
- **Domain** – business entities and repository interfaces.
- **Application** – services for appointments.
- **Infrastructure** – Entity Framework Core context and repository implementations using SQLite.
- **WebApi** – controllers exposing CRUD operations.
- **BlazorServer** – basic server-side Blazor interface.
- **BlazorWasm** – minimal Blazor WebAssembly client.

## Building

The environment used to create this repository lacked the `dotnet` SDK, so the project files were written manually and were not compiled. To use this code, open the solution in Visual Studio 2022 with the .NET 8 SDK installed, restore dependencies, create a database and run migrations as required.

## Notes

This skeleton does not fulfill all project requirements. It is provided only as an outline and starting point.
