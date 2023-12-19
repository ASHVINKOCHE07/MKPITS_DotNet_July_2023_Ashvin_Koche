CREATE TABLE products3(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) NOT NULL
);
insert into products3 VALUES ('KEYBOARD',123,456,789),('MOUSE',456,456,800),('tv',789,900,1500)
ALTER TABLE products3
ADD CONSTRAINT positive_price CHECK(unit_price > 0);
ALTER TABLE products3
ADD Discounted_price DEC(10,2)CHECK(Discounted_price>0)
ALTER TABLE products3 ADD Discounted_price1 DEC(10,2)
SELECT * FROM products3
EXEC sp_help products3
