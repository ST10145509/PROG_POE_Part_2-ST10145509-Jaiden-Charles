PROG_POE_Part_2
Building and Running the Prototype

1. Clone the repository or download the source code.
2. Open the solution file in Visual Studio.
3. Update the connection string in `Web.config` to match your SQL Server configuration.
4. Employee tables have been populated with sample data

Login Details for 5 Employees
1. username:KoosBox       |    Password: PasswordOne
2. username:ProFarmer     |    Password: Farming
3. username:JCharles      |    Password: JCPass123
4. username:AgriMan       |    Password: Culture
5. username:UsernameOne   |    Password: PasswordTwo

System Functionalities and User Roles

User Roles
- Farmer: Can add products to their profile and view as well as delete their own products.
- Employee: Can add new farmer profiles and view/filter products by farmer username.

Functionalities
- Login: Secure login with role-specific access.
- Add Product (Farmer): Farmers can add new products adn delete existing ones.
- View My Products (Farmer): Farmers can view only the products they have added.
- Add Farmer (Employee): Employees can add new farmer profiles.
- View Products (Employee): Employees can view and filter products by farmer, date range, and category type.
- Logout: Users can securely log out of the application.

https://github.com/ST10145509/PROG_POE_Part_2-ST10145509-Jaiden-Charles

There is one farmer added as i tested the login function for the farmer.
Username: JohnnyBoy  |    Password: johno

LATE ADDITION, therefore this may not be in the VCLEARN ReadMe file. (please read!!!!!):
The database i have created can be found in the App_Data folder in the solution explorer. Open and paste your corresponding connection string into your webconfig file.

If that does not work, i have placed the following queries to create the tables and to insert the required sample data into the required tables for the app to work as intended. 

i apologise for any possible inconvenience as my Azure was not working to create an online database.

first right click on the app_data folder and create a database named AgriEnergyDatabase (so that it does not clash) and execute the following queries in the order that i have placed them.
You will then paste your connection string in the webconfig next to DefaultConnection and you will be good to go. head to server explorer, select new query then copy, paste and execute in the order provided below.


CREATE TABLE Roles (
    RoleID INT PRIMARY KEY IDENTITY,
    Role VARCHAR(50)
);


CREATE TABLE Login (
    LoginID INT PRIMARY KEY IDENTITY,
    Username VARCHAR(50),
    Password VARCHAR(max)
);


CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(50),
    Surname VARCHAR(50),
    LoginID INT FOREIGN KEY REFERENCES Login(LoginID),
    RoleID INT FOREIGN KEY REFERENCES Roles(RoleID)
);


CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    ProductionDate DATE,
    FarmerID INT FOREIGN KEY REFERENCES Users(UserID)
);

INSERT INTO Login (Username, Password)
VALUES ('KoosBox', 'PasswordOne'),
       ('ProFarmer', 'Farming'),
       ('JCharles', 'JCPass123'),
       ('AgriMan', 'Culture'),
       ('UsernameOne', 'PasswordTwo');

INSERT INTO Roles (Role)
VALUES ('Employee'),
       ('Farmer');

INSERT INTO Users (Name, Surname, LoginID, RoleID)
VALUES ('Jacob', 'Murphy', 1, 1),
       ('John', 'Smith', 2, 1),
       ('Jaiden', 'Charles', 3, 1),
       ('Jack', 'Beanstalk', 4, 1),
       ('User', 'Name', 5, 1);
       
------------------------------------------------------------------------------------------------------END OF README-------------------------------------------------------------------------------------------------
