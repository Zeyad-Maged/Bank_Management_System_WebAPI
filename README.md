## 🎯 Bank Management System  

### 💡 Overview  
This is an ASP.NET Web API project designed to manage a banking system. The project includes various components such as:  

- **Entities**: Account, BankCard, Customer, Branch  
- **Data Transfer Objects (DTOs)**: InitialMigration, Merged  
- **Repositories**: Interfaces and implementations for Account, Branch, and Customer data management  
- **Models**: AppDbContextModelSnapshot for database context  
- **Controllers**: Organized to handle API requests and responses  

The project is structured to provide a robust backend service with features for creating, managing, and retrieving data related to customer accounts, bank cards, branches, and more. It utilizes a clean architecture with separate layers for data, business logic, and API interfaces.  

### ✨ Features  
- RESTful API endpoints for CRUD operations  
- Entity Framework for data access and management  
- Organized file structure for scalability and maintainability  

### 🌐 API Endpoints  
- **POST /api/accounts**: Create a new account profile  
- **GET /api/accounts/{id}**: Retrieve an account profile by ID  
- **PUT /api/accounts/{id}**: Update an existing account profile  
- **DELETE /api/accounts/{id}**: Remove an account profile  
- **POST /api/users**: Add a new user  
- **GET /api/users/{id}**: Fetch user details by ID  
- **PUT /api/users/{id}**: Modify user information  
- **DELETE /api/users/{id}**: Delete a user  
- **POST /api/branches**: Insert a new branch  
- **GET /api/branches/{id}**: Obtain branch details  
- **PUT /api/branches/{id}**: Edit branch information  
- **DELETE /api/branches/{id}**: Eliminate a branch  
- **POST /api/customers**: Create a new customer  
- **GET /api/customers/{id}**: Retrieve customer data  
- **PUT /api/customers/{id}**: Update customer details  
- **DELETE /api/customers/{id}**: Remove a customer  
