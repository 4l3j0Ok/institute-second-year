IF NOT EXISTS (
    SELECT *
    FROM sys.databases
    WHERE name = 'SeminarioABM'
) BEGIN CREATE DATABASE SeminarioABM
END;