-- File			: provinces.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the provinces table

IF OBJECT_ID('dbo.provinces', 'U') IS NOT NULL
	DROP TABLE provinces;

CREATE TABLE provinces(
	province_id CHAR(2) NOT NULL PRIMARY KEY,
	province VARCHAR(25)
);

INSERT INTO provinces (province_id, province) VALUES ('AB', 'Alberta');
INSERT INTO provinces (province_id, province) VALUES ('BC', 'British Columbia');
INSERT INTO provinces (province_id, province) VALUES ('MB', 'Manitoba');
INSERT INTO provinces (province_id, province) VALUES ('NB', 'New Brunswick');
INSERT INTO provinces (province_id, province) VALUES ('NF', 'Newfoundland and Labrador');
INSERT INTO provinces (province_id, province) VALUES ('NS', 'Nova Scotia');
INSERT INTO provinces (province_id, province) VALUES ('NT', 'Northwest Territories');
INSERT INTO provinces (province_id, province) VALUES ('NU', 'Nunavut');
INSERT INTO provinces (province_id, province) VALUES ('ON', 'Ontario');
INSERT INTO provinces (province_id, province) VALUES ('PE', 'Prince Edward Island');
INSERT INTO provinces (province_id, province) VALUES ('PQ', 'Quebec');
INSERT INTO provinces (province_id, province) VALUES ('SK', 'Saskatchewan');
INSERT INTO provinces (province_id, province) VALUES ('YT', 'Yukon Territories');