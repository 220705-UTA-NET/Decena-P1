--DROP TABLE MedicinesDb;

CREATE TABLE MedicinesDb
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR (255) NOT NULL,
    Description NVARCHAR (32) NOT NULL,
    Amount NVARCHAR (255) NOT NULL,
    Tablets NVARCHAR (255) NOT NULL,   
    Price NVARCHAR (255) NOT NULL

);

SELECT * FROM MedicinesDb

INSERT INTO MedicinesDb (Name, Description, Amount, Tablets, Price)
VALUES
('Atorvastatin', 'Used for High Cholesterol', '40mg', '60', '$9.38'),
('Omeprazole', 'Used for Heartburn', '40mg', '10', '$5.00'),
('Lisinopril', 'Used for Hypertension', '20mg', '30', '$5.65'),
('Azithromycin', 'Antiobiotics', '250mg', '6', '$6.82'),
('Losartan', 'Used for High Blood Pressure', '50mg', '100', '$11.96');

SELECT Id, Name, Description, Amount, Tablets, Price FROM MedicinesDb;