# AWS Lambda Clean Architecture Template (.NET)

A production-ready **AWS Lambda project template for .NET**, built using **Clean Architecture**, **microservice principles**, and **AWS Lambda**.
This NuGet template enables teams to quickly bootstrap scalable, maintainable Lambda-based service with a consistent architectural foundation.

### Features

- AWS Lambda using **.NET 8**
- Clean Architecture layering  
  - Application  
  - Core (Domain)  
  - Infrastructure  
- Dependency Injection
- Secrets Manager integration
- Dapper + MySQL support (optional)
- Production-ready folder structure

### Requirements

- .NET SDK **8.0** or later

Install the AWS Lambda tools if not already installed:

```bash
dotnet tool install -g Amazon.Lambda.Tools
```

### Installation

- Install this template from Nuget

```bash
dotnet new install Thushxr.AwsLambda.CleanArchitecture
```

### Verify installation:
```
dotnet new --list
```

### Create a New Lambda Project
```bash
dotnet new clean-lambda -n Company.ProjectOrCategory.ProjectName
```

### Project Structure
```mathematica
root/
├─ Application/
│  ├─ Dtos/ --- request and response dto
│  ├─ Interfaces/ --- service interface
│  └─ Services/ -- service/repository implementation
│
├─ Core/
│  ├─ Entities/ --- business entites and logic
│  ├─ Enums/ --- enums
│  └─ Interfaces/ --- repository/service interface
│
├─ Infrastructure/
│  ├─ ExternalServices/ --- external service implementation
│  └─ Repositories/ --- repository interfaces
│
└─ Lambda/
   ├─ Function.cs --- main function
   ├─ FunctionBase.cs --- base Function
   ├─ ApplicationName.csproj
   └─ aws-lambda-tools-defaults.json
```

### Architecture Overview
- Core
  - Contains domain entities, enums, and business interfaces.
  - No external dependencies.
- Application
  - Contains application-level logic, DTOs, and service interfaces.
- Infrastructure
  - Implements external dependencies such as databases, AWS services, and third-party APIs
- Function
  - AWS Lambda entry point and configuration.


### Nuget Package
Check out the nuget template: https://www.nuget.org/packages/Thushxr.AwsLambda.CleanArchitecture

### Repository
Source code and documentation: https://github.com/thushxr/aws-lambda-clean-architecture-template

### Note
This project doesnt enforce the user to follow clean architecure, this is just used to be followed with clean architecture.

### Contact
If you face any issues with downloading or installation, or have feature requests or bug reports, feel free to reach out.

<a href="https://www.linkedin.com/in/thushxr" target="_blank">
  <img src="https://img.shields.io/badge/LinkedIn-Connect-blue?logo=linkedin" />
</a>
<a href="https://www.instagram.com/thushxr" target="_blank">
  <img src="https://img.shields.io/badge/Instagram-Follow-pink?logo=instagram" />
</a>
<a href="https://twitter.com/thushxr" target="_blank">
  <img src="https://img.shields.io/badge/Twitter-Follow-black?logo=x" />
</a>