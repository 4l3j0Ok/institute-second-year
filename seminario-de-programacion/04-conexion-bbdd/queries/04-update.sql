USE SeminarioABM;
UPDATE Personas
SET
    DNI = '{ DNI }',
    Nombre = '{ Nombre }',
    Apellido = '{ Apellido }',
    Direccion = '{ Direccion }',
    Email = '{ Email }',
    Telefono = '{ Telefono }'
WHERE DNI = '{ oldDNI }';