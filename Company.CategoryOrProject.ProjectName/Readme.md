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