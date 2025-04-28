USE Transportes;
-- Paquetes: De los paquetes transportados interesa conocer el código de paquete, descripción, destinatario y dirección del destinatario
-- Provincia: Codigo provincia y el nombre
-- Camionero: DNI, nombre y teléfono
-- Camion: Conocer la patente, modelo, marca y potencia
-- Maneja: Fecha
SELECT Paquete.codigo AS "Código del paquete",
    Paquete.descripcion AS "Descripción",
    Paquete.destinatario AS "Destinatario",
    Paquete.direccion AS "Dirección",
    Provincia.codigo AS "Código provincia",
    Provincia.nombre AS "Nombre provincia",
    Camionero.DNI AS "DNI Camionero",
    Camionero.nombre AS "Nombre Camionero",
    Camionero.telefono AS "Teléfono Camionero",
    Camion.patente AS "Patente Camion",
    Camion.modelo AS "Modelo Camion",
    Camion.marca AS "Marca Camion",
    Camion.potencia AS "Potencia Camion",
    Maneja.fechaManejo AS "Fecha de manejo"
FROM Paquete
    INNER JOIN Provincia ON Paquete.codigoProvincia = Provincia.codigo
    INNER JOIN Camionero ON Paquete.DNICamionero = Camionero.DNI
    INNER JOIN Maneja ON Paquete.DNICamionero = Maneja.DNICamionero
    INNER JOIN Camion ON Maneja.patenteCamion = Camion.patente;