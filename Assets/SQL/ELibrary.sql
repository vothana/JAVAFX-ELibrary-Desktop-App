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
	[SHCOOL] [nvarchar](150) NULL,
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

--Modified by: VOTHANA-CHY Generated:12/10/2022 5:09:43 PM
INSERT INTO [BOOK] (  ) 
VALUES ( 'Java for Web Applications' , 'Java for Web Applications  by Williams 2014' , 'Williams' , 2014 , 'English' , 'photo_2022-12-04_21-27-53.jpg' , 'Java for Web Applications' , 1 );
