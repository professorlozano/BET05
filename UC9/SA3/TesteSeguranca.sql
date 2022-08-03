-- cria o banco de dados
CREATE DATABASE TesteSegurancaBE5;

USE TesteSegurancaBE5;

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
)

INSERT INTO Usuarios VALUES ('email@email.com', 1234)

SELECT * FROM Usuarios

SELECT Email, HASHBYTES('MD2', Senha) FROM Usuarios;

SELECT Id, Email, HASHBYTES('MD2', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('MD2', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 3
SELECT Id, Email, HASHBYTES('MD4', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('MD5', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('SHA', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('SHA1', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('SHA2_256', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1
SELECT Id, Email, HASHBYTES('SHA2_512', Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1