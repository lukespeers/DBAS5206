-- File			: location_types.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the location_types table

IF OBJECT_ID('dbo.location_types', 'U') IS NOT NULL
	DROP TABLE location_types;

CREATE TABLE location_types
(
	location_type VARCHAR(2) PRIMARY KEY,
	type_description VARCHAR(20) NOT NULL
);