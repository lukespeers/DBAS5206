-- File			: cost_centres.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the cost_centres table


IF OBJECT_ID('dbo.cost_centres', 'U') IS NOT NULL
	DROP TABLE cost_centres;

CREATE TABLE cost_centres
(
	cost_centre_id INT PRIMARY KEY,
	cost_centre_name VARCHAR(20) NOT NULL
);