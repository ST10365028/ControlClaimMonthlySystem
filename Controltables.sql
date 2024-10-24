CREATE TABLE Lecturer (
    LecturerId INT IDENTITY(1,1) PRIMARY KEY,
    LecturerName VARCHAR(100) NOT NULL,
    LecturerSurname VARCHAR(100) NOT NULL,
    EmployeeNumber VARCHAR(50) NOT NULL,
    ContactDetails VARCHAR(255)
);
GO

CREATE TABLE Module (
    ModuleId INT IDENTITY(1,1) PRIMARY KEY,
    ModuleName VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Claim (
    ClaimId INT IDENTITY(1,1) PRIMARY KEY,
    LecturerId INT,
    ModuleId INT,
    Amount DECIMAL(10, 2) NOT NULL,
    Description TEXT,
    ClaimStatus VARCHAR(50) DEFAULT 'Pending',
    SubmissionDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (LecturerId) REFERENCES Lecturer(LecturerId),
    FOREIGN KEY (ModuleId) REFERENCES Module(ModuleId)
);
GO

-- Insert sample lecturers
INSERT INTO Lecturer (LecturerName, LecturerSurname, EmployeeNumber, ContactDetails)
VALUES 
('John', 'Doe', 'EMP123', 'johndoe@example.com'),
('Jane', 'Smith', 'EMP456', 'janesmith@example.com');
GO

-- Insert sample modules
INSERT INTO Module (ModuleName)
VALUES 
('Prog'),
('IPMA'),
('BUIS'),
('HCIN');
GO

-- Insert sample claims
INSERT INTO Claim (LecturerId, ModuleId, Amount, Description, ClaimStatus)
VALUES 
(1, 1, 1500.00, 'Claim for lecture hours', 'Pending'),
(2, 2, 2000.00, 'Claim for project management workshop', 'Approved');
GO
