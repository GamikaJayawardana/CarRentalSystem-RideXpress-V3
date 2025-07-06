IF DB_ID('RideXpress') IS NULL
BEGIN
    CREATE DATABASE RideXpress;
END;
GO

USE RideXpress;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'customers')
BEGIN
    CREATE TABLE customers (
        customer_id INT PRIMARY KEY,
        name VARCHAR(50),
        contact VARCHAR(50)
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cars')
BEGIN
    CREATE TABLE cars (
        regNo VARCHAR(50) PRIMARY KEY,
        brand VARCHAR(50),
        model VARCHAR(50),
        year INT,
        color VARCHAR(50),
        price DECIMAL(10, 2)
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'rentals')
BEGIN
    CREATE TABLE rentals (
        rental_id INT PRIMARY KEY,
        customer_id INT,
        regNo VARCHAR(50),
        rental_date DATE,
        return_date DATE,
        rental_price DECIMAL(10, 2),
        FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
        FOREIGN KEY (regNo) REFERENCES cars(regNo)
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'returns')
BEGIN
    CREATE TABLE returns (
        return_id INT PRIMARY KEY,
        rental_id INT,
        return_date DATE,
        delay_days INT,
        condition VARCHAR(50),
        FOREIGN KEY (rental_id) REFERENCES rentals(rental_id)
    );
END;
