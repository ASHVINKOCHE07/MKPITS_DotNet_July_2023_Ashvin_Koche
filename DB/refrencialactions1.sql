CREATE TABLE vendor_groups (
    group_id INT IDENTITY PRIMARY KEY,
    group_name VARCHAR (100) NOT NULL
);
CREATE TABLE vendors1 (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        CONSTRAINT fk_group FOREIGN KEY (group_id) 
        REFERENCES vendor_groups(group_id)
);
insert into vendors1(vendor_name,group_id) values('amit',123)
insert into vendor_groups values('mkpits')
select * from vendor_groups
insert into vendors1(vendor_name,group_id) values('amit',1)
select * from vendors1
insert into vendors1(vendor_name,group_id) values('arjun',2)
insert into vendor_groups values('niit')
select * from vendor_groups
insert into vendors1(vendor_name,group_id) values('arjun',2)
select * from vendors1
insert into vendors1(vendor_name,group_id) values('arpita',2)
select * from vendors1
select * from vendor_groups
delete from vendor_groups where group_id=2
insert into vendor_groups values('aptech')
select * from vendor_groups
select * from vendors1
delete from vendor_groups where group_id=3

