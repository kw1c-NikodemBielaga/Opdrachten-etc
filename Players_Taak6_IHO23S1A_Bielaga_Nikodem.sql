 --Nikodem Bielaga 
 --29-03-2025

-- Taak6
USE master;
GO
DROP DATABASE IF EXISTS GameScoreDB;
GO

CREATE DATABASE GameScoreDB;
GO

USE GameScoreDB;

CREATE TABLE tblPlayers 
(
     PlayerId      INT           IDENTITY(1,1)    PRIMARY KEY
    ,PlayerName	   VARCHAR(20)                    NOT NULL
    ,FirstName     VARCHAR(10)                    NOT NULL
    ,LastName	   VARCHAR(15)                    NOT NULL
    ,Email	       VARCHAR(45)                    NOT NULL
    ,DateofBirth   VARCHAR(10)                    NOT NULL
);

CREATE TABLE tblScores
(
   ScoreId    INT               IDENTITY(1,1)   PRIMARY KEY
  ,PlayerName VARCHAR(20)                        NOT NULL
  ,Score      INTEGER                            NOT NULL
  ,ScoreDate  VARCHAR(10)                        NOT NULL
);

--tabel invoeren

INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rsprasen0', 'Rae', 'Sprasen', 'rsprasen0@statcounter.com', '12.06.1995');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('apraundlin1', 'Angelle', 'Praundlin', 'apraundlin1@mapy.cz', '15.09.1997');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('fitskovitz2', 'Feodor', 'Itskovitz', 'fitskovitz2@comsenz.com', '31.08.1988');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rnoore3', 'Rebekah', 'Noore', 'rnoore3@vk.com', '09.10.1987');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('scashman4', 'Sallyanne', 'Cashman', 'scashman4@nifty.com', '24.09.1992');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('cwharf5', 'Cass', 'Wharf', 'cwharf5@furl.net', '29.05.1990');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('djohnston6', 'Danice', 'Johnston', 'djohnston6@topsy.com', '29.07.1999');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('twalne7', 'Tally', 'Walne', 'twalne7@aboutads.info', '05.01.1991');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('fwhawell8', 'Foss', 'Whawell', 'fwhawell8@disqus.com', '04.09.1997');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rgravett9', 'Rockie', 'Gravett', 'rgravett9@surveymonkey.com', '25.09.1993');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('abenna', 'Adolpho', 'Benn', 'abenna@nytimes.com', '07.01.1989');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('wbirdisb', 'Warden', 'Birdis', 'wbirdisb@wordpress.com', '13.05.1996');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('pszepec', 'Pammi', 'Szepe', 'pszepec@smugmug.com', '30.04.1995');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('jbednalld', 'Joelle', 'Bednall', 'jbednalld@sogou.com', '24.10.2000');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rkarpee', 'Rozelle', 'Karpe', 'rkarpee@ibm.com', '24.11.1997');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('ipoizerf', 'Inger', 'Poizer', 'ipoizerf@marketwatch.com', '02.09.1997');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('falfonsog', 'Fannie', 'Alfonso', 'falfonsog@infoseek.co.jp', '29.05.1991');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('nplevinh', 'Nicolais', 'Plevin', 'nplevinh@mediafire.com', '18.03.2001');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('bantcliffi', 'Brandtr', 'Antcliff', 'bantcliffi@go.com', '02.01.1991');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('lneumannj', 'Livvie', 'Neumann', 'lneumannj@jalbum.net', '14.09.1989');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rsiemonk', 'Rand', 'Siemon', 'rsiemonk@prlog.org', '09.01.1999');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rkleanthousl', 'Reinaldos', 'Kleanthous', 'rkleanthousl@webnode.com', '21.02.1989');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('mbloysm', 'Muhammad', 'Bloys', 'mbloysm@1und1.de', '04.05.1995');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('kmaclachlann', 'Kristi', 'MacLachlan', 'kmaclachlann@com.com', '27.07.1991');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('abraisbyo', 'Alice', 'Braisby', 'abraisbyo@bluehost.com', '24.11.2001');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('lwattp', 'Lucila', 'Watt', 'lwattp@indiegogo.com', '07.02.2002');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('jstutq', 'Jens', 'Stut', 'jstutq@google.co.uk', '14.05.1998');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('mkillelear', 'Maurine', 'Killelea', 'mkillelear@google.fr', '09.01.2001');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('badanets', 'Buiron', 'Adanet', 'badanets@cyberchimps.com', '08.02.1989');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('abromeheadt', 'Albertine', 'Bromehead', 'abromeheadt@howstuffworks.com', '30.06.1999');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('nbazleyu', 'Nicol', 'Bazley', 'nbazleyu@jimdo.com', '18.02.1992');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('jjacklinv', 'Justinian', 'Jacklin', 'jjacklinv@dailymail.co.uk', '10.06.1988');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('lspadaw', 'Luis', 'Spada', 'lspadaw@bloglovin.com', '31.12.1994');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('yoldknowx', 'Yank', 'Oldknow', 'yoldknowx@europa.eu', '16.12.1988');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('ttunnacliffey', 'Tanny', 'Tunnacliffe', 'ttunnacliffey@princeton.edu', '21.04.1987');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('rburwinz', 'Ricca', 'Burwin', 'rburwinz@walmart.com', '29.07.1994');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('kbollin10', 'Konstance', 'Bollin', 'kbollin10@usda.gov', '01.02.1994');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('ovenour11', 'Odele', 'Venour', 'ovenour11@disqus.com', '01.03.1988');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('kmonksfield12', 'Kassie', 'Monksfield', 'kmonksfield12@mapquest.com', '25.09.1988');
INSERT INTO tblPlayers (PlayerName, FirstName, LastName, Email, DateofBirth) VALUES ('nstacy13', 'Nichole', 'Stacy', 'nstacy13@berkeley.edu', '28.07.2001');


