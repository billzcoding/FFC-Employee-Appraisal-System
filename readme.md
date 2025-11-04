# FFC Employee Appraisal System (EPAS)

## 🌟 Overview
This project is an **Employee Performance Appraisal System (EPAS)** developed for Fauji Fertilizer Company (FFC) during a software development internship. The application aims to replace traditional, paper-based performance reviews with a modern, digitized solution built on the ASP.NET Core Blazor framework.

## 🚀 Key Features
* **Performance Tracking:** Captures and stores comprehensive employee appraisal data.
* **Skill-Based Rating:** Utilizes dedicated models for Conceptual, Human, and Professional Skills.
* **Custom Authentication:** Secure user access management with custom authentication and session state handling.
* **Role-Based Access:** Different user types (e.g., employee, manager) can be accommodated through login logic.
* **Data Persistence:** Uses Entity Framework Core (Code-First approach) for robust data storage.

## 🛠️ Technology Stack
* **Frontend/Framework:** ASP.NET Core Blazor
* **Backend:** C# (.NET Core)
* **Database:** SQL Server (via Entity Framework Core)
* **Data Access:** Repository Pattern (in progress/planned)

## 📁 Project Structure Highlights

| Folder | Purpose | Key Files/Models |
| :--- | :--- | :--- |
| **Pages** | Blazor components for UI and Routing. | `Login.razor`, `CreateRequest.razor`, `Routes.razor` |
| **Models** | Domain entities for the application. | `Appraisal.cs`, `Employee.cs`, `*Skills.cs`, `User.cs` |
| **Data** | Database context and initial data setup. | `AppDbContext.cs`, `DbInitializer.cs` |
| **Services** | Business logic and utility services. | `CustomAuthenticationService.cs`, `SessionState.cs` |

## ⚙️ Setup and Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/FFC-Employee-Appraisal-System.git](https://github.com/your-username/FFC-Employee-Appraisal-System.git)
    ```
2.  **Update Database Connection:**
    * Modify the connection string in `appsettings.json` to point to your local SQL Server instance.
3.  **Run Migrations:**
    * Open the Package Manager Console in Visual Studio and run:
        ```powershell
        Add-Migration InitialCreate
        Update-Database
        ```
4.  **Run the Application:**
    * Execute the project from Visual Studio or use the command line:
        ```bash
        dotnet run
        ```

---

Do you have the code ready for your **Repository** service or interface, or shall we start creating those files next?
