
drop database if exists midterm
go
create database midterm
go

use  midterm
go

drop table if exists member;
go


create table member
(  
     ID int identity(1,1) primary key,
     姓名 nvarchar(50) not null,
     電話  nvarchar(10) not null unique,
	 生日 date,
	 地址 nvarchar(100),
	 Email nvarchar(100),
	 密碼 nvarchar(100) not null
);
select * from member
go


insert into member values 
('王一蛋', '0911111111', '1997-1-1','高雄市三民區','a111@gmail.com','111'),('王二蛋', '0922222222', '1997-2-2','高雄市左營區','a222@gmail.com','222'),
('王三蛋', '0933333333', '1997-3-3','高雄市鳥松區','a333@gmail.com','333'),('王四蛋', '0944444444', '1997-4-4','高雄市新興區','a444@gmail.com','444'),
('王五蛋', '0955555555', '1997-5-5','高雄市苓雅區','a555@gmail.com','555'),('王六蛋', '0966666666', '1997-6-6','高雄市鹽埕區','a666@gmail.com','666'),
('王七蛋', '0977777777', '1997-7-7','高雄市鳳山區','a777@gmail.com','777'),('王八蛋', '0988888888', '1997-8-8','高雄市楠梓區','a888@gmail.com','888')
select * from member;
go




drop table if exists employee;
go

create table employee
(  
     員編 int identity(1,1) primary key,  
     姓名 nvarchar(50) not null,
     電話  nvarchar(10) not null,
	 生日 date,
	 地址 nvarchar(100),
	 Email nvarchar(100),
	 到職日 date,
	 密碼 nvarchar(100) not null
);
select * from employee
go


insert into employee values 
('李大毛', '0912121212', '1997-9-9','高雄市三民區','a111@gmail.com','2020-2-20','bigmao'),('李小毛', '0923232323', '1997-10-10','高雄市左營區','a222@gmail.com','2020-2-20','smallmao'),
('林星星', '0999999999', '1997-11-11','高雄市鳥松區','a333@gmail.com','2021-5-30','star'),('吳月亮', '0900000000', '1997-12-12','高雄市新興區','a444@gmail.com','2022-1-30','moon')
select * from employee;
go




drop table if exists item;
go

create table item
(  
     產品類別 nvarchar(50),
	 產品編號 int identity(1,1) primary key,  
     產品名 nvarchar(50),  
     產品價格 int	 
	
);
select * from item
go


insert into item values 
('肉品', '半隻','90'),('肉品', '雞胸','40'),('肉品',  '雞腿','40'),('肉品','雞翅(3隻)','20'),('肉品',  '雞皮','20'),
('肉品', '雞脖子(2隻)','10'),('肉品','肝連肉','35'),
('蔬菜','金針菇','15'),('蔬菜','花生','15'),('蔬菜','木耳','15'),('蔬菜','海帶芽','15'),('蔬菜','脆筍','15'),
('蔬菜','高麗菜','20'),('蔬菜','花椰菜','20'),('蔬菜','四季豆','20'),('蔬菜','玉米筍','20'),('蔬菜','杏鮑菇','20'),
('蔬菜','香菇','20'),('蔬菜','筊白筍','20'),('蔬菜','小黃瓜','20'),('蔬菜','水蓮','20'),('蔬菜','馬鈴薯','20'),
('蔬菜','苦瓜','20'),('蔬菜','秋葵','20'),('蔬菜','海帶','20'),('蔬菜','紅蘿蔔','20'),('蔬菜','白蘿蔔','20'),
('其它','王子麵','20'),('其它','科學麵','20'),('其它','油麵','20'),('其它','黑輪片(2片)','15'),('其它','豆干(2片)','15'),
('其它','百頁豆腐','20'),('其它','豆皮','20'),('其它','豆包','20'),('其它','米血','20'),('其它','脆腸','30'),
('其它','雞皮','20'),('其它','德國香腸','20'),('其它','魷魚','30'),('其它','豬耳朵','30'),('其它','黃金蛋','20'),
('其它','蒟蒻','20'),('其它','鑫鑫腸','20'),('其它','鳥蛋','30'),('其它','蟹味棒','30'),('其它','皮蛋','20')


select * from item;
go