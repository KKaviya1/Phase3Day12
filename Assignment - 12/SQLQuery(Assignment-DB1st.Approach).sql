create database postcomment
use postcomment

CREATE TABLE Post (
    PId INT PRIMARY KEY,
    Title NVARCHAR(255),
    Content NVARCHAR(MAX),
    PublicationDate DATETIME,
    Author NVARCHAR(100)
)

CREATE TABLE Comment (
    Id INT PRIMARY KEY,
    Content NVARCHAR(MAX),
    PublicationDate DATETIME,
    PId int foreign key references Post
)
select *from Post
select *from Comment