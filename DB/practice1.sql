CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    IndianName VARCHAR(50),
    Email VARCHAR(50),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    JobTitle VARCHAR(50),
    Salary DECIMAL(10,2),
    BirthDate DATE,
    Address VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(50),
    Country VARCHAR(50),
    ZipCode VARCHAR(10)
);
CREATE PROCEDURE InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @IndianName VARCHAR(50),
    @Email VARCHAR(50),
    @PhoneNumber VARCHAR(20),
    @HireDate DATE,
    @JobTitle VARCHAR(50),
    @Salary DECIMAL(10,2),
    @BirthDate DATE,
    @Address VARCHAR(100),
    @City VARCHAR(50),
    @State VARCHAR(50),
    @Country VARCHAR(50),
    @ZipCode VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Employee (FirstName, LastName, IndianName, Email, PhoneNumber, HireDate, JobTitle, Salary, BirthDate, Address, City, State, Country, ZipCode)
        VALUES (@FirstName, @LastName, @IndianName, @Email, @PhoneNumber, @HireDate, @JobTitle, @Salary, @BirthDate, @Address, @City, @State, @Country, @ZipCode);
        SELECT 'Employee inserted successfully.';
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END;