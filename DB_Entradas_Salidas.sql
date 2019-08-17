CREATE DATABASE EntradasSalidas
GO
USE EntradasSalidas
GO
CREATE TABLE Persona(
DNI VARCHAR(15) PRIMARY KEY,
Nombre VARCHAR(50),
Apellido VARCHAR(50),
Direccion VARCHAR(100),
Celular VARCHAR(30),
Email VARCHAR(100)
)
GO
CREATE TABLE Movimiento(
id INT IDENTITY(1,1) PRIMARY KEY,
DNIPersona VARCHAR(15),
FechaRegistro DATETIME,
Accion VARCHAR(80),
Detalle VARCHAR(300)
FOREIGN KEY(DNIPersona) REFERENCES Persona(DNI)
)
GO
CREATE PROC SP_BUSCAR_PERSONAS
@DNI VARCHAR(300)
AS
DECLARE 
@cont INT
SET @cont = (SELECT COUNT(*) FROM movimiento WHERE dniPersona = @DNI)

IF(@cont > 0)
BEGIN
SELECT * FROM movimiento m 
INNER JOIN Persona p ON p.DNI = m.DNIPersona 
WHERE m.dniPersona = @DNI 
AND m.fechaRegistro = (SELECT MAX(M2.fechaRegistro) FROM movimiento M2 WHERE M2.dniPersona = @DNI) 
END
ELSE
BEGIN
SELECT *,'Descanso' Accion FROM Persona WHERE DNI = @DNI
END

