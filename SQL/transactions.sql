-- File			: transactions.sql
-- Author		: Anthony Walton, Daniel Wicks, Gavin Shelley, Luke Speers, Mark Subit, Rob Budd
-- Date			: November 24, 2015
-- Description	: SQL file to create the transactions table

IF OBJECT_ID('dbo.transactions', 'U') IS NOT NULL
	DROP TABLE transactions;

CREATE TABLE transactions
(
	transaction_id VARCHAR(8) PRIMARY KEY,
	patient_id INT REFERENCES patients(patient_id),
	item_id INT REFERENCES items(item_id),
	date_charged DATE,
	patient_financial_source VARCHAR(8)
);