### 🧠 Machete SQL Server — Consultas Fundamentales

Este resumen cubre los **JOINs**, **VIEWS**, **Stored Procedures** y el uso de **GROUP BY**, con sintaxis, ejemplos y explicaciones prácticas. Ideal para repasar antes de un examen o práctica.

---

## 🔹 1. JOINs — Combinar tablas

Los **JOINs** permiten unir datos de varias tablas según una relación entre sus columnas.

### 🔸 INNER JOIN

Devuelve solo las filas que **coinciden en ambas tablas**.

```sql
SELECT u.Nombre, p.Id AS PedidoId, p.Total
FROM Usuarios u
INNER JOIN Pedidos p ON u.Id = p.UsuarioId;
```

**Resultado:** solo los usuarios que tienen pedidos.

---

### 🔸 LEFT JOIN

Devuelve **todas las filas de la tabla izquierda**, aunque no tengan coincidencia en la derecha.
Los valores sin coincidencia aparecen como `NULL`.

```sql
SELECT u.Nombre, p.Id AS PedidoId, p.Total
FROM Usuarios u
LEFT JOIN Pedidos p ON u.Id = p.UsuarioId;
```

**Ejemplo:** todos los usuarios, incluso los que nunca hicieron pedidos.

---

### 🔸 RIGHT JOIN

Devuelve **todas las filas de la tabla derecha**, aunque no haya coincidencia en la izquierda.

```sql
SELECT p.Id AS PedidoId, u.Nombre, p.Total
FROM Pedidos p
RIGHT JOIN Usuarios u ON p.UsuarioId = u.Id;
```

**Nota:** es funcionalmente igual a invertir el orden de las tablas en un `LEFT JOIN`.

---

### 🔸 FULL JOIN

Devuelve **todas las filas** de ambas tablas, coincidan o no.

```sql
SELECT u.Nombre, p.Id AS PedidoId, p.Total
FROM Usuarios u
FULL JOIN Pedidos p ON u.Id = p.UsuarioId;
```

**Usado cuando necesitás un panorama completo**, con coincidencias y no coincidencias.

---

## 🔹 2. VIEWS — Consultas guardadas

Una **view** (vista) es una consulta almacenada que se comporta como una tabla virtual. No guarda datos, solo la lógica de la consulta.

### 🔸 Crear una vista

```sql
CREATE VIEW vw_PedidosConUsuarios
AS
SELECT 
    p.Id AS PedidoId,
    u.Nombre AS Usuario,
    u.Email,
    p.FechaPedido,
    p.Total,
    COUNT(d.Id) AS CantProductos,
    SUM(d.Cantidad * d.PrecioUnitario) AS MontoCalculado
FROM Pedidos p
INNER JOIN Usuarios u ON p.UsuarioId = u.Id
INNER JOIN DetallePedidos d ON p.Id = d.PedidoId
GROUP BY p.Id, u.Nombre, u.Email, p.FechaPedido, p.Total;
```

### 🔸 Consultar la vista

```sql
SELECT * FROM vw_PedidosConUsuarios;
```

**Ventajas:**

* Simplifica consultas complejas.
* Oculta la lógica interna.
* Permite controlar acceso a datos.

---

## 🔹 3. STORED PROCEDURES — Código ejecutable almacenado

Un **stored procedure** (SP) es un bloque de código SQL que puede recibir parámetros y ejecutar lógica compleja.

### 🔸 Crear un SP

```sql
CREATE PROCEDURE ObtenerPedidosPorUsuario
    @UsuarioId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.Id AS PedidoId,
        p.FechaPedido,
        p.Total,
        pr.Nombre AS Producto,
        d.Cantidad,
        d.PrecioUnitario
    FROM Pedidos p
    INNER JOIN DetallePedidos d ON p.Id = d.PedidoId
    INNER JOIN Productos pr ON d.ProductoId = pr.Id
    WHERE p.UsuarioId = @UsuarioId;
END;
```

### 🔸 Ejecutar el SP

```sql
EXEC ObtenerPedidosPorUsuario @UsuarioId = 1;
```

**Ventajas:**

* Permite lógica condicional (`IF`, `WHILE`, `BEGIN TRANSACTION`).
* Mejora seguridad (el usuario no necesita permisos directos sobre tablas).
* Mejora el rendimiento (plan de ejecución cacheado).

---

## 🔹 4. GROUP BY — Agrupar y resumir datos

Se usa para **agrupar filas** que comparten valores y aplicar funciones de agregación (`SUM`, `AVG`, `COUNT`, etc.).

### 🔸 Ejemplo práctico

```sql
SELECT 
    u.Nombre AS Usuario,
    COUNT(p.Id) AS CantidadPedidos,
    SUM(p.Total) AS TotalGastado
FROM Usuarios u
LEFT JOIN Pedidos p ON u.Id = p.UsuarioId
GROUP BY u.Nombre;
```

**Explicación:**

* Agrupa por usuario.
* Cuenta cuántos pedidos hizo cada uno.
* Suma el total gastado.

### 🔸 HAVING — filtrar agrupaciones

```sql
SELECT 
    u.Nombre,
    SUM(p.Total) AS TotalGastado
FROM Usuarios u
JOIN Pedidos p ON u.Id = p.UsuarioId
GROUP BY u.Nombre
HAVING SUM(p.Total) > 10000;
```

**Diferencia entre WHERE y HAVING:**

* `WHERE` filtra **antes** del `GROUP BY`.
* `HAVING` filtra **después** del agrupamiento.

---

## 🔹 5. Comparación rápida: VIEW vs SP

| Característica | VIEW                   | STORED PROCEDURE              |
| -------------- | ---------------------- | ----------------------------- |
| Tipo           | Consulta almacenada    | Código ejecutable             |
| Modifica datos | No                     | Sí (si se programa)           |
| Parámetros     | No acepta              | Sí acepta                     |
| Ejecución      | `SELECT * FROM vista;` | `EXEC nombre @param = valor;` |
| Complejidad    | Solo SELECT            | Lógica compleja posible       |
| Uso típico     | Mostrar datos          | Operar sobre datos            |

---

## 🔹 6. BONUS — Orden recomendado para practicar

1. Crea las tablas (`Usuarios`, `Productos`, `Pedidos`, `DetallePedidos`).
2. Inserta los datos de prueba.
3. Practicá:

   * `INNER`, `LEFT`, `RIGHT` y `FULL JOIN`.
   * Agrupar con `GROUP BY` y filtrar con `HAVING`.
   * Crear una `VIEW` y hacer un `SELECT` sobre ella.
   * Crear un `STORED PROCEDURE` con parámetros.
