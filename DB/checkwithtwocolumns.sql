
CREATE TABLE products2(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2) CHECK(unit_price > 0),
    discounted_price DEC(10,2) CHECK(discounted_price > 0),
    CHECK(discounted_price < unit_price)
);
insert into products2 values('mouse',120,20)
insert into products2 values('mouse',0,0)
insert into products2 values('mouse',120,220)
/*(1 row affected)
Msg 547, Level 16, State 0, Line 10
The INSERT statement conflicted with the CHECK constraint "CK__products2__unit___5070F446". The conflict occurred in database "mkpits2", table "dbo.products2", column 'unit_price'.
The statement has been terminated.
Msg 547, Level 16, State 0, Line 11
The INSERT statement conflicted with the CHECK constraint "CK__products2__52593CB8". The conflict occurred in database "mkpits2", table "dbo.products2".
The statement has been terminated.*/
