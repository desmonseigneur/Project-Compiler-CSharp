# Project-Compiler-CSharp

Project-Compiler-CSharp is a C# application developed as an intern project for a municipal office. It connects up to ten computers to a shared database, where only the admin computer is allowed to edit or delete entries. This setup ensures secure, centralized data management for multi-user environments.

## Features

- Multi-user access: Up to 10 computers connected via network
- Central database access for all connected machines
- Admin-restricted editing and deletion of records
- Developed with C# and uses Inno Setup for deployment

## Prerequisites

Before using or building this software, please ensure the following are installed:

- **.NET Framework (version as specified in `ProjectCompiler.csproj`, e.g., 4.7.2 or higher)**
- **Visual Studio** (recommended for development)
- **SQL Server** or compatible database server (for database connectivity)
- **NuGet package dependencies** (restore via Visual Studio or `nuget restore`)
- **Network connectivity** between the computers and the database server

## Project Structure

Some of the main files and folders (see [full file list](https://github.com/desmonseigneur/Project-Compiler-CSharp/tree/main/)):

- `Form1.cs`, `Form2.cs`, `Form3.cs`: Main application forms
- `Program.cs`: Application entry point
- `App.config`: Application configuration
- `ProjectCompiler.csproj`: Project configuration
- `Debug/`, `Release/`, `obj/`, `Properties/`: Build and configuration folders
- `packages.config`: NuGet package dependencies

> **Note:** This is a basic summary. The listing above may be incomplete. For a complete list, see the [repository contents](https://github.com/desmonseigneur/Project-Compiler-CSharp/tree/main/).

## Getting Started

1. Install prerequisites listed above.
2. Clone the repository:
   ```
   git clone https://github.com/desmonseigneur/Project-Compiler-CSharp.git
   ```
3. Open `ProjectCompiler.csproj` in Visual Studio.
4. Restore NuGet packages if necessary.
5. Build and run the solution.
6. Configure the database connection in `App.config` as required.

## License

See [LICENSE](LICENSE) for details.

---

*This project was created as a practical test and learning experience in building small-scale office applications with secure, multi-user database access.*
