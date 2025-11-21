<<<<<<< HEAD
# ShaluAcxiomCRM

A fully functional CRM (Customer Relationship Management) System built using ASP.NET Core MVC and Entity Framework Core, designed to manage Customers, Employees, and Reports with a modern interactive dashboard and smooth database integration.

The system provides a centralized platform for maintaining business records, tracking activity, viewing statistics, and performing CRUD operations with an elegant UI powered by Bootstrap.

This project is ideal for companies, small businesses, and students learning ASP.NET Core MVC + EF Core.

⭐ Key Features
📊 1. Dashboard Summary

The dashboard displays real-time business metrics:

Total Customers

Total Employees

New Customers Today

New Employees Today

Recent Customers List

Recent Employees List

The data is fetched dynamically using EF Core with clean UI components.

🔍 2. Smart Customer & Employee Search

An advanced search system where you can search by:

Name

Email

Phone Number

✔ Features of Search:

Instant search results

AJAX/Fetch API based live filtering

Full details open in a Bootstrap modal popup

No page reload required

👥 3. Customer Management Module

Add New Customer

Edit Customer Profile

Delete Customer

View All Customers

Customer Activity Summary

100% dynamic and database-driven using Entity Framework Core.

💼 4. Employee Management Module

Add Employee

Update Employee Details

Delete Employee

View All Employees

Position & Contact Information

Clean UI and responsive design for better usability.

📄 5. Reports Module (If your project includes reports)

Daily Insight Reports

Customer/Employee Summary

Activity Tracking

Charts & Tables

🛠️ Tech Stack
Technology	Purpose
ASP.NET Core MVC	Main Application Framework
Entity Framework Core	ORM & Database Operations
SQL Server	Relational Database
Bootstrap 5	Responsive UI Components
JavaScript + Fetch API	Live Search + AJAX
LINQ	Data Queries & Filtering
📁 Project Structure
├── Controllers
│     ├── DashboardController.cs
│     ├── CustomerController.cs
│     ├── EmployeeController.cs
│
├── Views
│     ├── Dashboard
│     │     ├── Index.cshtml
│     │     ├── _CustomerDetails.cshtml
│     │     ├── _EmployeeDetails.cshtml
│     ├── Customer
│     ├── Employee
│
├── Models
│     ├── Customer.cs
│     ├── Employee.cs
│     ├── Report.cs
│
├── wwwroot
│     ├── css
│     ├── js
│     ├── libs

🚀 How to Run the Project (Step-by-Step)
1️⃣ Clone the Repository
git clone https://github.com/yourusername/your-repository.git

2️⃣ Open the Project

Open the .sln file in Visual Studio 2022+.

3️⃣ Configure SQL Database

Open appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR-SERVER;Database=CRM_DB;Trusted_Connection=True;"
}


Replace with your SQL Server details.

4️⃣ Run Entity Framework Migrations

If database is not created:

Update-Database


This will auto-create all tables.

5️⃣ Run the Application
Option 1 (Terminal)
dotnet run


=======
# ShaluAcxiom
>>>>>>> bd9680288402e1b468b417b688d6c5aa86319206
