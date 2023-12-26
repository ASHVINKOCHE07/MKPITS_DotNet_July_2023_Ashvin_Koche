create table employee (empid int,empname varchar(50))
create table emplog(logid int identity(1,1)not null,empid int not null,operation nvarchar(10) not null,updateddate datetime not null)
create trigger empt
on employee
for insert
as 
insert into 
emplog(empid,operation,updateddate)
select empid,'insert',GETDATE() from inserted;
insert into employee values(11,'amitabh')
select * from employee
select * from emplog
insert into employee values (12,'saurabh')
select * from employee
select * from emplog