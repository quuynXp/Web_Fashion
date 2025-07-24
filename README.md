# WebFashion - Fashion Web Application Integrating VNPay Payment (Sandbox)

## 🛍️ Introduction

**WebFashion** is a web application built using **ASP.NET MVC (.NET Framework/.NET Core)** for fashion stores, integrating the **VNPay QR (sandbox)** payment system allowing users to pay for orders via QR codes.

The application has all the features of an e-commerce website: product management, shopping cart, orders, users and online payment analysis.

---

## 🧰 Technology used

- ASP.NET MVC (.NET Core or .NET Framework)
- Entity Framework
- SQL Server
- VNPay QR API (Sandbox)
- Bootstrap 4/5 + jQuery

---

## 🛠️ Instructions for installing and running the application

### 1. System requirements

- [.NET SDK](https://dotnet.microsoft.com/) (version suitable for the project, for example: .NET 6.0 or .NET Framework 4.7+)
- SQL Server (or SQL Server Express)
- Visual Studio 2022 or later (recommended)

---

### 2. Restore the database from the `.bak` file

#### Step 1: Open SQL Server Management Studio (SSMS)

#### Step 2: Restore the database

- Right-click on `Databases` > select **Restore Database...**
- Select:

- **Source**: Device
- Click **Add...** → select the `WebFashion.sql.bak` file in the project root directory
- Name the database (for example: `WebFashionDb`)
- Check the item **Options** to make sure there is no error in the `.mdf`/`.ldf` file path

- Click **OK** to restore

---

### 3. Configure the connection string

Open the `appsettings.json` file (if using .NET Core) or `Web.config` (if using .NET Framework), edit the connection string accordingly:

```json
// Example for .NET Core - appsettings.json
"ConnectionStrings": {
"DefaultConnection": "Server=.;Database=WebFashionDb;Trusted_Connection=True;"
}
