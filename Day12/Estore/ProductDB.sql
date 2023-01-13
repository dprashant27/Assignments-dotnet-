use dotnet;

create Table Product(
    Id int primary key auto_increment,
    Name varchar(25),
    Quantity int not null,
    Price decimal(9,0),
    Image varchar(100)
);

insert into Product values
(1,'Laptop',10,100000,'laptop.jpg'),
(2,'Mobile',20,20000,'mobile.jpg'),
(3,'Tablet',30,30000,'tablet.jpg'),
(4,'Camera',40,40000,'camera.jpg'),
(5,'Headphone',50,50000,'headphone.jpg'),
(6,'Speaker',60,60000,'speaker.jpg'),
(7,'Watch',70,70000,'watch.jpg'),
(8,'Keyboard',80,80000,'keyboard.jpg'),
(9,'Mouse',90,90000,'mouse.jpg'),
(10,'Printer',100,100000,'printer.jpg'),
(11,'Monitor',110,110000,'monitor.jpg'),
(12,'Router',120,120000,'router.jpg'),
(13,'Scanner',130,130000,'scanner.jpg'),
(14,'Hard Disk',140,140000,'harddisk.jpg'),
(15,'Memory Card',150,150000,'memorycard.jpg'),
(16,'Pen Drive',160,160000,'pendrive.jpg'),
(17,'Power Bank',170,170000,'powerbank.jpg'),
(18,'Charger',180,180000,'charger.jpg'),
(19,'Cable',190,190000,'cable.jpg'),
(20,'Adapter',200,200000,'adapter.jpg');
