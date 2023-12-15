        CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT ,
        constraint fk3  foreign key(group_id)
        references vendor_groups(group_id)
        on delete set null
        
        )
        insert into vendor_groups values('tcs')
        insert into vendors values('amitabh',3)
        delete from vendor_groups where group_id=3
        select * from vendor_groups
        select * from vendors
