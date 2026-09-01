# Hello World .NET Core

## Overview

This repository presents a console application developed in C# with the .NET Core framework, with a focus on didactic and academic purposes. The solution was structured to demonstrate, in a simple and objective way, fundamental concepts of object-oriented programming, code organization, and user interaction through the terminal.

The project simulates a person management system, allowing the creation, update, deletion, and listing of records in memory. The adopted approach is intentionally didactic, prioritizing conceptual clarity and understanding of the principles of separation of responsibilities.

## Didactic objective

The application was designed to facilitate learning about:

- syntax and basic structures of the C# language
- fundamentals of object-oriented programming
- use of classes and objects to represent domain entities
- organization of projects into conceptual layers, such as `Models` and `Services`
- manipulation of in-memory collections using `List<T>`
- reading and writing data in the console
- calculation of derived attributes, such as age, from a date of birth
- implementation of interactive menus using the `switch` structure

The system offers operations for:

- registering a person
- updating personal data
- removing records
- listing all stored elements
- closing the application

## Project architecture and organization

The repository structure was organized using a minimal yet didactic approach:

- `src/HelloConsoleApp/Program.cs` — application entry point and main menu implementation
- `src/HelloConsoleApp/Models/Person.cs` — `Person` domain entity
- `src/HelloConsoleApp/Services/PersonService.cs` — business logic and in-memory data manipulation
- `src/HelloConsoleApp/HelloConsoleApp.csproj` — .NET project configuration
- `global.json` — definition of the SDK version used

## Technologies used

### C#
C# is the primary language used in the application development. The business logic, interaction with the console, and modeling of entities were implemented in this language, reinforcing the concepts of object-oriented programming and development in the .NET environment.

### .NET Core
The project was developed with the .NET Core SDK, specifically version 2.1, as indicated in the project and SDK configuration files.

The application is of the console type, with the following main configuration:

- `OutputType`: `Exe`
- `TargetFramework`: `netcoreapp2.1`

This set of technologies allows the application to run in a .NET environment without the need for a graphical interface, favoring learning simplicity and command-line execution.

## How the application works

When execution begins, the program displays an interactive menu in the terminal. The user can choose an option to:

1. create a new person record,
2. update an existing record,
3. delete a person by identifier,
4. list all stored people,
5. terminate execution.

The data is kept in memory while the program is running, which is an appropriate strategy for didactic demonstration and experimentation in a console environment.

## Requirements

To run the project, it is necessary to have the .NET SDK installed on the local machine.

## Execution

Run the following command from the project root:

```bash
dotnet run --project src/HelloConsoleApp/HelloConsoleApp.csproj
```

## Final considerations

This project is an introductory example of .NET Core and C# development, aimed at students and beginners in the field of programming. It illustrates, in an accessible way, how to structure a console application, model entities, and implement basic data manipulation operations, serving as a foundation for more complex projects and as supporting material in academic contexts.
