CREATE TABLE Products(Prouduct_id INT IDENTITY PRIMARY KEY,Product_name VARCHAR(255) not null,unitprice DEC(10,2) CHECK (unitprice>0))
INSERT INTO Products Values ('bread pakoda',40)
INSERT INTO Products Values ('samosa',30)
/*Error msg if Check doesnot satisfied.
Msg 547, Level 16, State 0, Line 3
The INSERT statement conflicted with the CHECK constraint "CK__Products__unitpr__37A5467C". The conflict occurred in database "products", table "dbo.Products", column 'unitprice'.
The statement has been terminated.*/