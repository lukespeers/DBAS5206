-- File			: patient_admissions.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the patient_admissions table

IF OBJECT_ID('dbo.patient_admissions', 'U') IS NOT NULL
	DROP TABLE patient_admissions;

CREATE TABLE patient_admissions
(
	admission_id VARCHAR(8) PRIMARY KEY,
	patient_id INT REFERENCES patients(patient_id),
	location_id VARCHAR(8) REFERENCES locations(location_id),
	physician_id INT REFERENCES physicians(physician_id),
	date_admitted DATE NOT NULL,
	discharge_date DATE
);