CREATE DATABASE sistema;
USE sistema;

CREATE TABLE cliente(
    idcliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50),
    email VARCHAR(200),
    CPF CHAR(11),
    salario DECIMAL(10,2)
) engine= innoDB;

    -- varchar pode variar a quantidade de caracteres (qtde variável)
    -- char não é variável, sempre é 11 (qtde constante
    -- 10 digitos, 2 deles são decimais 999999999