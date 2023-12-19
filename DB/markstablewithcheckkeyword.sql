create table result5(rno int primary key,
marks int check(marks > 0))
insert into result5 values(1,0)
insert into result5 values(1,99)
/*Error: Due to error in check marks are inserted zero.
Msg 2627, Level 14, State 1, Line 3
Violation of PRIMARY KEY constraint 'PK__result5__C2B7F59B7515C76C'. Cannot insert duplicate key in object 'dbo.result5'. The duplicate key value is (1).
The statement has been terminated.

Completion time: 2023-12-19T12:21:13.4518808+05:30*/
