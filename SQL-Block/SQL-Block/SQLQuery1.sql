CREATE DATABASE Wintris_Data;
USE Wintris_Data;
CREATE TABLE username(
usernameID INT IDENTITY (1,1) PRIMARY KEY,
username TEXT NOT NULL
)
CREATE TABLE score(
scoreID INT IDENTITY (1,1) PRIMARY KEY,
score INT NOT NULL
)
CREATE TABLE username2Data(
usernameID INT NOT NULL,
scoreID INT,
FOREIGN KEY(usernameID) REFERENCES username(usernameID),
FOREIGN KEY(scoreID) REFERENCES score(scoreID)
)