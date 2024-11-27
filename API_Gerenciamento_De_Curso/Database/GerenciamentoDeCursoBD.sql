CREATE DATABASE GerenciamentoDeCursoBD;
USE GerenciamentoDeCursoBD;

CREATE TABLE Curso(
id_curso INT PRIMARY KEY AUTO_INCREMENT,
nome_curso VARCHAR(100) NOT NULL,
descricao VARCHAR(150),
carga_horaria DATETIME NOT NULL,
preco FLOAT NOT NULL
);

ALTER TABLE Curso CHANGE carga_horaria carga_horaria_curso INT NOT NULL;
ALTER TABLE Curso CHANGE descricao descricao_curso VARCHAR(150);
ALTER TABLE Curso CHANGE preco preco_curso FLOAT NOT NULL;

CREATE TABLE Professor(
id_professor INT PRIMARY KEY AUTO_INCREMENT,
nome_professor VARCHAR(150) NOT NULL,
especialidade_professor VARCHAR(100),
cpf_professor VARCHAR(14) NOT NULL,
rg_professor VARCHAR(8) NOT NULL,
email_professor VARCHAR(150) NOT NULL,
data_nascimento DATE NOT NULL,
fk_curso_id_curso INTEGER,
CONSTRAINT fk_curso_id_curso FOREIGN KEY (fk_curso_id_curso) REFERENCES Curso (id_curso)
);

CREATE TABLE Materia(
id_materia INT PRIMARY KEY AUTO_INCREMENT,
nome_materia VARCHAR(150) NOT NULL,
fk_professor_id_professor INTEGER,
CONSTRAINT fk_professor_id_professor FOREIGN KEY (fk_professor_id_professor) REFERENCES Professor (id_professor)
);

CREATE TABLE Aluno(
id_aluno INT PRIMARY KEY AUTO_INCREMENT,
nome_aluno VARCHAR(150) NOT NULL,
cpf_aluno VARCHAR(14) NOT NULL,
rg_aluno VARCHAR(8) NOT NULL,
email_aluno VARCHAR(150) NOT NULL,
data_nascimento DATE NULL, 
fk_id_curso INTEGER,
CONSTRAINT fk_id_curso FOREIGN KEY (fk_id_curso) REFERENCES Curso (id_curso)
);

CREATE TABLE Aluno_Materia(
id_aluno_materia INT PRIMARY KEY AUTO_INCREMENT,
fk_aluno_id_aluno INTEGER,
CONSTRAINT fk_aluno_id_aluno FOREIGN KEY (fk_aluno_id_aluno) REFERENCES Aluno (id_aluno),
fk_materia_id_materia INTEGER,
CONSTRAINT fk_materia_id_materia FOREIGN KEY (fk_materia_id_materia) REFERENCES Materia (id_materia)
);

DESC Aluno_Materia;