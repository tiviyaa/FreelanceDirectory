# Complete Developer Network (CDN) - Freelancer User Management API

This is a RESTful API for managing freelancers in the **Complete Developer Network (CDN)** system. The API allows you to register, update, delete, and retrieve user information. The application also supports recycling deleted IDs to avoid gaps in the ID sequence.

## Project Overview

The API offers the following features:

1. **Register a new user (POST)**
2. **Retrieve all users (GET)**
3. **Retrieve all usernames (GET)**
4. **Update user information (PUT)**
5. **Delete a user (DELETE)**

The project is divided into two main parts:

- **Backend (API):** Built with ASP.NET Core Web API, Entity Framework Core, and SQL Server.
- **Client-side (Front-End):** A React-based application that consumes the API and provides a user-friendly interface for managing freelancers.

## Technology Stack

### Backend
- ASP.NET Core Web API
- Entity Framework Core (EF Core)
- SQL Server (or any RDBMS of your choice)

### Client-side
- React
- Axios (for HTTP requests)
- HTML & CSS for UI styling

## Features
- **RESTful API:** All the necessary CRUD operations for managing users.
- **Error Handling:** Includes error handling for missing users during update and delete operations.
- **Client-side Integration:** A React app for interacting with the API.
- **CORS Support:** Ensures secure communication between the client-side application and the API.

## Setup Instructions

### Prerequisites
- [.NET 6.0](https://dotnet.microsoft.com/download) or later installed on your machine.
- A SQL Server instance (or another RDBMS) to store user data.
- [Node.js](https://nodejs.org/) (including npm) for the React client.

### Installation

#### Backend (API)
1. **Clone the repository:**
   ```bash
   git clone https://github.com/tiviyaa/FreelanceDirectory.git
   cd WebApplication

2. **Update the connection string in appsettings.json:**

3. **Run the API:**
  ```bash
dotnet run

### Client-side (React)

1. **Start the React development server:**
  ```bash
npm start
The React client will run at http://localhost:3000.

Notes
Make sure CORS is enabled in the API to allow requests from http://localhost:3000.
Adjust the API URL in your React components if needed.
