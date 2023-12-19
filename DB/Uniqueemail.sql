CREATE TABLE persons(
    person_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE
);
insert into persons values('amit','kumar','a123@gmail.com')
insert into persons values('amit','kumar','a123@gmail.com')
insert into persons values('amit','bhai','a456@gmail.com')
/*ERROR:Msg 2627, Level 14, State 1, Line 8
Violation of UNIQUE KEY constraint 'UQ__persons__AB6E616411516FC8'. Cannot insert duplicate key in object 'dbo.persons'. The duplicate key value is (a123@gmail.com).
The statement has been terminated.*/