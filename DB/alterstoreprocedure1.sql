create table products(prouductid int identity ,productname varchar(50),modelyear varchar(10),list_price decimal(10,2))
insert into products values('Hondacity','2020',2000000),('MarutiRitz','2020',1000000),('WagonR','2021',800000),('Creata','2022',900000);
alter procedure pd1
as
begin
select productname,modelyear from products
end;
exec pd1
alter proc pd2
as 
begin
insert into products values ('Duster','2023',2500000)
end;
exec pd2
select *from products