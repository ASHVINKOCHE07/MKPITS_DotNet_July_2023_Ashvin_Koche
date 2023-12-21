create table sample2(id int unique,name varchar(20))
insert into sample2(name) values('ravi')
select * from sample2


create table employee(empid int primary key,empname varchar(20),
passportno int,drivinglicenceno int,
constraint e1 unique(passportno,drivinglicenceno))

insert into employee values(1,'jayesh',12345,98989)
insert into employee values(3,'jayesh',22345,9899)

select * from employee

create table emp(empid int primary key,empname varchar(20),
pno int unique,dlno int unique)
insert into emp values(1,'anand',111,222)
insert into emp values(2,'anand',112,223)
select * from emp


insert into emp values(1,'anand',111,222)
insert into emp values(2,'anand',112,223)
