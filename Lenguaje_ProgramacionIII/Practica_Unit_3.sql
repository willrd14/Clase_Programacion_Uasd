CREATE DATABASE PRASQL;

USE PRASQL;

CREATE TABLE Cliente(
	iCodCliente INT NOT NULL,
    cNomCliente VARCHAR(50) NOT NULL,
    cEstado VARCHAR(10) NOT NULL
);

CREATE TABLE Factura(
	iCodCliente INT NOT NULL,
    iNumFactura INT NOT NULL,
    dMonto DECIMAL(10,2) NOT NULL
);

CREATE TABLE Recibo(
	iCodCliente INT NOT NULL,
    iNumRecibo INT NOT NULL,
    iNumFactura INT NOT NULL,
    dMonto DECIMAL(10,2) NOT NULL
);

ALTER TABLE Cliente
ADD CONSTRAINT Cliente PRIMARY KEY (iCodCliente);

ALTER TABLE Factura
ADD CONSTRAINT Factura PRIMARY KEY (iNumFactura);

ALTER TABLE Recibo
ADD CONSTRAINT Recibo PRIMARY KEY (iNumRecibo);

ALTER TABLE Factura
ADD CONSTRAINT Factura_Cliente
FOREIGN KEY (iCodCliente) REFERENCES Cliente(iCodCliente);

ALTER TABLE Recibo
ADD CONSTRAINT Recibo_Cliente
FOREIGN KEY (iCodCliente) REFERENCES Cliente(iCodCliente);

ALTER TABLE Recibo
ADD CONSTRAINT Recibo_Factura
FOREIGN KEY (iNumFactura) REFERENCES Factura(iNumFactura);

-- Clientes
INSERT INTO Cliente VALUES (1,'Juan Pérez','Activo');
INSERT INTO Cliente VALUES (2,'Julio Paz','Activo');
INSERT INTO Cliente VALUES (3,'Rosa Fernández','Activo');
INSERT INTO Cliente VALUES (4,'Luis Roja','Activo');
INSERT INTO Cliente VALUES (5,'Carmen García','Activo');
INSERT INTO Cliente VALUES (6,'Roberto Ledesma','Activo');
INSERT INTO Cliente VALUES (7,'Carlos Caraballo','Activo');
INSERT INTO Cliente VALUES (8,'Juana Rosario','Activo');
INSERT INTO Cliente VALUES (9,'Pedro Jiménez','Activo');

-- Facturas
INSERT INTO Factura VALUES (7, 120, 1000.00);
INSERT INTO Factura VALUES (8, 121,  500.00);
INSERT INTO Factura VALUES (7, 122,  200.00);
INSERT INTO Factura VALUES (5, 111,  700.00);
INSERT INTO Factura VALUES (5, 112, 1500.00);
INSERT INTO Factura VALUES (9, 172, 2000.00);
INSERT INTO Factura VALUES (7, 173, 2500.00);
INSERT INTO Factura VALUES (8, 123, 3500.00);
INSERT INTO Factura VALUES (9, 175, 4600.00);

-- Recibos
INSERT INTO Recibo VALUES (7,  71, 120,  -100.00);
INSERT INTO Recibo VALUES (7,  80, 120,  -200.00);
INSERT INTO Recibo VALUES (8,  82, 121,  -100.00);
INSERT INTO Recibo VALUES (5,  91, 111,  -200.00);
INSERT INTO Recibo VALUES (5,  93, 112,  -300.00);
INSERT INTO Recibo VALUES (5,  96, 112,  -400.00);
INSERT INTO Recibo VALUES (9,  98, 172,  -200.00);
INSERT INTO Recibo VALUES (7,  99, 173,  -500.00);
INSERT INTO Recibo VALUES (8, 100, 123, -3500.00);
INSERT INTO Recibo VALUES (9, 101, 175, -4000.00);
INSERT INTO Recibo VALUES (7, 102, 173,  -600.00);
INSERT INTO Recibo VALUES (7, 103, 122,  -100.00);

SELECT   iCodCliente            AS 'Código Cliente',
         SUM(dMonto)            AS 'Total Facturado'
FROM     Factura
GROUP BY iCodCliente;

SELECT   iCodCliente            AS 'Código Cliente',
         iNumFactura            AS 'Número Factura',
         SUM(dMonto)            AS 'Total Pagado'
FROM     Recibo
GROUP BY iCodCliente, iNumFactura;

SELECT   iCodCliente            AS 'Código Cliente',
         COUNT(iNumFactura)     AS 'Cantidad Facturas'
FROM     Factura
GROUP BY iCodCliente
HAVING   COUNT(iNumFactura) > 1;

SELECT *
FROM   Factura
WHERE  iCodCliente = 5;

SELECT *
FROM   Recibo
WHERE  iCodCliente = 16;

SELECT   iCodCliente            AS 'Código Cliente',
         COUNT(iNumFactura)     AS 'Cantidad Facturas'
FROM     Factura
GROUP BY iCodCliente;

SELECT COUNT(iNumFactura) AS 'Total de Facturas'
FROM   Factura;

SELECT COUNT(iNumRecibo) AS 'Total de Recibos'
FROM   Recibo;

SELECT TOP 1
       iCodCliente        AS 'Código Cliente',
       SUM(dMonto)        AS 'Total Facturado'
FROM   Factura
GROUP BY iCodCliente
ORDER BY SUM(dMonto) DESC;

SELECT TOP 1
       iCodCliente        AS 'Código Cliente',
       SUM(dMonto)        AS 'Total Facturado'
FROM   Factura
GROUP BY iCodCliente
ORDER BY SUM(dMonto) ASC;

SELECT  f.iCodCliente                    AS 'Código Cliente',
        f.iNumFactura                    AS 'Número Factura',
        f.dMonto                         AS 'Facturado',
        ISNULL(SUM(r.dMonto), 0)         AS 'Pagado',
        f.dMonto + ISNULL(SUM(r.dMonto), 0) AS 'Deuda Pendiente'
FROM    Factura f
        LEFT JOIN Recibo r
            ON f.iNumFactura = r.iNumFactura
GROUP BY f.iCodCliente, f.iNumFactura, f.dMonto;

SELECT  f.iCodCliente                              AS 'Código Cliente',
        SUM(f.dMonto) + ISNULL(SUM(r.dMonto), 0)  AS 'Deuda Total'
FROM    Factura f
        LEFT JOIN tbl_Recibo r
            ON f.iNumFactura = r.iNumFactura
GROUP BY f.iCodCliente;

SELECT   iCodCliente        AS 'Código Cliente',
         iNumFactura        AS 'Número Factura',
         SUM(dMonto)        AS 'Total Pagado'
FROM     Recibo
GROUP BY iCodCliente, iNumFactura;

SELECT   iCodCliente        AS 'Código Cliente',
         SUM(dMonto)        AS 'Total Pagado'
FROM     tbl_Recibo
GROUP BY iCodCliente;