--truncate will delete the record and when you
--insert new records it will start from one
create table sample12345(id int identity primary key,name varchar(20))
truncate table sample12345
insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345
