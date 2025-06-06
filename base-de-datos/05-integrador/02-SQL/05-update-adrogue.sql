USE IntegradorBanco;
UPDATE Sucursal
SET NomSucursal = 'Adrogué'
WHERE CodSucursal = 1;
SELECT NomSucursal
FROM Sucursal
WHERE CodSucursal = 1;