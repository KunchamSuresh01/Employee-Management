Employee-Management
Mini Employee Management System

System Requirements Hardware Requirements: 1.A modern computer with at least 4GB of RAM 2.A processor with a minimum speed of 2.0 GHz 3.Adequate storage space (at least 500MB for the project files)

Software Requirements: 1.Windows Operating System 2.Visual Studio (latest version recommended) 3.SQL Server for database management

Downloading the Source Code Where to Find the Source Code: You can find the source code for the Employee Management System project on GitHub

Steps to Download: 1.Download the ZIP file. 2.Setting Up the Project

Installing Necessary Software Before setting up the project, ensure you have the following software installed: 1.Visual Studio: Download and install the latest version from the official website. 2.SQL Server: Install SQL Server for database management.

Importing the Project into Visual Studio: 1.Open Visual Studio. 2.Select "Open a project or solution." 3.Navigate to the downloaded source code folder and select the solution file (.sln).

Database Configuration Setting Up the Database: 1.Open SQL Server Management Studio. 2.Create a new database for the project, "EmployeeManagement" is the DataBase name. 3.Excute this query -- Create Department table CREATE TABLE Departments ( DepartmentId INT IDENTITY(1,1) PRIMARY KEY, Name NVARCHAR(100) NOT NULL );

-- Create Employee table CREATE TABLE Employees ( EmployeeId INT IDENTITY(1,1) PRIMARY KEY, FirstName NVARCHAR(50) NOT NULL, LastName NVARCHAR(50) NULL, DateOfBirth DATE NULL, Gender NVARCHAR(10) NULL, Email NVARCHAR(100) NOT NULL, PhoneNumber NVARCHAR(15) NOT NULL, Address NVARCHAR(255) NULL, IsActive BIT NULL, DepartmentId INT NOT NULL, CONSTRAINT FK_Employee_Department FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId) ); for table creation.

Connecting the Database to the Project 1.Open the appsettings.json file in the project. 2.Update the connection string with your database details (server name, database name, username, and password). 3.Save the changes.

About
Mini Employee Management System
