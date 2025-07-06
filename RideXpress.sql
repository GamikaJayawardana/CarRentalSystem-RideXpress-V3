CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	email VARCHAR(MAX) NULL,
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	data_register DATE NULL
);

CREATE TABLE customers (
  customer_id INT PRIMARY KEY,
  first_name VARCHAR(50),
  last_name VARCHAR(50),
  email VARCHAR(100),
  phone VARCHAR(15),
  address VARCHAR(255)
);

CREATE TABLE cars (
  regNo VARCHAR(50) PRIMARY KEY,
  brand VARCHAR(50),
  model VARCHAR(50),
  year INT,
  color VARCHAR(30),
  price DECIMAL(10, 2)
);

CREATE TABLE rentals (
  rental_id INT PRIMARY KEY,
  customer_id INT,
  regNo VARCHAR(50),
  rental_date DATE,
  return_date DATE,
  rental_price DECIMAL(10, 2),
  FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
  FOREIGN KEY (regNo) REFERENCES CARS(regNo)
);

CREATE TABLE returns (
  return_id INT PRIMARY KEY,
  rental_id INT,
  return_date DATE,
  delay_days INT,
  condition VARCHAR(50),
  FOREIGN KEY (rental_id) REFERENCES rentals(rental_id)
);

INSERT INTO customers (customer_id, first_name, last_name, email, phone, address) VALUES
(1001, 'Nimal', 'Perera', 'nimalp@example.com', '0711234567', '123, Kandy Road, Colombo'),
(1002, 'Kamal', 'Fernando', 'kamalf@example.com', '0772345678', '45, Galle Road, Galle'),
(1003, 'Sunil', 'Wijesinghe', 'sunilw@example.com', '0753456789', '78, Temple Road, Kandy'),
(1004, 'Dilani', 'Jayawardena', 'dilanij@example.com', '0764567890', '12, Main Street, Matara'),
(1005, 'Ruwan', 'Silva', 'ruwans@example.com', '0785678901', '88, Hill Street, Nuwara Eliya');

INSERT INTO cars (regNo, brand, model, year, color, price) VALUES
('SG-2536', 'Toyota', 'Axio', 2016, 'White', 4500.00),
('SG-3451', 'Honda', 'Fit', 2018, 'Black', 5000.00),
('SG-8732', 'Nissan', 'X-Trail', 2015, 'Silver', 7000.00),
('SG-1290', 'Mazda', 'Demio', 2017, 'Red', 4800.00),
('SG-7621', 'Suzuki', 'Wagon R', 2019, 'Blue', 3500.00),
('SG-9812', 'Hyundai', 'Elantra', 2020, 'Grey', 6200.00),
('SG-4567', 'Kia', 'Picanto', 2021, 'Yellow', 3900.00),
('SG-3345', 'BMW', '320i', 2014, 'Black', 8000.00),
('SG-7789', 'Mitsubishi', 'Outlander', 2016, 'White', 7300.00),
('SG-6423', 'Ford', 'EcoSport', 2018, 'Orange', 5600.00);

