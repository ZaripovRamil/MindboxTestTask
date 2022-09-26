CREATE TABLE Products (
    id INTEGER IDENTITY(1,1) PRIMARY KEY ,
    name TEXT
);

CREATE TABLE Categories (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    name TEXT
);

CREATE TABLE ProductCategoryPairing (
    pairId INTEGER IDENTITY(1,1) PRIMARY KEY,
    productId INTEGER FOREIGN KEY REFERENCES Products(id),
    categoryId INT FOREIGN KEY REFERENCES Categories(id),
);

INSERT INTO Products(name)
Values('Twix');
INSERT INTO Products(name)
Values('Kitkat');
Insert INTO Products(name)
Values('Greenfield');

INSERT INTO Categories(name)
Values('Sweets');
INSERT INTO Categories(name)
Values('Food');
Insert INTO Categories(name)
Values('Tea');

INSERT INTO ProductCategoryPairing(productId, categoryId)
Values(1,1)
INSERT INTO ProductCategoryPairing(productId, categoryId)
Values(1,2)
INSERT INTO ProductCategoryPairing(productId, categoryId)
Values(2,1)
INSERT INTO ProductCategoryPairing(productId, categoryId)
Values(2,2)
INSERT INTO ProductCategoryPairing(productId, categoryId)
Values(3,3)

SELECT Products.name, Categories.name From Products
    LEFT JOIN ProductCategoryPairing ON ProductCategoryPairing.productId = Products.id
    LEFT JOIN Categories ON ProductCategoryPairing.categoryId = Categories.id;