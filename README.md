# Info Management System

This program is a Windows Forms application for managing circus show bookings. It allows users to register, log in, book seats for circus shows in different cities on specific dates, view their booked shows, and cancel booked tickets.

## Features

- **Registration**: Users can register with a username and password.
- **Login**: Registered users can log in to the system.
- **Show Booking**: Users can search for available circus shows by specifying the city, date, and number of people. They can then book available seats for the selected show.
- **Seat Selection**: Users can select seats from the available ones for booking.
- **User Summary**: Users can view a summary of their booked shows and cancel tickets if needed.

## Technologies Used

- **C#**: The program is developed using C# language.
- **Windows Forms**: Windows Forms (WinForms) is used for creating the graphical user interface (GUI).
- **SQL Server**: Microsoft SQL Server is used as the database management system to store user data and booking information.

## Setup

1. **Database Setup**: Before running the application, make sure to set up the database. You can use Microsoft SQL Server Management Studio to execute the SQL scripts provided in the `database_setup.sql` file to create the necessary tables and relationships.

2. **Connection String**: Update the connection string in the source code files (`LogInPage.cs`, `ResultsPage.cs`, `SelectSeatsPage.cs`, `UserSummary.cs`) to point to your SQL Server instance.

3. **Running the Application**: Build and run the application using Visual Studio or any other C# IDE.

## How to Use

1. **Registration/Login**: If you are a new user, click on the "Register" button on the welcome page to create a new account. If you already have an account, log in using your username and password.

2. **Finding Shows**: After logging in, you can search for available circus shows by selecting the city, date, and number of people on the "Find Shows" page.

3. **Booking Seats**: Once you find a suitable show, click on it to view available seats. Select the desired seats and click "Book" to confirm the booking.

4. **Viewing User Summary**: You can view your booked shows and cancel tickets if needed on the "User Summary" page.


