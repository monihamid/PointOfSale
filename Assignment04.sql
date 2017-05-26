CREATE DATABASE IF NOT EXISTS MSWALLY;
USE MSWALLY;


GRANT ALL PRIVILEGES ON MSWALLY.* TO 'superuser'@'%'IDENTIFIED BY 'Conestoga1';

drop database MSWALLY;

/* Creat Customer table*/
DROP TABLE IF EXISTS  Customer ;
CREATE TABLE  Customer (
  CustomerID BIGINT PRIMARY KEY AUTO_INCREMENT ,
  FirstName VARCHAR(45),
  LastName VARCHAR(45),
  Phone MEDIUMTEXT
  
) ;
 /* Insert sample data to the database  */
 
INSERT INTO Customer(FirstName,LastName, Phone) VALUES
	('Norbert', 'Mika', '416-555-1111'),
	('Russell', 'Foubert', '519-555-2222'),
    ('Sean', 'Clerck','519-555-3333');
    
 
/* Create Branch table*/
DROP TABLE IF EXISTS  Branch ;
CREATE TABLE  Branch (
  BranchID BIGINT PRIMARY KEY AUTO_INCREMENT ,
  BranchName VARCHAR(45) 
  
) ;


 /* Insert sample data to the database  */
INSERT INTO Branch (BranchName) VALUES
	('Sports World'), 
    ('Cambridge Mall'), 
    ('St. Jacobs'); 
    
/* Creat Product table*/
DROP TABLE IF EXISTS  Product ;
CREATE TABLE  Product (
  ProductID BIGINT PRIMARY KEY AUTO_INCREMENT ,
  ProductName MEDIUMTEXT,
  Quantity INT,
  UnitPrice DOUBLE 
   
) ;

 /* Insert sample data to the database  */
INSERT INTO Product(ProductName, Quantity,UnitPrice) VALUES
	('Disco Queen WallPaper (roll)', 56,12.95),
	('Countryside WallPaper (roll)', 24,11.95),
	('Victorian Lace WallPaper (roll)', 44, 14.95),
	('Drywall Tape (roll)', 120,3.95),
    ('Darywall tape (pkg)', 30, 36.95),
    ('Drywall Repair Compound (tube)',90,6.95);
  
    
    
/* Creat Order table*/

DROP TABLE IF EXISTS Orders;
CREATE TABLE Orders (
  OrderID BIGINT PRIMARY KEY AUTO_INCREMENT,
  CustomerID BIGINT, 
  CONSTRAINT FOREIGN KEY (CustomerID)
  REFERENCES Customer (CustomerID),
  BranchID BIGINT,
  CONSTRAINT FOREIGN KEY (BranchID)
  REFERENCES  Branch(BranchID),
  OrderStatus TEXT,
  OrderDate DATE
) ;


DROP TABLE IF EXISTS OrderLine;
CREATE TABLE OrderLine (
OrderLineID INT PRIMARY KEY AUTO_INCREMENT,
OrderID BIGINT,
CONSTRAINT FOREIGN KEY (OrderID)
REFERENCES Orders (OrderID),
ProductID BIGINT,
CONSTRAINT FOREIGN KEY (ProductID)
REFERENCES Product (ProductID),
QuantitySold INT   
);


   


