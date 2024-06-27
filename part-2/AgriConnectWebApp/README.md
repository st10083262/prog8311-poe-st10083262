# Agri-Energy Connect Platform

The Agri-Energy Connect Platform is an innovative web application designed to facilitate the collaboration between farmers and energy experts to promote the adoption of renewable energy resources in the agricultural sector. This prototype demonstrates a functional model of the intended final product, showcasing essential features and functionalities.

## Table of Contents
1. [Features](#features)
2. [Technologies Used](#technologies-used)
3. [Installation](#installation)
4. [Database Setup](#database-setup)
5. [Running the Application](#running-the-application)
6. [Usage](#usage)
7. [Project Structure](#project-structure)
8. [Contributing](#contributing)
9. [License](#license)

## Features

- **Database Development and Integration**: Manage information about farmers and their products.
- **User Roles and Authentication**: Secure login functionality with distinct roles for farmers and employees.
- **Farmer Features**: Add products with details like name, category, and production date.
- **Employee Features**: Add new farmer profiles, view and filter products.
- **User Interface Design**: User-friendly interface with responsive design for various devices.
- **Data Validation**: Maintain accuracy and consistency of data with validation checks.

## Technologies Used

- **ASP.NET Core 5.0**
- **Entity Framework Core**
- **SQL Server**
- **ASP.NET Core Identity**
- **Bootstrap 4**
- **Swagger for API Documentation**

## Installation

1. **Clone the repository:**
   ```shell
   git clone https://github.com/yourusername/agrienergyconnect.git
   cd agrienergyconnect
Install the required packages:

shell
Copy code
dotnet restore
Setup the database:
Follow the instructions in the Database Setup section.

Database Setup
Configure Connection String:
Update the connection string in appsettings.json to match your SQL Server instance.

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgriEnergyConnectDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Run Migrations:
Open a terminal in the project directory and run the following commands:

shell
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
Seed the Database:
You can optionally seed the database with initial data by modifying the ApplicationDbContextSeed class and running the application.

Running the Application
Run the application:

shell
Copy code
dotnet run
Open your browser:
Navigate to https://localhost:5001 or http://localhost:5000.

Usage
Login as Farmer:
Username: farmer@example.com
Password: Password123!
Login as Employee:
Username: employee@example.com
Password: Password123!
Farmer Functionality:
Add new products.
View own product listings.
Employee Functionality:
Add new farmer profiles.
View and filter all products from specific farmers.
Project Structure
mathematica
Copy code
AgriEnergyConnect/
├── Controllers/
│   ├── FarmersController.cs
│   ├── EmployeesController.cs
│   └── ProductsController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   ├── ApplicationDbContextSeed.cs
├── Models/
│   ├── Farmer.cs
│   ├── Employee.cs
│   └── Product.cs
├── Views/
│   ├── Farmers/
│   ├── Employees/
│   └── Products/
├── wwwroot/
│   ├── css/
│   ├── js/
├── appsettings.json
├── Program.cs
├── Startup.cs
└── README.md
Contributing
Contributions are welcome! Please fork this repository and submit pull requests with your proposed changes.

License
This project is licensed under the MIT License. See the LICENSE file for details