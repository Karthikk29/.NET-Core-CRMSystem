CRM System – Backend API
A lightweight Customer Relationship Management (CRM) backend system built using .NET Core Web API and MySQL. It allows you to manage users, leads, contacts, companies, and deals with full CRUD functionality.

🛠 Tech Stack
Backend: ASP.NET Core Web API (.NET 6/7)

Database: MySQL

ORM: Entity Framework Core

Authentication: JWT (JSON Web Tokens)

API Testing & Docs: Swagger

📦 Dependencies
Installed via NuGet:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Pomelo.EntityFrameworkCore.MySql

Microsoft.AspNetCore.Authentication.JwtBearer

Swashbuckle.AspNetCore (for Swagger)

Microsoft.Extensions.Configuration

⚙️ How to Run This Project
1. Clone the Repository
bash
Copy
Edit
git clone https://github.com/your-username/crm-backend.git
cd crm-backend
2. Configure MySQL Database
Make sure MySQL is running. Update your appsettings.json with your own DB credentials:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;user=root;password=yourpassword;database=crm_db"
}
3. Run EF Core Migrations
Generate and apply the database schema:

bash
Copy
Edit
dotnet ef database update
If you haven't added the EF CLI:

bash
Copy
Edit
dotnet tool install --global dotnet-ef
4. Run the API Server
bash
Copy
Edit
dotnet run
The backend will start (usually on http://localhost:5062).

5. Test APIs via Swagger
Open your browser and visit:

bash
Copy
Edit
http://localhost:5062/swagger
You can use Swagger UI to test all endpoints.

📁 Project Structure
graphql
Copy
Edit
CRMSystem/
├── Controllers/       # API endpoints
├── Models/            # Entity models (User, Lead, Company, etc.)
├── Data/              # DB context and migrations
├── Services/          # JWT service and utilities
├── Program.cs         # Entry point and middleware config
├── appsettings.json   # Configuration file
✅ Features
JWT-based authentication for secure access

CRUD operations for all major CRM entities

Modular and clean structure using best practices

CORS enabled for frontend integration

Swagger UI for real-time API testing
