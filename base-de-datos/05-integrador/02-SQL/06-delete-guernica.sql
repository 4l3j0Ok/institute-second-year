USE IntegradorBanco;
-- Antes de eliminar la sucursal 4, eliminamos las cuentas asociadas a ella. Pero primero hay que eliminar las referencias en Impositor.
DELETE FROM Impositor
WHERE Cuenta IN (
        SELECT NumCuenta
        FROM Cuenta
        WHERE Sucursal = 4
    )
DELETE FROM Cuenta
WHERE Sucursal = 4;
-- Ahora se puede eliminar la sucursal 4.
DELETE FROM Sucursal
WHERE CodSucursal = 4;
SELECT *
FROM Sucursal;