CREATE TABLE Pessoa
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Empresa] NVARCHAR(50) NULL, 
    [Telefone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Cliente] BIT NULL, 
    [Ultima Ligação] DATETIME NULL
)
