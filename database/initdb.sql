CREATE DATABASE IF NOT EXISTS db;
USE db;

CREATE TABLE IF NOT EXISTS Users (
    UserId int NOT NULL AUTO_INCREMENT,
    Name varchar(100),
    Email varchar(100),
    Password varchar(100),
    PRIMARY KEY (UserId)
);

CREATE TABLE IF NOT EXISTS Accounts (
    AccountId int NOT NULL AUTO_INCREMENT,
    Name varchar(100),
    UserId int,
    PRIMARY KEY (AccountId),
    FOREIGN KEY (UserId) REFERENCES Users (UserId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS RecordTypes (
    RecordTypeId int NOT NULL AUTO_INCREMENT,
    Name varchar(100),
    Icon char(1),
    Color varchar(20),
    PRIMARY KEY (RecordTypeId)
);

CREATE TABLE IF NOT EXISTS Records (
    RecordId int NOT NULL AUTO_INCREMENT,
    Description varchar(255),
    Amount float DEFAULT 0.0,
    Status boolean DEFAULT false,
    Date date DEFAULT CURRENT_DATE,
    AccountId int,
    RecordTypeId int,
    PRIMARY KEY (RecordId),
    FOREIGN KEY (AccountId) REFERENCES Accounts (AccountId) ON DELETE CASCADE,
    FOREIGN KEY (RecordTypeId) REFERENCES RecordTypes (RecordTypeId)
);
