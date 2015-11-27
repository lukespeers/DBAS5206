-- File			: specialties.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the specialties table

IF OBJECT_ID('dbo.specialties', 'U') IS NOT NULL
	DROP TABLE specialties;

CREATE TABLE specialties
(
	specialty_id VARCHAR(8) PRIMARY KEY,
	description VARCHAR(20) NOT NULL
);