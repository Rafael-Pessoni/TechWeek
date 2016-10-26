# TechWeek
##Demo apresentada na 8º TechWeek FATEC

- Documentação do Asp.Net Core: https://docs.asp.net/en/latest/
- Documentação do EntityFramework: https://docs.efproject.net/en/latest/

======

- ###Instalação do EntityFramework
  - Sql Server
	          
      #####Opção 1
      ```
      NUGET> Install-Package Microsoft.EntityFrameworkCore.SqlServer
      ``` 
      #####Opção 2
      ``` 
        "dependencies": {
          "Microsoft.EntityFrameworkCore.SqlServer": "1.0.1"
        }
      ``` 
  - Postgres
  
      #####Opção 1
      ```
      NUGET> Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
      ``` 
      #####Opção 2
      ``` 
        "dependencies": {
          "Microsoft.EntityFrameworkCore": "1.0.0",
          "Npgsql.EntityFrameworkCore.PostgreSQL": "1.0.0",
          "Microsoft.EntityFrameworkCore.Design": "1.0.0-preview2-final"
        }
      ``` 
      
======
- ###Instalação do EntityFramework Tools

  #####Opção 1
  ```
  NUGET> Install-Package Microsoft.EntityFrameworkCore.Tools -Pre
  ``` 
  #####Opção 2
  ``` 
    "dependencies": {
      "Microsoft.EntityFrameworkCore.Tools": "1.0.0-preview2-final"
    },
    "tools": {
       "Microsoft.EntityFrameworkCore.Tools": "1.0.0-preview2-final"
    }
  ``` 
    
======
    
- ###Migration 

  #####Nuget
  ```
  NUGET> Add-Migration MyFirstMigration
  NUGET> Update-Database
  ```
  #####Terminal
  ```
  CONSOLE> dotnet ef migrations add apelido
  CONSOLE> dotnet ef database update 
  ```

======

- ###Configuração da Conexão com Banco de Dados na Classe Statup.cs

  - SqlServer
  
    ```
    x.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=ToDoList;Trusted_Connection=True;")
    ```
    
  - PostgreSQL
  
    ```
    x.UseNpgsql("User ID=usuario;Password=password;Server=localhost;Port=5432;Database=ToDoList;Pooling=true;")
    ```
    
======
    
- ###Comandos dotnet

  ```
  CONSOLE> dotnet restore
  ```
  
  ```
  CONSOLE> dotnet build
  ```

  ```
  CONSOLE> dotnet run
  ```

  ```
  CONSOLE> ASPNETCORE_ENVIRONMENT=Development dotnet run
  ```
    
