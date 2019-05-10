CREATE DATABASE DB_EXEMPLO_TEC43
GO

USE [DB_EXEMPLO_TEC43]
GO

CREATE TABLE Pessoas (
	Codigo int identity primary key,
	Nome nvarchar(100),
	Estado nchar(2),
	Cidade nvarchar(50),
	Fone nvarchar(15),
	Numero nvarchar(10),
	Endereco nvarchar(100),
)

/*  Depois vocês irão criar e executar o script para as Tabelas
	Produtos e Categorias   */
