 --Nikodem Bielaga 
 --29-03-2025


-- ============================
-- FULL BACKUP VAN GameScoreDB
-- ============================
BACKUP DATABASE GameScoreDB
TO DISK = 'D:\Backups\GameScoreDB_Full.bak'
WITH 
    INIT,            -- Start een nieuwe backup en overschrijft de oude
    FORMAT,          -- Zorgt ervoor dat de backup correct wordt geformatteerd
    COMPRESSION,     -- Vermindert de grootte van de backup (sneller en efficiënter)
    STATS = 10;      -- Geeft een statusupdate elke 10% van de backup

-- ============================
-- DIFFERENTIËLE BACKUP VAN GameScoreDB
-- ============================
BACKUP DATABASE GameScoreDB
TO DISK = 'D:\Backups\GameScoreDB_Diff.bak'
WITH 
    DIFFERENTIAL,    -- Alleen de wijzigingen sinds de laatste full backup
    INIT,            -- Overschrijft eerdere differential backups
    COMPRESSION,     -- Zorgt voor een kleinere backup
    STATS = 10;      -- Statusupdate elke 10%
