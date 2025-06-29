# Medical Appointments Sample

This repository contains a simple medical appointments system built with ASP.NET Core (.NET 8) and Blazor. It demonstrates a clean architecture approach with separate projects for each layer.

Projects included:

- **SharedKernel** – base classes shared across projects.
- **Domain** – business entities and repository interfaces.
- **Application** – services for appointments.
- **Infrastructure** – Entity Framework Core context and repository implementations using SQLite.
- **WebApi** – controllers exposing CRUD operations.
- **BlazorServer** – basic server-side Blazor interface.
- **BlazorWasm** – minimal Blazor WebAssembly client.

## Building

Open `MedicalAppointments.sln` in Visual Studio 2022. Restore NuGet packages and build the solution. The application uses SQLite and will create `medical.db` on first run.

Run the Web API project to expose endpoints, or start the Blazor Server project for a basic user interface. The Blazor WebAssembly client can also be served by the Web API.
After building you can create a zipped release using `dotnet publish -c Release`.

## Group

This sample was prepared by a single developer.
