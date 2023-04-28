CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    PRIMARY KEY (ProductID, CategoryID)
);

INSERT INTO Products
VALUES
    (1, 'CLR via C#'),
    (2, 'Xiaomi Book Pro 14'),
    (3, 'Телевизор LED Olto 24T20H');

INSERT INTO Categories
VALUES
    (1, 'Книги'),
    (2, 'Ноутбуки'),
    (3, 'Книги по C#');

INSERT INTO ProductCategories
VALUES
    (1, 1),
    (1, 3),
    (2, 2);

SELECT p.ProductName, c.CategoryName
FROM Products p
    LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
    LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
ORDER BY p.ProductName;