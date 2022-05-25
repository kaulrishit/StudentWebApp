CREATE DATABASE Student;

CREATE TABLE student_info(student_id int primary key identity(1,1) ,student_name varchar(30) not null, student_gender varchar(6), student_age int CHECK (student_age>=16));
INSERT INTO student_info values('Rishit','Male',21);
INSERT INTO student_info values('John','Male',18);
INSERT INTO student_info values('Amber','Female',20);
INSERT INTO student_info values('Jonathon','Male',19);
INSERT INTO student_info values('Steve','Male',17);
INSERT INTO student_info values('Rose','Female',27);
INSERT INTO student_info values('Jim','Male',19);
