EXEC sp_help [BankList];

ALTER DATABASE [DataBaseName]
MODIFY FILE 
(
NAME = [NewName],
SIZE = 100MB
)


DROP TABLE Bank1Accaunt

DROP DATABASE [tempdb]

CREATE TABLE [BankAccaunt]
(
[Id] TINYINT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
[UserName] VARCHAR(20) NOT NULL,
[UserSurName] VARCHAR(20) NOT NULL,
[UserEmail] VARCHAR(20) NOT NULL,
[UserBalance] MONEY,
[BankId] TINYINT FOREIGN KEY REFERENCES [BankList](Id),
[DepositId] TINYINT REFERENCES [DepositList](Id),
[CardCode] VARCHAR(12),
[CardPIN] VARCHAR(4),
[Login] VARCHAR(20) NOT NULL,
[Password] VARCHAR(20) NOT NULL
)
DROP TABLE [BankAccaunt]

INSERT INTO BankAccaunt
VALUES ('David', 'Kroods', null, Null, NULL, NULL, 'Admin', 'Admin')

SELECT [Password] FROM [BankAccaunt]

USE BankSQLServer