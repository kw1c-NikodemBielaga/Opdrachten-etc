 -- --Nikodem Bielaga 
 --29-03-2025

-- Taak 7 
-- Maak de logins aan
CREATE LOGIN T7_admin WITH PASSWORD = 'P@ssword1';
CREATE LOGIN T7_playeradmin WITH PASSWORD = 'P@ssword2';
CREATE LOGIN T7_reader WITH PASSWORD = 'P@ssword3';

-- Maak de gebruikers aan in de GameScoreDB database
USE GameScoreDB;
GO

-- Voeg de juiste gebruikers toe
CREATE USER T7_admin FOR LOGIN T7_admin;
CREATE USER T7_playeradmin FOR LOGIN T7_playeradmin;
CREATE USER T7_reader FOR LOGIN T7_reader;

-- Maak de rollen aan
CREATE ROLE Admin_382890;
CREATE ROLE Playeradmin_382890;
CREATE ROLE Read_382890;

-- Voeg de juiste rollen toe aan de gebruikers
-- Admin mag alles doen behalve het bewerken van scores
EXEC sp_addrolemember 'Admin_382890', 'T7_admin';

-- Playeradmin mag alles doen, behalve het aanpassen van scores
EXEC sp_addrolemember 'Playeradmin_382890', 'T7_playeradmin';

-- Reader mag alleen gegevens bekijken
EXEC sp_addrolemember 'Read_382890', 'T7_reader';

-- Specifieke permissies voor 'Admin' (Admin mag alles doen behalve de scores bewerken)
GRANT SELECT, INSERT, DELETE ON dbo.tblPlayers TO T7_admin;
GRANT SELECT, INSERT, DELETE ON dbo.tblScores TO T7_admin;
DENY UPDATE ON dbo.tblScores TO T7_admin;  -- Admin mag scores niet bewerken

-- Specifieke permissies voor 'Playeradmin' (Playeradmin mag alle gegevens bekijken, 
-- playergegevens aanpassen, maar geen scores bewerken)
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.tblPlayers TO T7_playeradmin;
GRANT SELECT, UPDATE, DELETE ON dbo.tblScores TO T7_playeradmin;
DENY UPDATE ON dbo.tblScores TO T7_playeradmin;  -- Playeradmin mag scores niet bewerken

-- Specifieke permissies voor 'Reader' (Leesrechten alleen)
GRANT SELECT ON dbo.tblPlayers TO T7_reader;
GRANT SELECT ON dbo.tblScores TO T7_reader;
