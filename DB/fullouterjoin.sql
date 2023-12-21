create table Student(id int primary key identity,fname varchar(50) not null,lname varchar(50)not null,
fees int not null,city varchar(10)not null,age int not null )
alter table Student add admission_no int
select *from Student
create table admission(admission_no varchar(45) NOT NULL,  
      course varchar(45) NOT NULL,      
      amount_paid int)
insert into Student values       
 ('Luisa', 'Evans', 13000, 'Texas',25,3354),       
    ('Paul', 'Ward', 15000, 'Alaska',26,2135),       
    ('Peter', 'Bennett', 14000, 'California',27,4321),    
    ('Carlos', 'Patterson', 17000, 'New York',28,4213),       
    ('Rose', 'Huges', 16000, 'Florida',29,5112),  
    ('Marielia', 'Simmons', 15000, 'Arizona',30,6113),    
    ('Antonio', 'Butler', 14000, 'New York',31,7555),       
    ('Diego', 'Cox', 13000, 'California',32,8345);  
	insert into admission values (3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000);  
	select Student.admission_no,Student.fname,Student.lname,admission.course,admission.amount_paid from Student FULL OUTER JOIN admission on Student. admission_no = admission.admission_no