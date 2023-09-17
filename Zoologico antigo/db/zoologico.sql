--
-- File generated with SQLiteStudio v3.4.4 on dom set 17 02:05:02 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: animais
CREATE TABLE IF NOT EXISTS animais (
    id_animal INTEGER PRIMARY KEY
                      NOT NULL,
    nome      TEXT    NOT NULL,
    sexo      TEXT    NOT NULL,
    peso      REAL    NOT NULL
);


-- Table: veterinario
CREATE TABLE IF NOT EXISTS veterinario (
    id_veterinario INTEGER PRIMARY KEY
                           NOT NULL,
    nome           TEXT    NOT NULL,
    telefone       NUMERIC NOT NULL
);


-- Table: visitantes
CREATE TABLE IF NOT EXISTS visitantes (
    id_visitante INTEGER PRIMARY KEY
                         NOT NULL
                         UNIQUE,
    nome         TEXT    NOT NULL,
    idade        INTEGER NOT NULL
);


-- Table: zoologico
CREATE TABLE IF NOT EXISTS zoologico (
    id_zoologico INTEGER PRIMARY KEY
                         NOT NULL,
    razao_social TEXT    NOT NULL,
    localizacao  TEXT    NOT NULL
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
