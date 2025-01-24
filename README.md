
# Restaurant Management System

---

## 🌟 Overview

The **Restaurant Management System** is a full-stack platform designed to enhance restaurant operations and improve the dining experience for customers. It features an intuitive **user panel** for customers and a robust **admin dashboard** for restaurant staff. 

This system was developed as part of the **Full Stack Frenzy Hackathon** hosted by **ACM-MAJU** at **MAJU University**. It showcases our team's expertise in creating innovative solutions under time constraints while leveraging modern technologies. The project is currently a **work in progress**, with additional features and refinements planned.

---

## 🔑 Key Features

### 🛠 User Module:

1. **Table Reservation:**
   - View available tables and make real-time reservations.
   - Receive confirmations for successful bookings.
2. **Menu and Ordering:**
   - Browse the menu and place food orders.
   - Track the status of orders (e.g., "Preparing," "Ready").
3. **Profile Management:**
   - Manage user details and view past orders.

### 📊 Admin Module:

1. **Table Management:**
   - Monitor and update table availability.
   - Customize table layouts.
2. **Menu Management:**
   - Add, edit, or delete menu items.
   - Manage item descriptions, pricing, and availability.
3. **Order Management:**
   - Track and manage incoming orders.
   - Notify kitchen staff and update order progress.
4. **Inventory Control:**
   - Manage ingredient stock and get low-inventory alerts.
5. **Reports & Analytics:**
   - View reports on sales and customer engagement.

---

## 🖥 Technology Stack

### Frontend:

- **HTML**: For structuring the web pages.
- **CSS**: For designing and styling the interface.
- **JavaScript**: For interactive features and functionalities.
- **Bootstrap**: For responsive layouts and ready-made UI components.

### Backend:

- **.NET Core**: For building APIs and handling server-side logic.

### Database:

- **SQL Server**: For storing and managing application data.

---

## 🛠 Setup Guide

### Prerequisites:

1. **Software Requirements:**
   - Visual Studio 2022 or later
   - SQL Server
   - Modern web browser (e.g., Chrome, Edge)
2. **Packages:**
   - .NET Core 6.0 SDK

### Installation Steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/restaurant-management-system.git
   cd restaurant-management-system
   ```
2. **Database Setup:**
   - Open SQL Server Management Studio (SSMS).
   - Create a database (e.g., `Restaurant_Management`).
   - Execute SQL scripts in the `/Database` folder.
3. **Configure Connection String:**
   - Update `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Restaurant_Management;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
     }
     ```
4. **Restore Dependencies:**
   - Open Visual Studio.
   - Navigate to **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**.
   - Restore missing packages.
5. **Run the Application:**
   - Set the startup project to `Restaurant.Web`.
   - Press `F5` to launch.

### Access Points:

- **User Panel:** Accessible at `/User` for customers.
- **Admin Panel:** Accessible at `/Admin` for restaurant staff.

---

## 📈 Highlights

- **Hackathon Origin:** Developed during the **Full Stack Frenzy Hackathon** by ACM-MAJU at MAJU University.
- **Work in Progress:** Actively being improved with additional features and optimizations.
- **Full-Stack Implementation:** Combines modern frontend and backend technologies for a seamless user experience.

---

## 🎥 Media

A video demonstration will be added once the platform is fully functional.

---

## ✉ Contact

For inquiries or contributions, please email: [rabiaimtiaz203@gmail.com](mailto:rabiaimtiaz203@gmail.com).

