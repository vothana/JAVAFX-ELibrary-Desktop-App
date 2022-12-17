CREATE DATABASE [ELibrary];
USE [ELibrary];

CREATE TABLE [BOOK](
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL ,
	[TITLE] [nvarchar](100) NOT NULL,
	[DESC] [nvarchar](200) NOT NULL,
	[AUTHOR] [nvarchar](50) NOT NULL,
	[YEAR] [int] NOT NULL,
	[LANGAUGE] [varchar](10) NOT NULL,
	[IMAGE] [nvarchar](200) NULL,
	[PDF] [nvarchar](200) NULL,
	[STATUS] [bit] NOT NULL
) ;

CREATE TABLE [STUDENT](
	[ID] [int] PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[FULLNAME] [nvarchar](50) NOT NULL,
	[GENDER] [varchar](8) NOT NULL,
	[DOB] [date] NOT NULL,
	[PHONE] [varchar](20) NOT NULL,
	[ADDRESS] [nvarchar](200) NULL,
	[DEPARTMENT] [nvarchar](100) NULL,
	[SCHOOL] [nvarchar](150) NULL,
	[IMAGE] [nvarchar](200) NULL,
	[USERNAME] [varchar](20) NOT NULL UNIQUE,
	[PASSWORD] [varchar](20) NOT NULL,
	[ROLE] [varchar](20) NOT NULL CHECK ([ROLE] IN('ADMIN', 'STUDENT')),
);

CREATE TABLE [LOANLIST](
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[BOOKID] [int] NOT NULL,
	[STUDENTID] [int] NOT NULL,
	[DATE] [date] NOT NULL,
	FOREIGN KEY(BOOKID) REFERENCES [BOOK](ID) ON UPDATE CASCADE ON DELETE CASCADE, 
	FOREIGN KEY(STUDENTID) REFERENCES [STUDENT](ID) ON UPDATE CASCADE ON DELETE CASCADE,
);

--Dropping
DROP TABLE [LOANLIST];
DROP TABLE [STUDENT];
DROP TABLE [BOOK];

--Test selection
SELECT * FROM [BOOK];
SELECT * FROM [STUDENT];
SELECT * FROM [LOANLIST];
SELECT * FROM [STUDENT] WHERE [USERNAME] = 'admin';

--Test deletion CASCADE
DELETE FROM [BOOK] WHERE [ID] = 4;
DELETE FROM [STUDENT] WHERE [ID] = 1;

--Test selection
SELECT [LOANLIST].[ID],  [STUDENT].[FULLNAME], [BOOK].[TITLE]  FROM [LOANLIST] 
INNER JOIN [BOOK] ON [LOANLIST].[ID] = [BOOK].[ID]
INNER JOIN [STUDENT] ON [LOANLIST].[ID] = [STUDENT].[ID];

--Test selection
SELECT [BOOK].[ID], [BOOK].[TITLE] FROM [LOANLIST]
INNER JOIN [BOOK] ON [LOANLIST].[BOOKID] = [BOOK].[ID]
WHERE [STUDENTID] = 1;

--Test selection
SELECT * FROM [LOANLIST]
INNER JOIN [BOOK] ON [LOANLIST].[BOOKID] = [BOOK].[ID]
WHERE [STUDENTID] = 2;

--Test selection
SELECT TOP 1 * FROM [LOANLIST]  
INNER JOIN [BOOK] ON [LOANLIST].[BOOKID] = [BOOK].[ID] 
WHERE [STUDENTID] =  2;

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--INITIALIZE TEAM AS USER
INSERT INTO [STUDENT] ( [FULLNAME] , [GENDER] , [DOB] , [PHONE] , [ADDRESS] , [DEPARTMENT] , [SCHOOL] , [IMAGE], [USERNAME],  [PASSWORD], [ROLE]) VALUES 
( 'NUM' , 'Male' , '2000-12-12' , '0230097788', 'Phnom Penh' , '' , '' , '', 'ADMIN', '123', 'ADMIN'),
( 'Vothana CHY' , 'Male' , '2000-12-12' , '0986726261', 'Russey keo, Phnom Penh' , 'Information Technology' , 'NUM' , 'no image', 'vothana', '123', 'STUDENT'),
( 'Sornsarath Sornn' , 'Male' , '2000-12-12' , '0986726261', 'Russey keo, Phnom Penh' , 'Information Technology' , 'NUM' , 'no image', 'sarath', '123', 'STUDENT'),
( 'Sereyvoutey Nhean' , 'Female' , '2000-12-12' , '0986726261', 'Russey keo, Phnom Penh' , 'Information Technology' , 'NUM' , 'no image', 'voutey', '123', 'STUDENT'),
( 'Visal Sat' , 'Male' , '2000-12-12' , '0986726261', 'Russey keo, Phnom Penh' , 'Information Technology' , 'NUM' , 'no image', 'visal', '123', 'STUDENT'),
( 'Lyhour Leng' , 'Male' , '2000-12-12' , '0986726261', 'Russey keo, Phnom Penh' , 'Information Technology' , 'NUM' , 'no image', 'lyhour', '123', 'STUDENT');
--INITIALIZE TEAM AS USER
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Modified by: VOTHANA-CHY Generated:12/10/2022 9:02:44 PM
INSERT INTO [BOOK] ( [TITLE] , [DESC] , [AUTHOR] , [YEAR] , [LANGAUGE] , [IMAGE] , [PDF] , [STATUS] )
VALUES ( 'JAVA SE' , 'Java is the best langauge ever' , 'Pilot Nama' , 2018 , 'English' , 'photo_2022-12-04_21-27-53.jpg' , 'JAVA SE' , 0 );

--Modified by: VOTHANA-CHY Generated:12/10/2022 9:09:30 PM
INSERT INTO [BOOK] ( [TITLE] , [DESC] , [AUTHOR] , [YEAR] , [LANGAUGE] , [IMAGE] , [PDF] , [STATUS] ) 
VALUES ( 'JAVA Servlets & JSP' , 'JAVA Servlets & JSP by Joel Murach 2012' , 'Joel Murach' , 2012 , 'English' , 'photo_2022-12-04_21-28-12.jpg' , 'JAVA Servlets & JSP' , 0 );

--Modified by: VOTHANA-CHY Generated:12/12/2022 10:12:44 PM
INSERT INTO [LOANLIST] ( [BOOKID] , [STUDENTID] , [DATE] ) 
VALUES ( 1 , 2 , 12/12/2022 10:12:44 PM );

--Modified by: VOTHANA-CHY Generated:12/12/2022 10:30:37 PM
INSERT INTO [LOANLIST] ( [BOOKID] , [STUDENTID] , [DATE] ) 
VALUES ( 2 , 2 , 12/12/2022 10:30:37 PM );

--Modified by: VOTHANA-CHY Generated:12/12/2022 10:31:04 PM
INSERT INTO [LOANLIST] ( [BOOKID] , [STUDENTID] , [DATE] ) 
VALUES ( 3 , 2 , 12/12/2022 10:31:04 PM );

--Modified by: LAPTOP-2V73A0TT Generated:12/10/2022 10:35:13 PM
INSERT INTO [BOOK] (  ) 
VALUES ( 'JAVA Servlets & JSP' , 'JAVA Servlets & JSP by Joel Murach 2012' , 'Joel Murach' , 2012 , 'English' , '1.jpg' , 'JAVA Servlets & JSP' , 0 );
