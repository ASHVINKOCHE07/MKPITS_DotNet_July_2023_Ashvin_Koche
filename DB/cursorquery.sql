create table products(product_name varchar(max),list_price decimal)
insert into products values ('mouse',1200),('keyboard',1500),('charger',550);
DECLARE
@product_name varchar(max),
@list_price decimal;
DECLARE cursor_product1 CURSOR
FOR SELECT 
product_name,
list_price
from products
OPEN cursor_product
FETCH NEXT FROM cursor_product1 INTO
@producct_name,@list_price;
WHILE @@FETCH_STATUS = 0
BEGIN
PRINT(@product_name+cast(@list_price as varchar);
FETCH NEXT FROM cursor_product1 INTO
@product_name,
@list_price
END;
CLOSE cursor_product;
DEALLOCATE cursor_product;