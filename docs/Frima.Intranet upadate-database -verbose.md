Using project 'Firma.Intranet'.  
Using startup project 'Firma.Intranet'.  
Build started...  
Build succeeded.  

C:\Program Files\dotnet\dotnet.exe exec --depsfile C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\bin\Debug\net6.0\Firma.Intranet.deps.json --additionalprobingpath C:\Users\krzys\.nuget\packages --additionalprobingpath "C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages" --additionalprobingpath "C:\Program Files (x86)\Microsoft\Xamarin\NuGet" --runtimeconfig C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\bin\Debug\net6.0\Firma.Intranet.runtimeconfig.json C:\Users\krzys\.nuget\packages\microsoft.entityframeworkcore.tools\6.0.2\tools\netcoreapp2.0\any\ef.dll database update --verbose --no-color --prefix-output --assembly C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\bin\Debug\net6.0\Firma.Intranet.dll --project C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\Firma.Intranet.csproj --startup-assembly C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\bin\Debug\net6.0\Firma.Intranet.dll --startup-project C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\Firma.Intranet.csproj --project-dir C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\ --language C# --configuration Debug --working-dir C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs --root-namespace Firma.Intranet --nullable  

Using assembly 'Firma.Intranet'.  
Using startup assembly 'Firma.Intranet'.  

Using application base 'C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\bin\Debug\net6.0'.  

Using working directory 'C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet'.
Using root namespace 'Firma.Intranet'.  

Using project directory 'C:\_code\studia\semestr-6\aplikacje-internetowe\s6-aplikacje-internetowe-kurs\Firma.Intranet\'.
Remaining arguments: .  

Finding DbContext classes...  
Finding IDesignTimeDbContextFactory implementations...  
Finding application service provider in assembly 'Firma.Intranet'...  
Finding Microsoft.Extensions.Hosting service provider...  
Using environment 'Development'.  
Using application service provider from Microsoft.Extensions.Hosting.  
Found DbContext 'FirmaIntranetContext'.  
Finding DbContext classes in the project...  
Using context 'FirmaIntranetContext'.  

```
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.2 initialized 'FirmaIntranetContext' using provider 
            'Microsoft.EntityFrameworkCore.SqlServer:6.0.2' with options: None
```

Finding design-time services referenced by assembly 'Firma.Intranet'...  
Finding design-time services referenced by assembly 'Firma.Intranet'...  
No referenced design-time services were found.  
Finding design-time services for provider 'Microsoft.EntityFrameworkCore.SqlServer'...  
Using design-time services from provider 'Microsoft.EntityFrameworkCore.SqlServer'.  
Finding IDesignTimeServices implementations in assembly 'Firma.Intranet'...  
No design-time services were found.  

```sql
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (267ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      CREATE DATABASE [FirmaIntranetContext-53bba83f-9009-4c4b-ba57-dd877d395d5e];
Executed DbCommand (267ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
CREATE DATABASE [FirmaIntranetContext-53bba83f-9009-4c4b-ba57-dd877d395d5e];
Executed DbCommand (85ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
IF SERVERPROPERTY('EngineEdition') <> 5
BEGIN
    ALTER DATABASE [FirmaIntranetContext-53bba83f-9009-4c4b-ba57-dd877d395d5e] 
        SET READ_COMMITTED_SNAPSHOT ON;
END;

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (85ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
      IF SERVERPROPERTY('EngineEdition') <> 5
      BEGIN
          ALTER DATABASE [FirmaIntranetContext-53bba83f-9009-4c4b-ba57-dd877d395d5e] 
                SET READ_COMMITTED_SNAPSHOT ON;
      END;

Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Executed DbCommand (8ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId] nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
);

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (8ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [__EFMigrationsHistory] (
          [MigrationId] nvarchar(150) NOT NULL,
          [ProductVersion] nvarchar(32) NOT NULL,
          CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
      );

Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Executed DbCommand (16ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT OBJECT_ID(N'[__EFMigrationsHistory]');

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (16ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');

Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT [MigrationId], [ProductVersion]
FROM [__EFMigrationsHistory]
ORDER BY [MigrationId];

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];

Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20220316035401_initialcreate'.
Applying migration '20220316035401_initialcreate'.

Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
CREATE TABLE [Aktualnosc] (
    [IdAktualnosci] int NOT NULL IDENTITY,
    [LinkTytul] nvarchar(10) NOT NULL,
    [Tytul] nvarchar(30) NOT NULL,
    [Tresc] nvarchar(MAX) NOT NULL,
    [Pozycja] int NOT NULL,
    CONSTRAINT [PK_Aktualnosc] PRIMARY KEY ([IdAktualnosci])
);

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Aktualnosc] (
          [IdAktualnosci] int NOT NULL IDENTITY,
          [LinkTytul] nvarchar(10) NOT NULL,
          [Tytul] nvarchar(30) NOT NULL,
          [Tresc] nvarchar(MAX) NOT NULL,
          [Pozycja] int NOT NULL,
          CONSTRAINT [PK_Aktualnosc] PRIMARY KEY ([IdAktualnosci])
      );

Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
CREATE TABLE [Parametr] (
    [IdParametru] int NOT NULL IDENTITY,
    [Kod] nvarchar(10) NOT NULL,
    [Nazwa] nvarchar(30) NOT NULL,
    [Wartosc] nvarchar(max) NOT NULL,
    [Opis] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Parametr] PRIMARY KEY ([IdParametru])
);

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Parametr] (
          [IdParametru] int NOT NULL IDENTITY,
          [Kod] nvarchar(10) NOT NULL,
          [Nazwa] nvarchar(30) NOT NULL,
          [Wartosc] nvarchar(max) NOT NULL,
          [Opis] nvarchar(max) NOT NULL,
          CONSTRAINT [PK_Parametr] PRIMARY KEY ([IdParametru])
      );

Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
CREATE TABLE [Strona] (
    [IdStrony] int NOT NULL IDENTITY,
    [LinkTytulu] nvarchar(10) NOT NULL,
    [Tytul] nvarchar(30) NOT NULL,
    [Tresc] nvarchar(MAX) NOT NULL,
    [Pozycja] int NOT NULL,
    CONSTRAINT [PK_Strona] PRIMARY KEY ([IdStrony])
);

Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Strona] (
          [IdStrony] int NOT NULL IDENTITY,
          [LinkTytulu] nvarchar(10) NOT NULL,
          [Tytul] nvarchar(30) NOT NULL,
          [Tresc] nvarchar(MAX) NOT NULL,
          [Pozycja] int NOT NULL,
          CONSTRAINT [PK_Strona] PRIMARY KEY ([IdStrony])
      );

Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220316035401_initialcreate', N'6.0.2');
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
      VALUES (N'20220316035401_initialcreate', N'6.0.2');
```
Done.