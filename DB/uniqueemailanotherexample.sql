CREATE TABLE persons(
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255),
    UNIQUE(email)
);
INSERT INTO persons(first_name, last_name, email)
VALUES('John','Doe','j.doe@bike.stores');
INSERT INTO persons(first_name, last_name, email)
VALUES('MAX','RIDEX','TY.doe@bike.stores');
