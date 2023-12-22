create table products(prouductid int identity ,productname varchar(50),modelyear varchar(10),list_price decimal(10,2))
insert into products values('Hondacity','2020',2000000),('MarutiRitz','2020',1000000),('WagonR','2021',800000),('Creata','2022',900000);
select *from products
create proc pd6(@lp as decimal,@pd as int)
as
begin
select *from products where list_price>@lp and modelyear>@pd  
end;
exec pd6 500000,2000