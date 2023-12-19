CREATE TABLE products3(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) NOT NULL
);
ALTER TABLE products3
ADD CONSTRAINT positive_price CHECK(unit_price > 0);
ALTER TABLE products3
ADD Discounted_price DEC(10,2)CHECK(Discounted_price>0)
ALTER TABLE products3 ADD Discounted_price1 DEC(10,2)
SELECT * FROM products3