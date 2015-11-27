-- File			: invoices.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the invoices table

IF OBJECT_ID('dbo.invoices', 'U') IS NOT NULL
	DROP TABLE invoices;

CREATE TABLE invoices
(
	invoice_id VARCHAR(8) PRIMARY KEY,
	admission_id VARCHAR(8) REFERENCES patient_admissions(admission_id),
	transaction_id VARCHAR(8) REFERENCES transactions(transaction_id),
	invoice_date DATE NOT NULL
);