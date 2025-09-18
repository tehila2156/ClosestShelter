# 🛡️ Protected Space Locator – Full-Stack Project (C#, SQL, HTML)

**Final Exercise – Summary Project**  

A social project designed to allow individuals to share private locations available for shelter during emergencies.  
Users can register their private spaces and others can find these locations when needed. Future improvements may integrate public and private locations sorted by distance.  

---

## ✨ **Features**
- 🏠 **Publish a New Shelter** – individuals can add their own protected spaces with details.  
- 📅 **Recent Locations** – view locations added in the last month.  
- 📍 **Nearest Locations** – find the 10 closest shelters to the user's current position (using simulated or third-party API).  
- 🗂️ **Structured Data Models** – building types, addresses, and reviews.  
- 🔒 **Optional User Authentication** – restrict access to verified users only.  

---

## 🖥️ **System Architecture**
- **Clean Architecture / Layered Design** – separation between presentation, business logic (BLL), and data access (DAL).  
- **Data Layer (SQL)** – tables for building types, addresses, and reviews populated with initial data.  
- **Business Logic Layer** – calculates distance, handles filtering and sorting, and uses DTOs for data transfer.  
- **Presentation Layer (HTML)** – interface for publishing and viewing locations.  

---

## 🛠️ **Technologies**
- **Backend**: C#  
- **Database**: SQL Server  
- **Frontend**: HTML, CSS  
- **Architecture**: Clean Architecture, DTOs, BLL, Design Patterns  

---

## 🚀 **Getting Started**
1. Set up the SQL database and populate tables with initial data.  
2. Run the backend project in your IDE (e.g., Visual Studio).  
3. Open the HTML interface to publish locations and search for nearby shelters.  
4. (Optional) Enable authentication for verified users.  

---

## 📚 **Project Goals**
- Practice layered architecture and Clean Architecture principles.  
- Implement full CRUD functionality for location management.  
- Apply Design Patterns and separation of concerns.  
- Learn integration of external APIs (simulated or real) for distance calculations.