--tblcore Tabel invoeren 
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('apraundlin1',1050,'24-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fitskovitz2',11,'18-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rnoore3',188,'6-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('scashman4',778,'27-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('cwharf5',990,'19-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('djohnston6',565,'13-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('twalne7',346,'21-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fwhawell8',309,'8-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rgravett9',1063,'16-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abenna',554,'6-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('wbirdisb',678,'28-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('pszepec',854,'24-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jbednalld',905,'20-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkarpee',519,'16-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ipoizerf',886,'1-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('falfonsog',446,'27-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nplevinh',1075,'24-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('bantcliffi',15,'17-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lneumannj',37,'6-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsiemonk',64,'13-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkleanthousl',87,'11-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mbloysm',788,'25-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmaclachlann',1014,'14-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abraisbyo',73,'20-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lwattp',359,'14-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jstutq',11,'12-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mkillelear',1075,'9-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('badanets',1009,'21-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abromeheadt',814,'3-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nbazleyu',993,'2-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jjacklinv',763,'15-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lspadaw',684,'11-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('yoldknowx',914,'27-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ttunnacliffey',183,'22-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rburwinz',81,'21-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kbollin10',977,'4-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ovenour11',99,'18-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmonksfield12',991,'25-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nstacy13',504,'27-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsprasen0',1004,'7-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('apraundlin1',444,'25-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fitskovitz2',07,'9-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rnoore3',1118,'2-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('scashman4',308,'9-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('cwharf5',34,'16-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('djohnston6',116,'26-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('twalne7',1107,'2-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fwhawell8',1031,'5-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rgravett9',68,'9-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abenna',610,'20-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('wbirdisb',1153,'15-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('pszepec',853,'25-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jbednalld',334,'18-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkarpee',745,'14-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ipoizerf',1108,'8-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('falfonsog',407,'16-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nplevinh',35,'17-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('bantcliffi',849,'29-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lneumannj',1083,'28-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsiemonk',868,'5-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkleanthousl',1073,'21-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mbloysm',648,'13-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmaclachlann',950,'23-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abraisbyo',537,'14-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lwattp',36,'8-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jstutq',38,'2-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mkillelear',397,'1-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('badanets',749,'19-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abromeheadt',689,'21-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nbazleyu',38,'4-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jjacklinv',876,'26-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lspadaw',197,'14-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('yoldknowx',753,'15-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ttunnacliffey',949,'26-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rburwinz',746,'22-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kbollin10',47,'29-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ovenour11',665,'21-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmonksfield12',535,'13-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nstacy13',1118,'28-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsprasen0',760,'24-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('apraundlin1',710,'28-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fitskovitz2',488,'19-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rnoore3',573,'16-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('scashman4',94,'16-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('cwharf5',674,'28-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('djohnston6',1015,'4-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('twalne7',89,'27-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fwhawell8',518,'2-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rgravett9',977,'6-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abenna',16,'13-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('wbirdisb',513,'6-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('pszepec',858,'31-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jbednalld',864,'25-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkarpee',460,'28-2-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ipoizerf',545,'6-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('falfonsog',660,'9-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nplevinh',556,'25-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('bantcliffi',1156,'15-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lneumannj',93,'8-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsiemonk',6,'1-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkleanthousl',353,'20-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mbloysm',309,'27-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmaclachlann',1109,'13-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abraisbyo',1066,'27-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lwattp',1,'13-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jstutq',761,'5-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mkillelear',539,'6-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('badanets',989,'12-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abromeheadt',96,'8-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nbazleyu',1097,'1-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jjacklinv',847,'8-1-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lspadaw',34,'22-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('yoldknowx',318,'1-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ttunnacliffey',1094,'19-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rburwinz',761,'22-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kbollin10',70,'15-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ovenour11',31,'10-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmonksfield12',864,'28-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nstacy13',1,'12-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsprasen0',90,'6-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('apraundlin1',1001,'27-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fitskovitz2',63,'21-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rnoore3',695,'19-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('scashman4',873,'1-6-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('cwharf5',554,'4-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('djohnston6',468,'29-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('twalne7',54,'7-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('fwhawell8',531,'6-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rgravett9',1146,'3-10-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abenna',190,'13-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('wbirdisb',600,'30-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('pszepec',69,'20-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jbednalld',1048,'17-7-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkarpee',584,'30-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('ipoizerf',807,'19-2-2022');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('falfonsog',918,'17-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('nplevinh',1093,'1-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('bantcliffi',405,'18-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lneumannj',737,'31-8-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rsiemonk',675,'12-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('rkleanthousl',116,'25-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mbloysm',531,'7-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('kmaclachlann',568,'5-3-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abraisbyo',39,'19-5-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('lwattp',761,'28-11-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('jstutq',588,'26-9-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('mkillelear',330,'12-12-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('badanets',91,'14-4-2021');
INSERT INTO tblScores(PlayerName,Score,ScoreDate) VALUES ('abromeheadt',470,'14-9-2021');
