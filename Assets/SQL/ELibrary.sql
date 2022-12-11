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
	[ID] [int]  PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[FULLNAME] [nvarchar](50) NOT NULL,
	[GENDER] [varchar](8) NOT NULL,
	[DOB] [date] NOT NULL,
	[PHONE] [varchar](20) NOT NULL,
	[ADDRESS] [nvarchar](200) NULL,
	[DEPARTMENT] [nvarchar](100) NULL,
	[SCHOOL] [nvarchar](150) NULL,
	[IMAGE] [nvarchar](200) NULL
);

CREATE TABLE [LOANLIST](
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[BOOKID] [int] NOT NULL,
	[STUDENTID] [int] NOT NULL,
	[DATE] [date] NOT NULL,
	FOREIGN KEY(BOOKID) REFERENCES [BOOK](ID),
	FOREIGN KEY(STUDENTID) REFERENCES [STUDENT](ID),
);

--Modified by: VOTHANA-CHY Generated:12/10/2022 9:02:44 PM
INSERT INTO [BOOK] ( [TITLE] , [DESC] , [AUTHOR] , [YEAR] , [LANGAUGE] , [IMAGE] , [PDF] , [STATUS] ) 
VALUES ( 'JAVA SE' , 'Java is the best langauge ever' , 'Pilot Nama' , 2018 , 'English' , 'photo_2022-12-04_21-27-53.jpg' , 'JAVA SE' , 1 );

--Modified by: VOTHANA-CHY Generated:12/10/2022 9:09:30 PM
INSERT INTO [BOOK] ( [TITLE] , [DESC] , [AUTHOR] , [YEAR] , [LANGAUGE] , [IMAGE] , [PDF] , [STATUS] ) 
VALUES ( 'JAVA Servlets & JSP' , 'JAVA Servlets & JSP by Joel Murach 2012' , 'Joel Murach' , 2012 , 'English' , 'photo_2022-12-04_21-28-12.jpg' , 'JAVA Servlets & JSP' , 0 );

--Modified by: LAPTOP-2V73A0TT Generated:12/10/2022 10:35:13 PM
INSERT INTO [BOOK] (  ) 
VALUES ( 'JAVA Servlets & JSP' , 'JAVA Servlets & JSP by Joel Murach 2012' , 'Joel Murach' , 2012 , 'English' , '1.jpg' , 'JAVA Servlets & JSP' , 0 );
