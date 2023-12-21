create table products(product_id int,product_name varchar(50))
insert into products values (1,'Mouse')
insert into products values (2,'Keyboard')
insert into products values (3,'tv')
insert into products values (4,'Fridge')
insert into products values (5,'oven')
select * from products
delete from products where product_name='Mouse'
select *from products
create table sample12345(id int identity primary key,
name varchar(20))

insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345

delete from sample12345
select * from sample12345

insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345
