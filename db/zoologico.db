--
-- Arquivo gerado com SQLiteStudio v3.4.4 em sáb set 16 22:25:26 2023
--
-- Codificação de texto usada: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Tabela: animais
CREATE TABLE IF NOT EXISTS animais (
    id_animal INTEGER PRIMARY KEY
                      NOT NULL,
    nome      TEXT    NOT NULL,
    sexo      TEXT    NOT NULL,
    peso      REAL    NOT NULL
);


-- Tabela: veterinario
CREATE TABLE IF NOT EXISTS veterinario (
    id_veterinario INTEGER PRIMARY KEY
                           NOT NULL,
    nome           TEXT    NOT NULL,
    telefone       NUMERIC NOT NULL
);


-- Tabela: visitantes
CREATE TABLE IF NOT EXISTS visitantes (
    id_visitante INTEGER PRIMARY KEY
                         NOT NULL
                         UNIQUE,
    nome         TEXT    NOT NULL,
    idade        INTEGER NOT NULL
);


-- Tabela: zoologico
CREATE TABLE IF NOT EXISTS zoologico (
    id_zoologico INTEGER PRIMARY KEY
                         NOT NULL,
    razao_social TEXT    NOT NULL,
    localizacao  TEXT    NOT NULL
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
