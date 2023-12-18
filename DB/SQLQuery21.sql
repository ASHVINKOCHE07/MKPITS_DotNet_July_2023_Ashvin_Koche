CREATE TABLE salesman (
salesman_id INT,
name VARCHAR(50),
city VARCHAR(50),
commission DECIMAL(5,2),
PRIMARY KEY (salesman_id)
);

INSERT INTO salesman (salesman_id, name, city, commission)
VALUES
(5001, 'James Hoog', 'New York', 0.15),
(5002, 'Nail Knite', 'Paris', 0.13),
(5005, 'Pit Alex', 'London', 0.11),
(5006, 'Mc Lyon', 'Paris', 0.14),
(5007, 'Paul Adam', 'Rome', 0.13);
SELECT name, city FROM salesman WHERE city = 'Paris';
