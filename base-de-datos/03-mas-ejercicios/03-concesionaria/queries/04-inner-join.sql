USE Concesionaria;
SELECT Automovil.patente,
    Automovil.marca as "Marca",
    Automovil.modelo as "Modelo",
    Automovil.color as "Color",
    Automovil.precio as "Precio",
    Cliente.nombre as "Nombre del cliente",
    Cliente.ciudad as "Ciudad del cliente",
    Cliente.direccion as "Dirección del cliente",
    Cliente.nroTelefono as "Numero de teléfono",
    Revision.nombre as "Nombre de la revisión"
FROM Automovil
    INNER JOIN Recibe ON Automovil.patente = Recibe.patenteAutomovil
    INNER JOIN Cliente ON Cliente.id = Automovil.idCliente
    INNER JOIN Revision ON Revision.codigo = Recibe.codigoRevision