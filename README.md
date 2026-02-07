# Distribuidora FS – Inventory, Purchasing & Sales Management System

**Academic Project — Designed as a real-world desktop business system**

A C# (.NET) + SQL Server application built to manage a distribution company’s daily operations, including employees, clients, inventory control, purchase orders, sales orders, reporting, and audit tracking.

This project was developed using a layered architecture (**PL / BLL / DAL**) to ensure maintainability, separation of concerns, and clean data handling.

---

## 🧰 Tech Stack
- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **Database:** Microsoft SQL Server
- **Architecture:** Layered Architecture (PL / BLL / DAL)
- **Database Access:** Stored Procedures + parameterized queries
- **Data Handling:** DataTables / structured data flow

---

## 🎯 Key Features
- Employee management (**CRUD + search**)
- Client management (**CRUD + search**)
- Inventory module with stock control
- Purchase order system:
  - Purchase Order (header)
  - Purchase Order Detail
  - Payment status tracking
- Sales order system:
  - Sales Order (header)
  - Sales Order Detail
- Inventory transaction tracking:
  - Purchases
  - Sales
  - Stock adjustments
- Reports:
  - Stock availability
  - Sales by client
- Audit module:
  - Tracks actions and changes in purchase orders

---

## 🏗 Architecture (PL / BLL / DAL)
This system follows a layered architecture:

- **PL (Presentation Layer):** Windows Forms UI  
- **BLL (Business Logic Layer):** validations, workflows, and business rules  
- **DAL (Data Access Layer):** SQL Server stored procedures and database operations  

This structure helps keep the system modular, scalable, and easier to maintain.

---

## 📸 Screenshots

### Main Menu
![Main Menu](assets/screenshots/Menu%20Principal.png)

### Employee Module (CRUD + Search)
![Employee CRUD](assets/screenshots/Registro%20Empleado.png)

### Purchase Order Module
![Purchase Order](assets/screenshots/Crear%20orden%20de%20compra.png)

### Inventory Transactions
![Inventory Transactions](assets/screenshots/Transacciones%20del%20inventario.png)

### Stock Report
![Stock Report](assets/screenshots/Reporte%20Stock.png)

### Purchase Audit Module
![Purchase Audit](assets/screenshots/Auditoria%20compras.png)

---

## 📚 What I Learned
- Designing desktop business systems using layered architecture in .NET  
- Building relational workflows (purchase/sales orders with details)  
- Implementing inventory movement logic through transactions  
- Developing reporting modules based on SQL queries  
- Adding audit tracking to improve traceability and control  

---

## ▶️ How to Run (Basic Setup)
1) Open the solution in **Visual Studio**
2) Create the database in **SQL Server**
3) Run the SQL scripts (tables, stored procedures, initial data)
4) Update the connection string in the configuration file
5) Run the **Presentation** project

---

## 👤 Author
**Daniel Felipe Solano Quirós**  
- LinkedIn: https://www.linkedin.com/in/daniel-felipe-solano-quiros  
- GitHub: https://github.com/DnlSQ
