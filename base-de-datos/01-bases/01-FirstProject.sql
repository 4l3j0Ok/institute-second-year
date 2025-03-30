CREATE DATABASE FirstProject;
USE FirstProject;
CREATE TABLE Perro(
id int NOT NULL IDENTITY(1,1),
name varchar(50) NOT NULL,
race varchar(50) NOT NULL,
age int NOT NULL
)

INSERT INTO Perro(name, race, age) VALUES ('Firulais', 'Pastor Aleman', 5);

UPDATE Perro SET name ='Firulais Jr.' WHERE id = 1;

UPDATE Perro SET name = 'Firulais' WHERE name = 'Firulais Jr.';

SELECT * FROM Perro;

UPDATE Perro SET age = 5 WHERE age = 6;

DELETE FROM Perro WHERE id = 2;

SELECT * FROM Perro;