# tenantpropertymanagement

# 🏢 Tenant Property Management System

A modern **multi-tenant property management platform** built with **DevExpress XAF (Blazor Server + EF Core)**. This system is designed to manage properties, tenants, leases, payments, and organizational data in a clean, secure, and scalable way.

---

## ✨ Why This Project Exists

Managing properties isn’t just about storing data — it’s about **clarity, control, and security**. This project aims to:

* Simplify tenant & lease management
* Support **multi-organization (multi-tenant)** environments
* Provide enterprise-grade **role-based security**
* Deliver a fast, responsive **Blazor UI** powered by XAF

Whether you’re building a SaaS product or an internal management system, this project gives you a solid foundation.

---

## 🚀 Tech Stack

* **.NET 7 / 8**
* **DevExpress XAF** (Blazor Server)
* **Entity Framework Core**
* **SQL Server**
* **ASP.NET Core Security**
* **Multi-Tenancy (XAF)**

---

## 🧩 Core Modules & Features

### 🔐 Security Module

Role-based access control with fine-grained permissions.

* Users
* Roles
* My Details (Self-service profile)
* Permission Policies

Supports tenant isolation and secure data access.

---

### 🏢 Master Data

Centralized data used across the system.

* Organizations
* Portfolio Properties
* Tenant Base Objects

---

### 🏠 Leasing Module

Everything related to leasing and tenants.

* Lease Tenant Management
* Leases
* Lease Status Tracking
* Organization-aware data filtering

---

### 💰 Finance Module

Track financial operations clearly and securely.

* Payments
* Charges
* Transaction history

---

### 📅 Scheduler & Workflows

* Scheduler Events
* Work Orders
* Action-based workflows

---

## 🧭 Navigation Structure

The application uses **XAF Navigation Groups** for clarity:

```
Security
 ├── Users
 ├── Role
 └── My Details

Master Data
 ├── Organization
 └── Portfolio Property

Leasing
 ├── Lease Tenant
 └── Leases

Finance
 ├── Payment
 └── Charge
```

This ensures a clean, intuitive user experience even as the system grows.

---

## 🌐 Multi-Tenancy

This project uses **XAF Multi-Tenancy** to:

* Isolate data per organization
* Share infrastructure while keeping data secure
* Allow system-wide admins and tenant-specific users

Each tenant sees **only their own data** — automatically enforced at the ORM level.

---

## 🧪 Getting Started

### Prerequisites

* .NET SDK 7 or higher
* SQL Server
* Visual Studio 2022+
* DevExpress Subscription

---

### Run Locally

1. Clone the repository

   ```bash
   git clone https://github.com/yourusername/tenant-property-management.git
   ```

2. Update `appsettings.json`

   ```json
   "ConnectionStrings": {
     "ConnectionString": "Server=.;Database=TenantPropertyDb;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```

3. Run database migrations

4. Start the Blazor project

---

## 🛡️ Security Best Practices

* Permission-based UI visibility
* Tenant-aware queries
* Role-level access control
* Secure authentication & authorization pipeline

---

## 🧱 Architecture Highlights

* Clean separation of modules
* EF Core + XAF Object Space
* Strong domain-driven design
* Extendable via Controllers & Modules

---

## 🛠️ Customization

You can easily extend this system by:

* Adding new modules
* Creating custom ListViews & DetailViews
* Extending navigation groups
* Plugging in payment gateways or external services

---

## 📸 Screenshots

> Screenshots coming soon — UI focuses on clarity, speed, and enterprise-grade usability.

---

## 🧭 Roadmap

* ✔ Multi-tenant foundation
* ✔ Role-based security
* ⏳ Reporting dashboards
* ⏳ Payment gateway integration
* ⏳ Audit & compliance enhancements

---

## 🤝 Contributing

Contributions are welcome!

* Fork the repo
* Create a feature branch
* Submit a pull request

Please follow clean commit practices and descriptive PRs.

---

## 📄 License

This project is licensed under the **MIT License**.

---

## ❤️ Acknowledgements

* DevExpress XAF Team
* ASP.NET Core Community
* Open-source contributors

---

## 📬 Contact

Built with passion for scalable enterprise systems.

If you have ideas, issues, or improvements — open an issue or start a discussion 🚀
