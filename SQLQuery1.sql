
use bit3sem

create table student(
id int not null primary key identity(1,1),
name nvarchar(255) not null,
address nvarchar(30) not null,
contact nvarchar(30) not null
)

alter table student add college nvarchar(50)

insert into student(name,address,contact,college) values ('sudarshan','bhaktapur','9813919623','kist college')

update student set name ='sudarshan_kapali' where id =1
select * from student where name like 's%'

insert into student(name,address,contact,college) values ('suprim','tokha','981300000','kist college')
insert into student(name,address,contact,college) values ('justin','kritipur','981300000','kist college')
insert into student(name,address,contact,college) values ('aman','teku','981300000','kist college')

select name , address from student where id >=2

select name , address from student where name like 's%'

select * from student order by name asc

update student set address ='kirtipur' where id = 3

select * from student

update student set address ='australlia' where id = 2

select * from student
insert into student (name,address,contact,college) values ('chor','chorBazar','90000000','noCollege')

select * from student

delete from student where id = 5

create table new_db
(
id int not null primary key,
name nvarchar(50) not null
)
use new_db
insert into new_db(id,name) values (1,'hahaha')