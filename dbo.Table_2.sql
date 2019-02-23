CREATE TABLE books
(
	[accNo] INT NOT NULL PRIMARY KEY, 
    [isbn] NCHAR(10) NULL, 
    [name] NCHAR(30) NULL, 
    [author] NCHAR(30) NULL, 
    [publisher] NCHAR(30) NULL, 
    [dId] INT NULL, 
    [borrower] INT NULL, 
    CONSTRAINT [FK_books_ToTable] FOREIGN KEY (dId) REFERENCES department(dep_Id), 
    CONSTRAINT [FK_books_ToTable_1] FOREIGN KEY (borrower) REFERENCES borrowers(brId)
)
