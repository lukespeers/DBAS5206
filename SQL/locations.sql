-- File			: locations.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the locations table

IF OBJECT_ID('dbo.locations', 'U') IS NOT NULL
	DROP TABLE locations;

CREATE TABLE locations
(
	location_id VARCHAR(8) PRIMARY KEY,
	location_type VARCHAR(2) REFERENCES location_types(location_type),
	location_extension INT
);