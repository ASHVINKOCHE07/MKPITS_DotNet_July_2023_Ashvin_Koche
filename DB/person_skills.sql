CREATE TABLE person_skills (
    id INT IDENTITY PRIMARY KEY,
    person_id int,
    skill_id int,
    updated_at DATETIME,
    UNIQUE (person_id, skill_id)
);
insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(112,10,'2021-12-12')
insert into person_skills values(111,11,'2021-12-12')
/*(1 row affected)
Msg 2627, Level 14, State 1, Line 9
Violation of UNIQUE KEY constraint 'UQ__person_s__DB83E0E96C25D91A'. Cannot insert duplicate key in object 'dbo.person_skills'. The duplicate key value is (111, 10).
The statement has been terminated.

(1 row affected)

(1 row affected)*/
