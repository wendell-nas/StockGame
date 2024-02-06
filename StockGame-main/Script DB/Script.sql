CREATE DATABASE StockGame;
GO
USE StockGame
GO
CREATE TABLE Departamento (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_DepartamentoId PRIMARY KEY,
    NomeDepartamento VARCHAR(150) NOT NULL
);

CREATE TABLE Cargo (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_CargoId PRIMARY KEY,
    NomeCargo VARCHAR(150) NOT NULL,
    DepartamentoId INT NOT NULL,
    CONSTRAINT FK_DepartamentoId FOREIGN KEY (DepartamentoId) REFERENCES Departamento(Id)
);

CREATE TABLE Telefone (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_TelefoneId PRIMARY KEY,
    Numero VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE Endereco (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EnderecoId PRIMARY KEY,
    Cep VARCHAR(150),
    Estado VARCHAR(50) NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    Bairro VARCHAR(200) NOT NULL,
    Rua VARCHAR(250) NOT NULL,
    Numero VARCHAR(10) NOT NULL
);

CREATE TABLE Colaborador (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_ColaboradorId PRIMARY KEY,
    CargoId INT NOT NULL,
    NomeColaborador VARCHAR(150) NOT NULL,
    Cpf VARCHAR(20) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Senha VARCHAR(255),
    TelefoneId INT NOT NULL,
    EnderecoId INT NOT NULL,
    Status BIT NOT NULL,
    CriadoEm DATETIME DEFAULT GETDATE(),
    CriadoPor VARCHAR(100),
    AlteradoEm DATETIME NOT NULL,
    AlteradoPor VARCHAR(100),
    CONSTRAINT FK_CargoId FOREIGN KEY (CargoId) REFERENCES Cargo(Id),
    CONSTRAINT FK_TelefoneId FOREIGN KEY (TelefoneId) REFERENCES Telefone(Id),
    CONSTRAINT FK_EnderecoId FOREIGN KEY (EnderecoId) REFERENCES Endereco(Id)
);

CREATE TABLE Cliente (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_ClienteId PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Cnpj VARCHAR(50) NOT NULL,
    EnderecoId INT NOT NULL,
    TelefoneId INT NOT NULL,
    Status BIT NOT NULL,
    CriadoEm DATETIME DEFAULT GETDATE(),
    CriadoPor VARCHAR(100),
    AlteradoEm DATETIME NOT NULL,
    AlteradoPor VARCHAR(100),
    CONSTRAINT FK_EnderecoIdCliente FOREIGN KEY (EnderecoId) REFERENCES Endereco(Id),
    CONSTRAINT FK_TelefoneIdCliente FOREIGN KEY (TelefoneId) REFERENCES Telefone(Id)
);

CREATE TABLE Categoria (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_CategoriaId PRIMARY KEY,
    Nome VARCHAR(100) UNIQUE NOT NULL,
    Status BIT NOT NULL,
    CriadoEm DATETIME DEFAULT GETDATE(),
    CriadoPor VARCHAR(100),
    AlteradoEm DATETIME NOT NULL,
    AlteradoPor VARCHAR(100),
);

CREATE TABLE SubCategoria (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_SubCategoriaId PRIMARY KEY,
    Nome VARCHAR(100) UNIQUE NOT NULL,
	CategoriaId INT CONSTRAINT FK_CategoriaId FOREIGN KEY (CategoriaId) REFERENCES Categoria(Id),
    Status BIT NOT NULL,
    CriadoEm DATETIME DEFAULT GETDATE(),
    CriadoPor VARCHAR(100),
    AlteradoEm DATETIME NOT NULL,
    AlteradoPor VARCHAR(100)
);



CREATE TABLE Produto (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_ProdutoId PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    SubCategoriaId INT,
    Preco int NOT NULL,
    Status BIT NOT NULL,
    CriadoEm DATETIME DEFAULT GETDATE(),
    CriadoPor VARCHAR(100),
    AlteradoEm DATETIME NOT NULL,
    AlteradoPor VARCHAR(100),
    CONSTRAINT FK_CategoriaIdProduto FOREIGN KEY (SubCategoriaId) REFERENCES SubCategoria(Id)
);

CREATE TABLE Estoque (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EstoqueId PRIMARY KEY,
    ProdutoId INT,
    Quantidade INT NOT NULL,
    NvMinimo INT NOT NULL,
    CONSTRAINT FK_ProdutoIdEstoque FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);

CREATE TABLE EstoqueEntrada (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EstoqueEntradaId PRIMARY KEY,
    ProdutoId INT,
    Quantidade INT NOT NULL,
    DataEntrada DATETIME NOT NULL,
    CONSTRAINT FK_ProdutoIdEntrada FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);

CREATE TABLE EstoqueSaida (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EstoqueSaidaId PRIMARY KEY,
    ProdutoId INT,
	ClienteId INT,
    Quantidade INT NOT NULL,
    DataSaida DATETIME NOT NULL,
    CONSTRAINT FK_ProdutoIdSaida FOREIGN KEY (ProdutoId) REFERENCES Produto(Id),
	CONSTRAINT FK_ClienteId FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
