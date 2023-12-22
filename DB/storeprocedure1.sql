create table products(prouductid int identity ,productname varchar(50),modelyear varchar(10),list_price decimal(10,2))
insert into products values('Hondacity','2020',2000000),('MarutiRitz','2020',1000000),('WagonR','2021',800000),('Creata','2022',900000);
select *from products
create proc pd3
as
begin
select productname, list_price from products
order by productname DESC
end;
exec pd3