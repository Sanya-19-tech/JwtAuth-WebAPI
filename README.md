# 🔐 JWT Authentication & Authorization Web API

## 📌 Project Overview
This project demonstrates secure API implementation using:

- ASP.NET Core Web API
- In-memory user authentication
- JWT (JSON Web Token) generation and validation
- Role-based authorization
- Unit testing with 100% code coverage

---

## 🚀 Features

✔ User login with JWT token generation  
✔ Token validation using JWT Bearer Authentication  
✔ Role-based access control (Admin/User)  
✔ Secured endpoints using `[Authorize]` attribute  
✔ Unit testing with xUnit  
✔ 100% Code Coverage  

---

## 🔑 API Endpoints

### 🔹 Login

POST /api/auth/login

### 🔹 Authenticated Endpoint

GET /api/secure/user

Accessible to any authenticated user.

### 🔹 Admin Endpoint

GET /api/secure/admin

Accessible only to users with **Admin** role.

---

## 🧪 Unit Testing

- Positive test cases
- Negative test cases
- Null input handling
- Controller testing
- Service testing
- Code Coverage ≥ 70% (Achieved 100%)

---

## 🛠 Technologies Used

- ASP.NET Core Web API
- JWT Bearer Authentication
- xUnit Testing Framework
- Swashbuckle (Swagger)

---

## 👩‍💻 Author
Sanya Shukla
