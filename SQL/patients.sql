-- File			: patient.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the patient table

IF OBJECT_ID('dbo.patients', 'U') IS NOT NULL
	DROP TABLE patients;

CREATE TABLE patients
(
	patient_id INT PRIMARY KEY,
	patient_first_name VARCHAR(25) NOT NULL,
	patient_last_name VARCHAR(50) NOT NULL,
	patient_address VARCHAR(75),
	city VARCHAR(75),
	province_id CHAR(2) FOREIGN KEY REFERENCES provinces(province_id),
	postal_code CHAR(6),
	patient_phone_number VARCHAR(15),
	patient_gender VARCHAR(6) NOT NULL,
	patient_health_card_number VARCHAR(12) NOT NULL,
	patient_financial_source VARCHAR(8) NOT NULL
);

INSERT INTO patients(patient_id, patient_first_name, patient_last_name, patient_address, city, province_id, postal_code, patient_phone_number, patient_gender, patient_health_card_number, patient_financial_source) VALUES(
	'00000001',
	'Anthony',
	'Walton',
	'283 Elgin Street East',
	'Oshawa',
	'ON',
	'K9A1A2',
	'2894641484',
	'Male',
	'123456789',
	'ESI'
)