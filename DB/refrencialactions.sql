
create table orders(orderid int primary key,orddate date,custid int)

create table orderdetails(orderid int,product_name varchar(20),
quantity int,constraint fk11 foreign key (orderid)
references orders(orderid))

insert into orders values(1,'2022-9-7',101)
select * from orders
insert into orderdetails values(1,'mouse',5)
insert into orderdetails values(1,'keyboard',5)
select * from orderdetails
