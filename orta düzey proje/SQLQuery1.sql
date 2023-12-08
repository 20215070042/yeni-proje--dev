CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    CategoryID INT,
    Price DECIMAL(10, 2)
);



-- Insert Procedure
CREATE PROCEDURE InsertProduct
    @ProductName NVARCHAR(100),
    @CategoryID INT,
    @Price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Products (ProductName, CategoryID, Price)
    VALUES (@ProductName, @CategoryID, @Price);
END;

-- Update Procedure
CREATE PROCEDURE UpdateProduct
    @ProductID INT,
    @ProductName NVARCHAR(100),
    @CategoryID INT,
    @Price DECIMAL(10, 2)
AS
BEGIN
    UPDATE Products
    SET ProductName = @ProductName,
        CategoryID = @CategoryID,
        Price = @Price
    WHERE ProductID = @ProductID;
END;

-- Delete Procedure
CREATE PROCEDURE DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Products
    WHERE ProductID = @ProductID;
END;

-- Select Procedure
CREATE PROCEDURE GetProducts
AS
BEGIN
    SELECT * FROM Products;
END;
