 --Nikodem Bielaga 
 --29-03-2025

 --Taak5
-- 1. CREATE DATABASE
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'T7_Database')
BEGIN
    CREATE DATABASE T7_Database;
END;
GO

USE T7_Database;
GO