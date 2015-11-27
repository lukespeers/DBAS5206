-- File			: physicians.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the physicians table

IF OBJECT_ID('dbo.physicians', 'U') IS NOT NULL
	DROP TABLE physicians;

CREATE TABLE physicians
(
	physician_id INT PRIMARY KEY,
	physician_first_name VARCHAR(25) NOT NULL,
	physician_last_name VARCHAR(50) NOT NULL,
	physician_phone_number VARCHAR(15)
);