🐾 Pet Adoption System (vb.net)

A comprehensive desktop application built with VB.NET and Windows Forms to streamline the pet adoption process, connecting adopters with pets in need of homes.

🎯 Overview

The Pet Adoption System is a Windows Forms application designed to manage the complete pet adoption workflow. It provides role-based access for administrators, staff, and potential adopters, facilitating efficient pet management and adoption request processing.

✨ Features

For Adopters

🔍 Browse Available Pets - Search and filter pets by species, gender, age, and availability
📝 Submit Adoption Requests - Complete detailed qualification forms
📊 Track Applications - Monitor adoption request status (Pending/Approved/Rejected)
👤 Profile Management - Update personal information, email, and profile picture
🔐 Secure Authentication - Email verification with one-time codes

For Administrators & Staff

🐕 Pet Management - Add, edit, and delete pet records with photos
✅ Review Applications - View detailed adopter information and qualifications
📋 Approve/Reject Requests - Process adoption applications with workflow automation
👥 Account Management - Create and manage user accounts (Admin only)
📈 Pagination Support - Handle large datasets efficiently

Security Features

🔒 SHA-256 password hashing
✉️ Email verification system (SMTP)
🛡️ Role-based access control (Admin, Staff, Adopter)
🔑 Password change with email verification

🛠️ Technologies Used

Framework: .NET 8.0 (Windows Forms)
Language: Visual Basic .NET
Database: MySQL 9.3.0
Libraries:

MySql.Data - MySQL database connector
System.Net.Mail - Email functionality
System.Security.Cryptography - Password hashing
Microsoft.Web.WebView2 - Web content rendering

🗄️ Database Schema

Main Tables

users - User accounts with authentication and profile data
pets - Pet information including images stored as BLOB
adoption_requests - Adoption application records
adoption_qualifications - Detailed adopter information and questionnaire responses

Key Fields
sqlusers: id, username, email, password_hash, role, is_verified, verification_code, profile_picture
pets: id, name, species, breed, age, gender, description, status, image
adoption_requests: id, user_id, pet_id, status, request_date
adoption_qualifications: request_id, first_name, last_name, address, phone_number, home_type, has_other_pets, income, reason

🚀 Installation

Prerequisites

Windows OS (Windows 10 or later recommended)
.NET 8.0 SDK
MySQL Server (latest version)
Visual Studio 2022 (or later)

Steps

1. Clone the repository or just simply download it.

2. Find the sql database and set up MySQL Database
   CREATE DATABASE pet_adoption_system;
   Then import the sql database.
   
4. CLick and open the sln file.

5. Configure Email Settings (Change it to your email)
Update EmailHelper.vb with your SMTP credentials:

smtp.Credentials = New NetworkCredential("your-email@gmail.com", "your-app-password")

Build and Run

📖 Usage
First Time Setup

Run the application
Register a new account (default role: Adopter)
Verify email using the code sent to your inbox
Login with credentials

Creating Admin Account

Manually set the first admin account in the database:
sqlUPDATE users SET role = 'admin' WHERE id = 15;

👥 User Roles
<img width="616" height="209" alt="image" src="https://github.com/user-attachments/assets/8b639a26-837d-49a6-8962-c0593333ae73" />

🚧 Future Improvements
High Priority

 Modern UI/UX Redesign
Card-based pet display with images
Material Design or Fluent UI styling
Responsive layouts with better spacing
Icon integration (Material Icons/Font Awesome)
Smooth animations and transitions


 Enhanced Pet Display
Image gallery support (multiple photos per pet)
Pet category/tags system
Featured/urgent adoption badges
Advanced filtering (age range, size, temperament)


 Improved Forms
Better form validation with visual feedback
Auto-save draft applications
File upload for documents (vet records, references)
Multi-step wizard for adoption forms



Medium Priority

 Notification System
Email notifications for status changes
In-app notification center
SMS integration for urgent updates


 Reporting & Analytics
Adoption statistics dashboard
Success rate metrics
Monthly/yearly reports
Export to PDF/Excel


 Search Enhancements
Full-text search
Save search preferences
Recommended pets based on preferences
Favorite/watchlist feature


 Communication Module
In-app messaging between adopters and staff
Schedule visit appointments
Video call integration for remote interviews

--END--
