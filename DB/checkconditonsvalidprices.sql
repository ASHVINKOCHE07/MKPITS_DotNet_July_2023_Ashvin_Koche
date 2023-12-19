CREATE TABLE testproducts(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0),
    CONSTRAINT valid_prices CHECK(discounted_price > unit_price)
);
insert into testproducts values('mouse',1200,1500)
insert into testproducts values('Keybord',1500,1500)/*error*/
/*Msg 547, Level 16, State 0, Line 11
The INSERT statement conflicted with the CHECK constraint "valid_prices". The conflict occurred in database "mkpits2", table "dbo.testproducts".
The statement has been terminated.*/
