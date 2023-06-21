/*
drop table tbl_apartamento;
drop table tbl_edificio;
drop table tbl_cidade;
*/

CREATE TABLE tbl_cidade(
    CODIGO_CIDADE INT NOT NULL IDENTITY PRIMARY KEY,
    NOME_CIDADE VARCHAR(50),
    ESTADO CHAR(2)
);


CREATE TABLE tbl_edificio(
    CODIGO_EDIFICIO INT NOT NULL IDENTITY PRIMARY KEY,
    NOME_EDIFICIO VARCHAR(50),
    ANDARES INT,
    CODIGO_CIDADE INT,
    FOREIGN KEY (CODIGO_CIDADE) REFERENCES tbl_cidade(CODIGO_CIDADE)
);

CREATE TABLE tbl_apartamento(
    CODIGO_APARTAMENTO INT NOT NULL IDENTITY PRIMARY KEY,
    CODIGO_EDIFICIO INT,
    METRAGEM DECIMAL(18, 2),
    ANDAR INT,
    NUMERO_QUARTOS INT,
    FOREIGN KEY (CODIGO_EDIFICIO) REFERENCES tbl_edificio(CODIGO_EDIFICIO)
);

INSERT INTO tbl_cidade(NOME_CIDADE, ESTADO)
VALUES ('Campinas', 'SP'),
       ('Rio de Janeiro', 'RJ'),
       ('São Paulo', 'SP'),
       ('Sorocaba', 'SP'),
       ('Jundiaí', 'SP');