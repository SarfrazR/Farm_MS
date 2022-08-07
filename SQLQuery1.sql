----Create DataBAse FMS;
--create table Employe(
--ID varchar(55) primary key,
--Name varchar(55) not null,
--JobT varchar(55)not null,
--cnic varchar(55) not null,
--contact varchar(55) not null,
--Address varchar(255) not null,
--email varchar(55) null
--);

--Insert into Employe values ('19245','Saad','Supervisor','33102-3333333-3','0302 0000000','ABC rd.','Badboy@email.com');
--Insert into Employe values ('19212','Ahmad','Senior Supervisor','33102-33221333-3','0302 00122100','Satyana rd.','Goodboy@email.com');

--Select * from Employe;

--select * from Employe where ID = '19212';

--Create Table Animal(
--AnimalID varchar(55) primary key,
--AnimalType varchar(55) not null,
--Feed varchar(255) null,
--Production int null
--);
--Insert into Animal values('1001','Cow','Green Bushes', 15);
--Insert into Animal values('1002','Cow','Green Bushes', 12);
--Insert into Animal values('1003','Buffalo','Green Bushes', 21);
--Insert into Animal values('2001','Chicken','Special Feed', 4);

--Select * from Animal;
--Create Table Treatment(
--treatmentID varchar(55) primary key,
--treatmentDate varchar(55) not null,
--MedName varchar(55) not null,
--MedType varchar(55) not null,
--MedExpiry varchar(55) not null,
--EmpID varchar(55) not null,
--treatmentCost int not null,
--AnimalID varchar(55) not null,
--);


--Insert into Treatment values ('T-1111','12/03/2021','Paracetamol','Pain killer','19/12/2022','19212',5000,'1001');
--Insert into Treatment values ('T-1003','01/09/2021','BiCarboxylene','Anti Parasyte','11/12/2021','19212',12000,'1002');
--Insert into Treatment values ('T-1671','01/05/2021','AminoCyclene','Vitamin','01/01/2022','19212',2000,'2001');
--select * from Treatment;

--Create Table Product(
--OredrID varchar(55) primary key,
--ProductType varchar(55) not null,
--ProductCost int not null,
--ProductAmount int not null,
--TotalPrice int not null,
--Collector varchar(55) not null,
--TransportCharges int not null
--);

--insert into Product values ('Milk-101','Cow Milk',70,12,840,'M.Yaqoob',121);
--insert into Product values ('Milk-201','Buffalo Milk',110,8,880,'M.Abdullah',110);
--insert into Product values ('Milk-102','Cow Milk',80,13,1040,'M.Yaqoob',111);
--insert into Product values ('Eggs-301','Desi Eggs',10,120,1020,'M.Younas',70);
--insert into Product values ('Milk-202','Buffalo Milk',120,20,2400,'M.Yasir',90);

--select * from Product;

--Create Table Accounts(
--AccountNo varchar(55)primary key,
--OrderID varchar(55) not null,
--Total int not null,
--TreatmentID varchar(55) not null,
--TreatmentCost int not null,
--Gain	int not null,
--);

--Insert into Accounts values ('001','Milk-101',8400,'T-1111',5000,3400);
--Insert into Accounts values ('003','Milk-102',21400,'T-1003',12000,9400);
--Insert into Accounts values ('002','Milk-201',22400,'T-1671',3000,19400);
--select * from Accounts;

--Update Employe set Name='Umer',JobT='Manager',cnic='33205-1111111-1',contact='03002138163',Address='Gulfishan Colony',email='Badboy@Hotmail.com' where ID = '19212' ;
--select * from Treatment;
--Delete from Employe where ID='19245';
