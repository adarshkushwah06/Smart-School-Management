# 🏫 SchoolSync - Smart School Management System

A comprehensive, full-stack school management system designed to streamline educational institution operations. This repository contains **two complete implementations** of the same application - one built with **Spring Boot** and another with **.NET**, both featuring a modern **React** frontend.

![Java](https://img.shields.io/badge/Java-21-orange.svg)
![Spring Boot](https://img.shields.io/badge/Spring%20Boot-4.0.2-brightgreen.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)
![React](https://img.shields.io/badge/React-18.2-61dafb.svg)

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [API Documentation](#-api-documentation)
- [Screenshots](#-screenshots)
- [Contributing](#-contributing)


---

## 🎯 Overview

**SchoolSync** is a modern school management solution that provides role-based access for **Administrators**, **Teachers**, and **Students**. The system handles everything from student admissions to fee management, attendance tracking, and result publication.

### 🔑 Key Highlights

- ✅ **Role-Based Access Control** - Separate dashboards for Admin, Teacher, and Student
- ✅ **Complete Admission Workflow** - Online application submission and status tracking
- ✅ **Attendance Management** - Daily attendance marking with visual calendar
- ✅ **Fee Management** - Payment tracking with Razorpay integration
- ✅ **Result Management** - Grade entry and report generation
- ✅ **Email Notifications** - Automated emails for admission updates
- ✅ **PDF Report Generation** - Downloadable reports and fee receipts
- ✅ **Responsive Design** - Works seamlessly on desktop and mobile

---

## ✨ Features

### 👨‍💼 Admin Module
| Feature | Description |
|---------|-------------|
| **Dashboard** | Overview of students, teachers, and admissions |
| **Manage Admissions** | Review, approve, or reject admission applications |
| **Manage Students** | View, edit, and manage student records |
| **Manage Teachers** | Add, update, and remove teacher profiles |
| **Fee Management** | Track payments, generate receipts |
| **Attendance Overview** | Monitor attendance across all classes |
| **Result Management** | Publish and manage student results |
| **Enrollment Management** | Handle student enrollments and class assignments |

### 👩‍🏫 Teacher Module
| Feature | Description |
|---------|-------------|
| **Dashboard** | Personal dashboard with assigned classes |
| **Mark Attendance** | Daily attendance marking for students |
| **Enter Results** | Grade entry for assigned subjects |
| **View Profile** | Personal information management |

### 👨‍🎓 Student Module
| Feature | Description |
|---------|-------------|
| **Dashboard** | Personal dashboard with attendance calendar |
| **View Attendance** | Visual attendance history with calendar view |
| **View Results** | Access grades and report cards |
| **View Profile** | Personal and academic information |
| **Fee Status** | View and pay pending fees |

### 🌐 Public Features
| Feature | Description |
|---------|-------------|
| **Admission Form** | Online admission application |
| **Check Status** | Track admission application status |
| **Registration** | New user registration with roll number |
| **Login** | Secure authentication with JWT |

---

## 🛠️ Tech Stack

### Spring Boot Version
| Layer | Technology |
|-------|------------|
| **Backend** | Java 21, Spring Boot 4.0.2, Spring Security, Spring Data JPA |
| **Database** | MySQL |
| **Authentication** | JWT (JSON Web Tokens) |
| **API Docs** | Swagger / OpenAPI 3.0 |
| **PDF Generation** | iText 7 |
| **Email** | Spring Boot Mail (SMTP) |
| **Build Tool** | Maven |

### .NET Version
| Layer | Technology |
|-------|------------|
| **Backend** | .NET 8.0, ASP.NET Core Web API, Entity Framework Core |
| **Database** | MySQL |
| **Authentication** | JWT (JSON Web Tokens) |
| **Build Tool** | MSBuild |

### Frontend (Common)
| Layer | Technology |
|-------|------------|
| **Framework** | React 18.2 |
| **Build Tool** | Vite 5.0 |
| **Routing** | React Router DOM 6.20 |
| **HTTP Client** | Axios |
| **Styling** | Bootstrap 5.3, Custom CSS |
| **Forms** | Formik + Yup validation |
| **Alerts** | SweetAlert2 |
| **Excel Export** | xlsx |

---

## 📁 Project Structure

```
SchoolSync/
├── SchoolSync with SpringBoot/
│   ├── backend/
│   │   ├── src/main/java/com/schoolsync/
│   │   │   ├── config/          # Security & app configuration
│   │   │   ├── controller/      # REST API endpoints
│   │   │   ├── dto/             # Data Transfer Objects
│   │   │   ├── entity/          # JPA Entity models
│   │   │   ├── exception/       # Custom exceptions
│   │   │   ├── repository/      # Data access layer
│   │   │   ├── service/         # Business logic
│   │   │   └── util/            # Utility classes
│   │   └── pom.xml
│   └── Frontend/
│       ├── src/
│       │   ├── components/      # Reusable React components
│       │   ├── context/         # React Context (Auth)
│       │   ├── pages/           # Page components
│       │   ├── services/        # API services
│       │   └── styles/          # CSS styles
│       └── package.json
│
└── SchoolSync with .NET/
    ├── Backend/
    │   ├── Controllers/         # API Controllers
    │   ├── DTOs/                # Data Transfer Objects
    │   ├── Models/              # Entity models
    │   ├── Repositories/        # Data access layer
    │   ├── Services/            # Business logic
    │   └── Data/                # DbContext
    └── frontend/
        └── (Same structure as SpringBoot version)
```

---

## 🚀 Getting Started

### Prerequisites

- **Java 21** (for Spring Boot version)
- **.NET 8 SDK** (for .NET version)
- **Node.js 18+** and npm
- **MySQL 8.0+**
- **Maven 3.9+** (for Spring Boot version)

### Spring Boot Version Setup

#### 1. Clone the Repository
```bash
git clone https://github.com/saurabhmahajan45/SchoolSync.git
cd "SchoolSync/SchoolSync with SpringBoot"
```

#### 2. Configure Database
Update `backend/src/main/resources/application.properties`:
```properties
spring.datasource.url=jdbc:mysql://localhost:3306/schoolsync?createDatabaseIfNotExist=true
spring.datasource.username=your_username
spring.datasource.password=your_password
```

#### 3. Configure Email (Optional)
```properties
spring.mail.username=your_email@gmail.com
spring.mail.password=your_app_password
```

#### 4. Run Backend
```bash
cd backend
mvn spring-boot:run
```
Backend runs on `http://localhost:9090`

#### 5. Run Frontend
```bash
cd Frontend
npm install
npm run dev
```
Frontend runs on `http://localhost:5173`

### .NET Version Setup

#### 1. Navigate to .NET Project
```bash
cd "SchoolSync/SchoolSync with .NET"
```

#### 2. Configure Database
Update `Backend/appsettings.json` with your MySQL connection string.

#### 3. Run Backend
```bash
cd Backend
dotnet run
```

#### 4. Run Frontend
```bash
cd frontend
npm install
npm run dev
```

---

## 📚 API Documentation

### Spring Boot Version
After starting the backend, access Swagger UI at:
```
http://localhost:9090/swagger-ui.html
```

### Key API Endpoints

| Module | Endpoint | Methods |
|--------|----------|---------|
| **Auth** | `/api/auth/*` | POST (login, register) |
| **Admission** | `/api/admissions/*` | GET, POST, PUT |
| **Students** | `/api/students/*` | GET, POST, PUT, DELETE |
| **Teachers** | `/api/teachers/*` | GET, POST, PUT, DELETE |
| **Attendance** | `/api/attendance/*` | GET, POST |
| **Results** | `/api/results/*` | GET, POST, PUT |
| **Fees** | `/api/fees/*` | GET, POST, PUT |
| **Enrollment** | `/api/enrollments/*` | GET, POST |

---

## 📸 Screenshots

### 1. Home Page
<img width="1443" height="911" alt="Screenshot 2026-02-05 234408" src="https://github.com/user-attachments/assets/2db23973-5988-4cba-865b-120d44906ba0" />

### 2. Admission Form
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233425" src="https://github.com/user-attachments/assets/21818ee8-85b3-4366-bf5b-cd66792919ca" />
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233324" src="https://github.com/user-attachments/assets/a51a2259-fe48-42ac-8967-ff59384fd2d0" />

### 3. Student Dashboard
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233836" src="https://github.com/user-attachments/assets/68f974db-4974-40ee-8fd4-91a4ab1fd966" />

### 4. Teacher Dashboard
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233519" src="https://github.com/user-attachments/assets/c34bca29-7e8d-4527-87d6-345a08536fdb" />

### 5. Admin Dashboard
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233306" src="https://github.com/user-attachments/assets/485dfa8d-555e-402b-91e0-713bd982b683" />

### 6. Mark Attendance
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233506" src="https://github.com/user-attachments/assets/76f8126d-0467-4d76-9e7d-7c9627c3cefb" />

### 7. Fee Managament
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233344" src="https://github.com/user-attachments/assets/e6dc273f-2c6b-470a-9584-161c5ca7bc4c" />
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233916" src="https://github.com/user-attachments/assets/d4370cc6-959c-4860-aa49-b96c73b8cd02" />

### 8. Result Management 
<img width="1920" height="1080" alt="Screenshot 2026-02-05 233412" src="https://github.com/user-attachments/assets/68c701ab-b7f0-49cb-938d-f238e3f9db40" />


## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---


## 📞 Contact

**Developer:** Saurabh Mahajan

- 📧 Email: sam45mahajan@gmail.com
- 💼 GitHub: [@Saurabhmahajan45](https://github.com/Saurabhmahajan45)

---

## ⭐ Show Your Support

If you find this project helpful, please give it a ⭐ on GitHub!

---

<p align="center">Made with ❤️ for the education community</p>
