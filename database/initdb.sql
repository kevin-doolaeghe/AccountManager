CREATE DATABASE IF NOT EXISTS db;
USE db;

CREATE TABLE IF NOT EXISTS Records (
    RecordId int NOT NULL AUTO_INCREMENT,
    Description varchar(255),
    Amount float DEFAULT 0.0,
    Status boolean DEFAULT false,
    Date date DEFAULT CURRENT_DATE,
    PRIMARY KEY (RecordId)
);
