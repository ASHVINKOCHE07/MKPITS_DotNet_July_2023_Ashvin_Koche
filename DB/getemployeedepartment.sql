CREATE TABLE employees (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  department_id INT,
  salary DECIMAL(10,2),
  FOREIGN KEY (department_id) REFERENCES departments(id)
);

INSERT INTO employees (id, name, department_id, salary)
VALUES 
  (1, 'Rajkumar', 1, 50000),
  (2, 'Naveen', 2, 60000),
  (3, 'Ramesh', 3, 70000),
  (4, 'Kavin', 1, 45000),
  (5, 'Pradeep', 2, 55000),
  (6, 'Manikandan', 3, 65000);
  CREATE PROCEDURE GetEmployeeByDepartment(IN department_id INT)
BEGIN
  SELECT * FROM employees WHERE department_id = department_id;
END;
CALL GetEmployeeByDepartment(1);