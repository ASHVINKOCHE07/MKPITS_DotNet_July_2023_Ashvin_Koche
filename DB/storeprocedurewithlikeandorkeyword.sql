create table products(prouductid int identity ,productname varchar(50),modelyear varchar(10),list_price decimal(10,2))
insert into products values('Hondacity','2020',2000000),('MarutiRitz','2020',1000000),('WagonR','2021',800000),('Creata','2022',900000);
select *from products
create proc prod9(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from products
where
list_price>= @minp AND
        (@maxp IS NULL OR list_price <= @maxp) AND
        productname LIKE '%' + @pn + '%'

end;
exec prod9 50000,30000000,'ter'