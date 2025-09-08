# 🎬 MovieTickets - Cinema Booking System

A modern, feature-rich cinema booking system built with ASP.NET Core MVC and Entity Framework Core. This application allows users to browse movies, select seats, and book tickets for their favorite films.

## ✨ Features

- **Movie Management**: Browse and search through available movies
- **Cinema & Theater Management**: Multiple cinema locations and theaters
- **Actor & Producer Profiles**: Detailed information about cast and crew
- **User Authentication & Authorization**: Secure login system with role-based access
- **Shopping Cart**: Add multiple tickets and manage your booking
- **Order Management**: Track and manage your ticket orders
- **Admin Panel**: Full CRUD operations for movies, cinemas, actors, and producers
- **Responsive Design**: Works seamlessly on desktop and mobile devices

## 🛠️ Technology Stack

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: SQL Server with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **Frontend**: HTML5, CSS3, Bootstrap, JavaScript
- **ORM**: Entity Framework Core
- **Architecture**: Repository Pattern with Service Layer

## 📋 Prerequisites

Before running this application, make sure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or Full version)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/klajdm/MovieTickets.git
cd MovieTickets
```

### 2. Configure Database Connection

Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnectionString": "Server=(localdb)\\mssqllocaldb;Database=MovieTicketsDb;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

### 3. Install Dependencies

```bash
cd MovieTickets
dotnet restore
```

### 4. Create and Update Database

```bash
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000`.

## 📊 Database Schema

The application uses the following main entities:

- **Movies**: Movie information, pricing, and scheduling
- **Cinemas**: Theater locations and details
- **Actors**: Actor profiles and movie associations
- **Producers**: Producer information
- **Orders**: User booking records
- **Users**: Authentication and user management
- **Shopping Cart**: Temporary ticket storage

## 🔐 Default Users

After running the database migrations, the following default users are created:

| Role  | Email                  | Password  |
| ----- | ---------------------- | --------- |
| Admin | admin@movietickets.com | Admin@123 |
| User  | user@movietickets.com  | User@123  |

## 🏗️ Project Structure

```
MovieTickets/
├── Controllers/          # MVC Controllers
├── Models/              # Data Models
├── Views/               # Razor Views
├── Data/                # DbContext and Services
├── Migrations/          # EF Migrations
├── wwwroot/            # Static files (CSS, JS, Images)
└── Program.cs          # Application entry point
```

## 🤝 Contributing

We welcome contributions! Please see our [Contributing Guidelines](CONTRIBUTING.md) for details.

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🐛 Issues

If you encounter any issues or have suggestions, please [open an issue](https://github.com/klajdm/MovieTickets/issues).

## 📧 Contact

- **Author**: Klajd M
- **Email**: klajdimurati3@gmail.com
- **GitHub**: [@klajdm](https://github.com/klajdm)
  
⭐ **If you find this project helpful, please give it a star!** ⭐
