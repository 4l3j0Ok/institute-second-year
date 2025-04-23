-- Join de tablas para mostrar todos los clientes y sus pedidos
USE Comercio;
SELECT Comercio.nombre AS Comercio,
    Ciudad.nombre as Ciudad,
    Provincia.nombre as Provincia
FROM Comercio
    INNER JOIN Ciudad ON Ciudad.id = Comercio.idCiudad
    INNER JOIN Provincia ON Provincia.id = Ciudad.idProvincia;