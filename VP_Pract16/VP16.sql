
USE master;
GO


CREATE DATABASE Students;
GO


USE Students;
GO


CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Birthdate DATE NOT NULL,
    Phone VARCHAR(20) NOT NULL CHECK (Phone LIKE '+7(%)%-%-%') 
);
GO


CREATE TABLE Journal (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    Date DATE NOT NULL,
    Subject VARCHAR(100) NOT NULL,
    Presence BIT NOT NULL,
    CONSTRAINT FK_Journal_Student FOREIGN KEY (StudentId) REFERENCES Student(Id)
);
GO