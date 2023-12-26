CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    DateOfBirth DATE,
    Address VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Email VARCHAR(100)
);

INSERT INTO Employee (EmployeeID, FirstName, LastName, Gender, DateOfBirth, Address, PhoneNumber, Email)
VALUES (1, 'Shantilal', 'Singh', 'Male', '1990-01-01', 'New Delhi', '9876543210', 'hantilal@example.com'),
       (2, 'Rajkumar', 'Singh', 'Male', '1995-02-02', 'Mumbai', '9876543210', 'rajkumar@example.com'),
       (3, 'Suresh', 'Singh', 'Male', '1998-03-03', 'Bangalore', '9876543210', 'uresh@example.com'),
       (4, 'Ramesh', 'Singh', 'Male', '2001-04-04', 'Hyderabad', '9876543210', 'ramesh@example.com'),
       (5, 'Rakesh', 'Singh', 'Male', '2004-05-05', 'Chennai', '9876543210', 'rakesh@example.com');
       CREATE PROCEDURE GetEmployeeCount
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employee;
END;
Exec TotalEmployees