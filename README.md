# Student Management System

## 📌 Project Overview

The **Student Management System** is a simple Windows Forms application built with **C# (.NET Framework)** and **SQLite** for backend storage. It allows users to manage student registrations, courses, enrollments, and grade assignments efficiently.

## 🚀 Features

- **Student Registration**: Add and manage student records.
- **Course Management**: Register new courses.
- **Unit Registration**: Assign units to courses.
- **Student Enrollment**: Enroll students in specific courses.
- **Grade Management**: Record assignment and CAT scores for students.
- **User-Friendly UI**: Developed using Windows Forms with a clean and intuitive design.

## 🏗️ Tech Stack

- **Frontend**: Windows Forms (WinForms)
- **Backend**: C# (.NET Framework)
- **Database**: SQLite
- **Version Control**: Git & GitHub

## 🛠️ Setup Instructions

### 1️⃣ Clone the Repository

```sh
 git clone https://github.com/yourusername/StudentManagementSystem.git
 cd StudentManagementSystem
```

### 2️⃣ Install Dependencies

Ensure **SQLite** is installed. If not, install via NuGet Package Manager:

```sh
 Install-Package System.Data.SQLite
 Install-Package System.Data.SQLite.Core
```



### 3️⃣ Database Setup

- The SQLite database file is located in the `bin/` folder.
- If missing, a new database will be generated on application startup.

### 4️⃣ Run the Project

1. Open **Visual Studio**.
2. Load the `.sln` file.
3. Press `F5` to run the application.

## 📂 Project Structure

```
StudentManagementSystem/
│── DatabaseHelper.cs   # Handles SQLite database operations
│── Form1.cs           # Main dashboard UI
│── Form2.cs           # Additional UI for module handling
│── Program.cs         # Application entry point
│── StudentManagementSystem.sln # Visual Studio Solution File
│── bin/               # Contains compiled application & database file
│── obj/               # Build artifacts
```

## 🔗 Contributing

Want to contribute? Follow these steps:

1. Fork the repository.
2. Create a new branch (`feature-branch-name`).
3. Commit changes and push to your fork.
4. Submit a Pull Request.

## 📜 License

This project is open-source and available under the **MIT License**.

---


