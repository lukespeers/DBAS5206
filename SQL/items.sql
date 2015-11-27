-- File			: items.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the items table

IF OBJECT_ID('dbo.items', 'U') IS NOT NULL
	DROP TABLE items;

CREATE TABLE items
(
	item_id INT NOT NULL PRIMARY KEY,
	cost_centre_id INT FOREIGN KEY REFERENCES cost_centres(cost_centre_id),
	item_description VARCHAR(20) NOT NULL,
	item_cost INT
);