# Expense Tracker MVC

This project is a simple project built with **ASP.NET Core MVC (.NET 9.0)** for tracking expenses.  

---

### 🚀 Tech Stack

- ASP.NET Core Web API (.NET 9.0)
- Entity Framework Core
- Microsoft SQL Server

---

## 🔐 Local Developer Setup

### 📦 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or SQL Server LocalDB
- Visual Studio 2022+ or any code editor

---

## ⚙️ Steps to Run the Project

### 1. **Clone the repository**

```bash
git clone https://github.com/0riginO/ExpenseTrackerCoreMVC.git
```

### 2. **Set local connection string using User Secrets**

```bash
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Your-Db-Connection-String"
```

### 3. **Database Setup**
Using Package Manager Console in Visual Studio
```powershell
Add-Migration "InitialCreateWithSeed"
Update-Database
```
Using Visual Studio Code
```powershell
dotnet ef migrations add FixedSeedData
dotnet ef database update
```

### 4. **Running the project**

```cmd
cd ExpenseTrackerAPI
dotnet run
```
---

## 📄 License

This project is open source and available under the MIT License.
