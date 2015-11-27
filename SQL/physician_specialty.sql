-- File			: physician_specialty.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the physician_specialty table

IF OBJECT_ID('dbo.physician_specialty', 'U') IS NOT NULL
	DROP TABLE physician_specialty;

CREATE TABLE physician_specialty
(
	physician_id INT REFERENCES physicians(physician_id),
	specialty_id VARCHAR(8) REFERENCES specialties(specialty_id)
);