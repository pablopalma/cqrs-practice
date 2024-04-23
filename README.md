# CQRS Practice Project

![License](https://img.shields.io/github/license/yourusername/CQRS-Practice-Project)
![Last Commit](https://img.shields.io/github/last-commit/yourusername/CQRS-Practice-Project)

## Overview

The CQRS Practice Project is a simple API designed to perform CRUD operations on tasks, leveraging the CQRS (Command Query Responsibility Segregation) pattern. CQRS separates reads and writes into two separate models, facilitating scalability, performance optimization, and improved maintainability.

## Features

- **CRUD Operations**: Perform basic CRUD (Create, Read, Update, Delete) operations for tasks.
- **Command-Query Separation**: Commands for creating, updating, and deleting tasks are separate from queries for retrieving tasks.
- **Mediator Pattern**: Utilizes the MediatR library to mediate between commands and their corresponding handlers, promoting loose coupling and maintainability.
- **Swagger Documentation**: Explore API endpoints and test functionality with Swagger/OpenAPI documentation.

## Usage

1. **Clone Repository**: `git clone https://github.com/pablopalma/cqrs-practice.git`
2. **Install Dependencies**: Ensure you have .NET Core SDK installed.
3. **Run the Application**: Navigate to the project directory and execute `dotnet run`.
4. **Explore API**: Access the API documentation at `http://localhost:your_port/swagger/index.html` to interact with available endpoints.

## Contributing

Contributions are welcome! If you encounter issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
