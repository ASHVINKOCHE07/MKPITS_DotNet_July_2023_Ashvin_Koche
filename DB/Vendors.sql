CREATE TABLE Vendors_Group(groupid int IDENTITY PRIMARY KEY,group_name varchar(100) not null )
CREATE TABLE Vendors(vendorid int IDENTITY PRIMARY KEY,vendor_name varchar(50) not null,
groupid int not null)
select *from Vendors
select *from Vendors_Group
insert into Vendors values ('Ashvin',1) 
select *from Vendors
DROP TABLE Vendors;
CREATE TABLE Vendors(vendorid int IDENTITY PRIMARY KEY,vendor_name varchar(50) not null,
groupid int not null,CONSTRAINT fk1 FOREIGN KEY (groupid) REFERENCES Vendors_Group(groupid))
select * from Vendors_Group
insert into Vendors values('amit',1)
insert into Vendors_Group values ('HCL')
select * from Vendors_Group
insert into Vendors_Group values ('HL')
select * from Vendors
insert into Vendors_Group values('mkpits')
select * from Vendors_Group
insert into Vendors values('amit',1)
select * from Vendors
insert into Vendors values('arjun',2)
insert into Vendors_Group values('niit')
select * from Vendors_Group
insert into vendors(vendor_name,groupid) values('arjun',2)
select * from vendors
insert into vendors(vendor_name,groupid) values('arpita',2)
select * from vendors