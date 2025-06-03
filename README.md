# 📊 CRM System – Backend API

A lightweight **Customer Relationship Management (CRM)** backend system built using **.NET Core Web API** and **MySQL**. It allows you to manage **users, leads, contacts, companies, and deals** with full CRUD functionality.

---

## 🛠 Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 6/7)  
- **Database:** MySQL  
- **ORM:** Entity Framework Core  
- **Authentication:** JWT (JSON Web Tokens)  
- **API Testing & Docs:** Swagger  

---

## 📦 Dependencies

Installed via NuGet:

- `Microsoft.EntityFrameworkCore`  
- `Microsoft.EntityFrameworkCore.Design`  
- `Pomelo.EntityFrameworkCore.MySql`  
- `Microsoft.AspNetCore.Authentication.JwtBearer`  
- `Swashbuckle.AspNetCore` (for Swagger)  
- `Microsoft.Extensions.Configuration`

---

## ⚙️ How to Run This Project

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/crm-backend.git
cd crm-backend
## ⚙️ How to Run This Project

### 2. Configure MySQL Database

Ensure MySQL is running. Then, update your `appsettings.json` with your database credentials:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;user=root;password=yourpassword;database=crm_db"
}
### 3. Run EF Core Migrations

Generate and apply the database schema:

```bash
dotnet ef database update
### 4. Run the API Server

Start the backend server by running:

```bash
dotnet run
### 5. Test APIs via Swagger

To test the API endpoints, use Swagger UI:

1. Open your browser and go to:

http://localhost:5062/swagger

2. You’ll see a list of all available API routes with methods like GET, POST, PUT, DELETE.
3. You can interact with the endpoints directly from the browser—no need for tools like Postman.

Swagger makes it easy to debug, explore, and understand how your API works in real-time.
