CREATE TABLE employees (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  department VARCHAR(50),
  salary FLOAT
);

INSERT INTO employees (id, name, department, salary)
VALUES (1, 'Rajkumar', 'Sales', 50000),
       (2, 'Naveen', 'Marketing', 60000),
       (3, 'Ramesh', 'IT', 70000),
       (4, 'Kavin', 'HR', 40000),
       (5, 'Suresh', 'Finance', 55000);
       CREATE PROCEDURE TransferEmployee
    @emp_id INT,
    @new_dept VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    UPDATE employees
    SET department = @new_dept
    WHERE id = @emp_id;

    INSERT INTO employees (id, name, department, salary)
    SELECT @emp_id, name, @new_dept, salary
    WHERE NOT EXISTS (SELECT * FROM employees WHERE id = @emp_id);

    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;
        SELECT 'Employee transfer successful';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        SELECT 'Employee transfer failed';
    END
END