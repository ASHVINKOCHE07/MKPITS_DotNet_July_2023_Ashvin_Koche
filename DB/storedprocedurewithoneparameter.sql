create table products(prouductid int identity ,productname varchar(50),modelyear varchar(10),list_price decimal(10,2))
insert into products values('Hondacity','2020',2000000),('MarutiRitz','2020',1000000),('WagonR','2021',800000),('Creata','2022',900000);
select *from products
create proc pprice(@minprice as decimal)
as 
begin
select * from products where list_price>@minprice
order by list_price
end;
exec pprice 1500000
create proc pname(@pn varchar(max))
as
begin
select *from products where  productname=@pn
end;
exec pname 'WagonR'