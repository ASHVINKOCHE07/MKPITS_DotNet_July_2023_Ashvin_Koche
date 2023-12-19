CREATE TABLE hrpersons (
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255),
    CONSTRAINT unique_email UNIQUE(email)
);
ALTER TABLE hrpersons
ADD CONSTRAINT unique_email1 UNIQUE(email);
ALTER TABLE hrpersons
DROP CONSTRAINT unique_email1;