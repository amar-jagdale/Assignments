/***** ------ SQL_CRUD OPERATION------ ******/

create table emp
(
	eno int,
	ename varchar(30),
	sal bigint
	primary key(eno)
)

select * from emp
truncate table emp