create schema `form`;
create table form.Person
(
	id int not null auto_increment,
    p_name varchar(255),
    pass varchar(255),
    primary key(id)
);
create table form.admin
(
	id int not null auto_increment,
    p_name varchar(255),
    pass varchar(255),
    primary key(id)
);
create table form1
(
	id int not null auto_increment,
    p_name varchar(255),
    email varchar(255),
    contact varchar(255),
    school varchar(255),
    batch varchar(255),
    hostelite varchar(255),
    hostel varchar(255),
    primary key(id)
);