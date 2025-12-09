create database red_riders_bd;
use red_riders_bd;

-- TABELA RESTAURANTE	
CREATE TABLE restaurante (
    id_restaurante INT AUTO_INCREMENT PRIMARY KEY,
    nome_fantasia_restaurante VARCHAR(150) NOT NULL,
    razao_social_restaurante VARCHAR(200) NOT NULL,
    imagem_restaurante VARCHAR(255),
    cnpj_restaurante CHAR(14) NOT NULL,
    cep_restaurante CHAR(8) NOT NULL,
    rua_restaurante VARCHAR(150) NOT NULL,
    numero_restaurante VARCHAR(20) NOT NULL,
    complemento_restaurante VARCHAR(100),
    bairro_restaurante VARCHAR(100) NOT NULL,
    cidade_restaurante VARCHAR(100) NOT NULL,
    estado_restaurante CHAR(2) NOT NULL,
    ponto_de_referencia_restaurante VARCHAR(200),
    nome_do_dono_restaurante VARCHAR(150) NOT NULL,
    cpf_do_dono_restaurante CHAR(11) NOT NULL
);