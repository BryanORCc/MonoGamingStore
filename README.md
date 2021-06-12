# MonoGamingStore

---Para poder usar comandos codegenerator---
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

---Packetes necesarios para scaffolding---
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.6

---Mostrar código de Register y Login---
dotnet aspnet-codegenerator identity -dc MonoGamingStore.Data.ApplicationDbContext --files "Account.Register;Account.Login"

