INSERT INTO Departamento (NomeDepartamento)
VALUES ('Vendas'), ('Marketing'), ('RH'), ('TI'), ('Financeiro');

INSERT INTO Cargo (NomeCargo, DepartamentoId)
VALUES ('Vendedor', 1), ('Gerente de Vendas', 1), ('Analista de Marketing', 2), ('Analista de RH', 3), ('Desenvolvedor', 4);

INSERT INTO Telefone (Numero)
VALUES ('123-456-7890'), ('234-567-8901'), ('345-678-9012'), ('456-789-0123'), ('567-890-1234');

INSERT INTO Endereco (Cep, Estado, Cidade, Bairro, Rua, Numero)
VALUES ('12345-678', 'SP', 'São Paulo', 'Centro', 'Avenida Paulista', '123'), 
       ('54321-876', 'RJ', 'Rio de Janeiro', 'Copacabana', 'Rua Nossa Senhora', '456'), 
       ('67890-123', 'MG', 'Belo Horizonte', 'Savassi', 'Rua da Bahia', '789'), 
       ('98765-432', 'PR', 'Curitiba', 'Batel', 'Alameda Dr. Carlos de Carvalho', '101'), 
       ('13579-246', 'RS', 'Porto Alegre', 'Moinhos de Vento', 'Rua Padre Chagas', '202');

INSERT INTO Categoria (Nome, Status, CriadoEm, CriadoPor, AlteradoEm, AlteradoPor)
VALUES 
    ('Smartphones', 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
    ('Roupas', 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
    ('Alimentos Não Perecíveis', 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
    ('Móveis de Sala', 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
    ('Equipamentos Esportivos', 1, GETDATE(), 'Admin', GETDATE(), 'Admin');

INSERT INTO SubCategoria (Nome, Status,CategoriaId, CriadoEm, CriadoPor, AlteradoEm, AlteradoPor)
VALUES ('Eletrônicos', 1, 1,GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Moda', 1, 2,GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Alimentos', 1, 3,GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Móveis', 1, 4,GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Esportes', 1, 5,GETDATE(), 'Admin', GETDATE(), 'Admin');


INSERT INTO Produto (Nome, SubCategoriaId, Preco, Status, CriadoEm, CriadoPor, AlteradoEm, AlteradoPor)
VALUES ('iPhone 13', 1, 2000, 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Vestido Floral', 2, 100, 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Arroz', 3, 20, 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Sofá de Couro', 4, 800, 1, GETDATE(), 'Admin', GETDATE(), 'Admin'),
       ('Bola de Futebol', 5, 50, 1, GETDATE(), 'Admin', GETDATE(), 'Admin');

INSERT INTO Estoque (ProdutoId, Quantidade, NvMinimo)
VALUES (1, 100,20),
       (2, 50,10),
       (3, 200,30),
       (4, 30,5),
       (5, 80,15);
