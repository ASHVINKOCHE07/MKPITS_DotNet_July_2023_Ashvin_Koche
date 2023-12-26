CREATE TABLE employees (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  designation VARCHAR(50),
  salary DECIMAL(10,2)
);

INSERT INTO employees (id, name, designation, salary)
VALUES 
  (1, 'Rajkumar', 'Software Engineer', 50000.00),
  (2, 'Naveen', 'Data Analyst', 60000.00),
  (3, 'Manikandan', 'Project Manager', 70000.00),
  (4, 'Kavin', 'Marketing Manager', 80000.00),
  (5, 'Pradeep', 'Sales Executive', 90000.00);
  CREATE PROCEDURE GetHighSalaryEmployees
@threshold DECIMAL(10,2)
AS
BEGIN
  SELECT *
  FROM employees
  WHERE salary > @threshold;
END
EXEC GetHighSalaryEmployees 65