create table employee (empid int,empname varchar(50))
create table emplog(logid int identity(1,1)not null,empid int not null,operation nvarchar(10) not null,updateddate datetime not null)
create trigger afttrig
on employee
after update
as
insert into emplog(empid,operation,updateddate)
select empid,'update',getdate() from deleted;
select * from employee
update employee set empname='sharukh' where empid=11
select *from employee
select *from emplog