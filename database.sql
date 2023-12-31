/*
drop table TABELA_PAGAMENTOS_CONDOMINIO;
drop table TABELA_APARTAMENTO;
drop table TABELA_EDIFICIO;
drop table TABELA_CIDADE;
*/

CREATE TABLE TABELA_CIDADE(
    CODIGO_CIDADE INT NOT NULL IDENTITY PRIMARY KEY,
    NOME_CIDADE VARCHAR(50),
    ESTADO CHAR(2)
);


CREATE TABLE TABELA_EDIFICIO(
    CODIGO_EDIFICIO INT NOT NULL IDENTITY PRIMARY KEY,
    NOME_EDIFICIO VARCHAR(50),
    ANDARES INT,
    CODIGO_CIDADE INT,
    APARTAMENTOS_POR_ANDAR INT,
    FOREIGN KEY (CODIGO_CIDADE) REFERENCES TABELA_CIDADE(CODIGO_CIDADE)
);

CREATE TABLE TABELA_APARTAMENTO(
    CODIGO_APARTAMENTO INT NOT NULL IDENTITY PRIMARY KEY,
    CODIGO_EDIFICIO INT,
    METRAGEM DECIMAL(18, 2),
    ANDAR INT,
    NUMERO_QUARTOS INT,
    FOREIGN KEY (CODIGO_EDIFICIO) REFERENCES TABELA_EDIFICIO(CODIGO_EDIFICIO)
);
             
CREATE TABLE TABELA_PAGAMENTOS_CONDOMINIO(
    CODIGO_CONDOMINIO INT NOT NULL IDENTITY PRIMARY KEY,
    DATA_PAGAMENTO DATETIME,
    CODIGO_APARTAMENTO INT,
    VALOR_PAGAMENTO DECIMAL(18, 2),
    FOREIGN KEY (CODIGO_APARTAMENTO) REFERENCES TABELA_APARTAMENTO(CODIGO_APARTAMENTO)
);

-- insere cidades
INSERT INTO TABELA_CIDADE(NOME_CIDADE, ESTADO)
VALUES ('Campinas', 'SP'),
       ('Rio de Janeiro', 'RJ'),
       ('São Paulo', 'SP'),
       ('Sorocaba', 'SP'),
       ('Jundiaí', 'SP');

-- insere edificios
INSERT INTO TABELA_EDIFICIO(NOME_EDIFICIO, ANDARES, CODIGO_CIDADE, APARTAMENTOS_POR_ANDAR)
VALUES
    ('Edifício Esplanada',  5, 1, 4),
    ('Edifício Vera'     , 10, 2, 3),
    ('Edifício Sônia'    ,  5, 1, 4),
    ('Edifício Tavares'  ,  7, 3, 4),
    ('Edifício Renata'   , 12, 3, 2),
    ('Edifício Tiago'    , 14, 1, 4),
    ('Edifício Sol'      , 15, 1, 2);

-- insere apartamentos
INSERT INTO TABELA_APARTAMENTO(CODIGO_EDIFICIO, METRAGEM, ANDAR, NUMERO_QUARTOS)
VALUES
    (1, 100,  1, 2),
    (2,  98,  3, 3),
    (2, 120,  2, 4),
    (2, 120,  4, 4),
    (3, 100,  1, 3),
    (5,  90,  3, 2),
    (6, 150,  5, 4),
    (7, 200, 14, 3);

-- insere pagamentos condominio
INSERT INTO TABELA_PAGAMENTOS_CONDOMINIO(DATA_PAGAMENTO, CODIGO_APARTAMENTO, VALOR_PAGAMENTO)
VALUES
    ('2011-10-10', 1, 450.00),
    ('2011-11-10', 1, 450.00),
    ('2011-04-10', 8, 450.00),
    ('2011-08-10', 8, 450.00),
    ('2011-06-10', 2, 450.00),
    ('2011-02-10', 3, 450.00),
    ('2012-01-10', 4, 450.00),
    ('2012-03-10', 5, 450.00),
    ('2012-04-10', 7, 450.00);


