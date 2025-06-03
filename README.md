# CRM System – Backend API

A lightweight **Customer Relationship Management (CRM)** backend system built using **.NET Core Web API** and **MySQL**. It allows you to manage **users, leads, contacts, companies, and deals** with full CRUD functionality.

---

## Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 6/7)  
- **Database:** MySQL  
- **ORM:** Entity Framework Core  
- **Authentication:** JWT (JSON Web Tokens)  
- **API Testing & Documentation:** Swagger  

---

## Dependencies

Installed via NuGet:

- `Microsoft.EntityFrameworkCore`  
- `Microsoft.EntityFrameworkCore.Design`  
- `Pomelo.EntityFrameworkCore.MySql`  
- `Microsoft.AspNetCore.Authentication.JwtBearer`  
- `Swashbuckle.AspNetCore` (for Swagger)  
- `Microsoft.Extensions.Configuration`  

---

## How to Run This Project

1. **Clone the repository** to your local machine:

    ```bash
    git clone https://github.com/your-username/crm-backend.git
    cd crm-backend
    ```

2. **Configure MySQL Database**

    Make sure MySQL is running on your system.  
    Update the connection string in `appsettings.json` with your MySQL server details:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;port=3306;user=root;password=yourpassword;database=crm_db"
    }
    ```

3. **Apply EF Core migrations** to create the database schema. If needed, install EF Core CLI tools:

    ```bash
    dotnet tool install --global dotnet-ef
    dotnet ef database update
    ```

4. **Run the API server:**

    ```bash
    dotnet run
    ```

    By default, it will start on:  
    `http://localhost:5062`

5. **Test the API via Swagger UI**

    Open your browser and navigate to:  
    `http://localhost:5062/swagger`  

    Use Swagger UI to interactively test all API endpoints.

---

## Project Structure
Controllers/ # API endpoints for users, leads, contacts, companies, and deals
Models/ # Data models: User, Lead, Contact, Company, Deal
Data/ # Database context and migrations
Services/ # Services like JWT token generation and validation
Program.cs # Application entry point, middleware & services config
appsettings.json # Configuration file (DB connection strings, JWT secrets, etc.)


---

## Features

- Secure JWT-based authentication for all API requests  
- CRUD operations for all CRM entities  
- Clean, modular architecture following best practices  
- CORS enabled for seamless frontend integration  
- Swagger UI for convenient API documentation and testing  

---


