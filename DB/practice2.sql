CREATE TABLE employees (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  salary DECIMAL(10,2),
  country VARCHAR(50)
);
CREATE PROCEDURE GetAverageSalary
AS
BEGIN
  DECLARE @avgSalary DECIMAL(10,2);
  SELECT @avgSalary = AVG(salary) FROM employees;
  SELECT @avgSalary AS 'Average Salary';
END;