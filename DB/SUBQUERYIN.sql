create table customers(custid int,custname varchar(50),state varchar(10),city varchar(10))
 insert into customers values (1,'amit','mah','nagpur'),
(2,'amit','mah','nagpur'),
(3,'raj','mp','bhopal'),
(4,'bharti','mp','bhopal'),
(5,'deepti','mp','indore');
select *from customers
create table orders(orderid int,custid int,orderdate date,productname varchar(50),qty int)
insert into orders values(1,1,'2022-2-2','mouse',5)
insert into orders values(1,1,'2022-2-2','keyboard',5)
insert into orders values(2,2,'2022-2-2','desktop',5)
insert into orders values(2,2,'2022-2-2','ram',5)
insert into orders values(3,3,'2022-2-2','laptop',5)
insert into orders values(4,3,'2022-1-2','mouse',5)
insert into orders values(5,4,'2022-2-2','mouse',5)
insert into orders values(6,4,'2022-2-2','ram',5)
insert into orders values(7,5,'2022-2-2','desktop',5)
insert into orders values(7,5,'2022-2-2','ram',5)
select * from orders
select *from customers
select *from orders
select * from customers where  city='nagpur'
select orderid,orderdate,productname,qty ,custid from orders where custid in (select custid from customers where city='nagpur')
select orderid,orderdate,productname,qty ,custid from orders where custid in (select custid from customers where city='bhopal')
select orderid,orderdate,productname,qty ,custid from orders where custid in (select custid from customers where city='delhi')
select orderid,orderdate,productname,qty ,custid from orders where custid in (select custid from customers where city='nagpur') 
order by orderdate DESC