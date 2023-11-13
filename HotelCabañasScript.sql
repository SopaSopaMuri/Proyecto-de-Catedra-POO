
--hotel Cabañas
CREATE DATABASE hotel_Cabanas;

--Tabla principal
CREATE TABLE Hotel (
    HotelID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Direccion VARCHAR(255)
);

--tabla Habitaciones 
CREATE TABLE Habitaciones (
    HabitacionID INT PRIMARY KEY,
    HotelID INT,
    Tipo VARCHAR(50),
    Precio DECIMAL(10, 2),
    FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID)
);

-- tabla Reservaciones 
CREATE TABLE Reservaciones (
    ReservacionID INT PRIMARY KEY,
    HabitacionID INT,
    FechaInicio DATE,
    FechaFin DATE,
    FOREIGN KEY (HabitacionID) REFERENCES Habitaciones(HabitacionID)
);

--tabla Huéspedes
CREATE TABLE Huespedes (
    HuespedID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Email VARCHAR(100)
);

--tabla Empleados
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Cargo VARCHAR(50)
);

--tabla Sueldo 
CREATE TABLE Sueldo (
    EmpleadoID INT,
    Monto DECIMAL(10, 2),
    Mes INT,
    Año INT,
    FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID)
);

--tabla Ingresos 
CREATE TABLE Ingresos (
    IngresoID INT PRIMARY KEY,
    HotelID INT,
    Monto DECIMAL(10, 2),
    Fecha DATE,
    FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID)
);

-- tabla Gastos
CREATE TABLE Gastos (
    GastoID INT PRIMARY KEY,
    HotelID INT,
    Descripcion VARCHAR(255),
    Monto DECIMAL(10, 2),
    Fecha DATE,
    FOREIGN KEY (HotelID) REFERENCES Hotel(HotelID)
);

INSERT INTO Hotel (HotelID, Nombre, Direccion) VALUES
(1, 'Hotel Playa Paradise', '123 Ocean Avenue, Beach Town'),
(2, 'Cabañas de Montaña', '456 Mountain Road, Mountain Village');

INSERT INTO Habitaciones (HabitacionID, HotelID, Tipo, Precio) VALUES
(1, 1, 'Individual', 120.00),
(2, 1, 'Doble', 180.00),
(3, 2, 'Estándar', 90.00),
(4, 2, 'Suite', 200.00);

INSERT INTO Reservaciones (ReservacionID, HabitacionID, FechaInicio, FechaFin) VALUES
(1, 1, '2023-11-15', '2023-11-20'),
(2, 3, '2023-12-10', '2023-12-15');

INSERT INTO Huespedes (HuespedID, Nombre, Email) VALUES
(1, 'Ana Rodríguez', 'ana@example.com'),
(2, 'Juan Pérez', 'juan@example.com');

INSERT INTO Empleados (EmpleadoID, Nombre, Cargo) VALUES
(1, 'María López', 'Recepcionista'),
(2, 'Carlos Ramírez', 'Camarero');

INSERT INTO Sueldo (EmpleadoID, Monto, Mes, Año) VALUES
(1, 2500.00, 11, 2023),
(2, 2000.00, 11, 2023);

INSERT INTO Ingresos (IngresoID, HotelID, Monto, Fecha) VALUES
(1, 1, 5000.00, '2023-11-15'),
(2, 2, 3000.00, '2023-12-10');

INSERT INTO Gastos (GastoID, HotelID, Descripcion, Monto, Fecha) VALUES
(1, 1, 'Mantenimiento', 800.00, '2023-11-20'),
(2, 2, 'Suministros', 500.00, '2023-12-15');
