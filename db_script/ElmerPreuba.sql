-- Creacion de la tabla
CREATE TABLE Persona (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL
);

-- Datos de muestra
INSERT INTO Persona (Nombre, Fecha_Nacimiento) VALUES
('Elmer', '2002-07-21'),
('Ricardo', '2001-04-03'),
('Manuel', '1998-01-12');
