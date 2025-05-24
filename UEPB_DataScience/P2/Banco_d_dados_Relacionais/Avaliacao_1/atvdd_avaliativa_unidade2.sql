create table Cliente(
cpf int primary key,
nome varchar(200) not null,
sexo char(1) not null,
naturalidade varchar(70) not null,
nascimento date not null,
endereco varchar(300) not null,
profissao varchar(100) NOT NULL	
);

insert into Cliente (cpf, nome, sexo, naturalidade, nascimento, endereco, profissao)
values 
	(1, 'Pedro', 'M', 'Brasil', '2004-10-14', 'Av. Senhor dos passos, 650', 'Estudante'),
	(2, 'Maria', 'F', 'Espanha', '1998-12-17', 'Rua Seu mané peixoto, 123', 'Designer'),
    (3, 'Nando Moura', 'M', 'Brasil', '1986-11-17', 'Rua Marfim Pescador, 12', 'Musico'),
    (4, 'Neymar', 'M', 'Canada', '1991-02-13', 'Rua Zé Manco, 13', 'Jogador'),
    (5, 'Pablo Marsal', 'M', 'Brasil', '1997-12-04', 'Av. Armas da Cruz, 23', 'Dancarino');

select * from Cliente;


create table TelefoneCliente(
telefone int unique,
cpfcliente int,
primary key (telefone, cpfcliente),
foreign key (cpfcliente) references cliente(cpf)
);

insert into TelefoneCliente (telefone, cpfcliente)
values
	(98311111, 1),
    (98322222, 2),
    (98333333, 3),
    (98344444, 4),
    (98355555, 5);
    
select * from telefonecliente;
    
    
create table Cidade(
codigo int auto_increment primary key,
nome varchar(100) not null,
populacao int not null,
estado varchar (100) not null
);

insert into cidade(nome, populacao, estado)
values
	('Araruna', 10000, 'PB'),
    ('João Pessoa', '100000', 'PB'),
    ('Fortaleza', '150000', 'CE'),
    ('Salvador', '200000', 'BA'),
    ('Curitiba', '180000', 'PR');
    
select * from cidade;


create table Hotel(
	codigo int auto_increment primary key,
    nome varchar(200) not null,
    endereco varchar(300) not null,
    categoria varchar(50) not null,
    codcidade int not null,
    foreign key(codcidade) references cidade(codigo)
);

insert into hotel(nome, endereco, categoria, codcidade)
values
	('Hotel Calango', 'Rua da alegria, 76', '3 estrelas', 1),
    ('Taverna do Bigode', 'Rua da tristeza, 7', '5 estrelas', 2),
    ('Sonho Bão', 'Rua Del valle, 6', '4 estrelas', 3),
    ('Hotel Iguana', 'Rua da Mata, 86', '4 estrelas', 4),
    ('Hotel Camaleão', 'Rua da Caatinga, 67', '5 estrelas', 5);
    
select * from hotel;


create table quarto(
num_quarto int not null,
codhotel int not null,
tipo_quarto varchar(100) not null,
valor_diaria float not null,
primary key (num_quarto, codhotel),
foreign key (codhotel) references hotel(codigo)
);

insert into quarto (num_quarto, codhotel, tipo_quarto, valor_diaria)
values
	(1, 1, '1 cama casal', 50.00),
	(2, 2, '1 cama casal e 1 solteiro', 70.00),
    (3, 3, '1 cama solteiro e 1 beliche', 65.00),
    (4, 4, '2 cama solteiro e 1 beliche', 75.00),
    (5, 5, '2 cama solteiro', 40.00);
    
select * from quarto;


create table restaurante(
codigo int auto_increment primary key,
nome varchar(200) not null,
tp_categoria varchar(100) not null,
endereco varchar(300) not null,
codhotel int,
codcidade int not null,
foreign key (codhotel) references hotel(codigo),
foreign key (codcidade) references cidade(codigo)
);

insert into restaurante (nome, tp_categoria, endereco, codhotel, codcidade)
values 
	('Balde de Lixo', '2 estrelas', 'Dom pedro I, 76', null, 1),
    ('Ciri Cascudo', '5 estrelas', 'Dom pedro I, 78', 1, 1),
    ('Pizza Mama Mia', '3 estrelas', 'Dom pedro III, 50', null, 2),
    ("Freddy's fazbear pizza", '1 estrelas', 'Av. Manoel Deodato, 78', 3, 3),
    ('Chique chiquinho', '5 estrelas', 'Alpha Ville, 2', null, 5);
    
select * from restaurante;


create table fundador (
codigo int auto_increment primary key,
nome varchar(200) not null,
nascimento date not null,
obito date,
nacionalidade varchar(100) not null,
profissao varchar(100) not null
);

insert into fundador (nome, nascimento, obito, nacionalidade, profissao)
VALUES
    ('Eliza Monteiro', '1945-03-12', '2010-07-22', 'Brasileira', 'Arquiteta'),
    ('Jürgen Steiner', '1938-10-05', '2001-02-14', 'Alemão', 'Historiador'),
    ('Sofia Alvarez', '1967-06-30', NULL, 'Argentina', 'Empresária'),
    ('Takeshi Nakamura', '1952-01-20', '2020-11-10', 'Japonês', 'Curador de arte'),
    ('Amir Nasser', '1975-09-18', NULL, 'Egípcio', 'Engenheiro Civil');
    
select * from fundador;


create table pontoturistico(
codigo int auto_increment primary key,
descricao text not null, 
endereco varchar(300) not null, 
codcidade int not null,
foreign key (codcidade) references cidade(codigo)
);

insert into pontoturistico (descricao, endereco, codcidade)
values 
('Catedral gótica com vitrais coloridos e torre de 70 metros, construída no século XIX.', 'Praça da Fé, 1', 1),
('Museu de História Natural com esqueletos de dinossauros e réplicas de habitats pré-históricos.', 'Av. Paleontologia, 456', 2),
('Antiga igreja barroca transformada em espaço de exposições e apresentações musicais.', 'Rua da Harmonia, 88', 3),
('Casa de shows de jazz e blues localizada num antigo armazém portuário reformado.', 'Cais do Porto, 7', 4), 
('Museu de Arte Moderna com obras interativas e galeria de realidade aumentada.', 'Av. das Artes, nº 999', 5);

select * from pontoturistico;


create table igreja(
codpontoturistico int primary key,
estilo varchar(100) not null,
dt_construcao date not null,
foreign key (codpontoturistico) references pontoturistico(codigo)
);

insert into igreja (codpontoturistico, estilo, dt_construcao)
values
	(1, 'Gótico', '1884-05-17'),
	(3, 'Barroco', '1742-08-21');

select * from igreja;

create table museu(
codpontoturistico int primary key,
num_salas int not null,
dt_fundacao date not null,
foreign key (codpontoturistico) references pontoturistico(codigo)
);

insert into museu (codpontoturistico, num_salas, dt_fundacao)
values
	(2, 12, '1975-03-10'),
	(5, 20, '1962-11-05');
    
select * from museu;


create table casadeshow(
codpontoturistico int primary key,
hora_inicio time not null,
dia_fechamento varchar(70) not null,
codrestaurante int,
foreign key (codpontoturistico) references pontoturistico(codigo),
foreign key (codrestaurante) references restaurante(codigo)
);

insert into casadeshow (codpontoturistico, hora_inicio, dia_fechamento, codrestaurante)
values (4, '20:00:00', 'Segunda', 4);

select * from casadeshow;


create table reserva (
codigo int auto_increment primary key,
cpfcliente int not null,
codhotel int not null,
dt_reserva date not null,
dt_chegada date not null,
dt_saida date not null,
qnt_hospedes int not null,
foreign key (cpfcliente) references cliente(cpf),
foreign key (codhotel) references hotel(codigo)
);

insert into reserva (cpfcliente, codhotel, dt_reserva, dt_chegada, dt_saida, qnt_hospedes)
values
	(1, 1, '2025-05-01', '2025-06-10', '2025-06-15', 2),
	(2, 2, '2025-05-05', '2025-07-01', '2025-07-07', 1),
	(3, 3, '2025-04-20', '2025-05-20', '2025-05-22', 3),
	(4, 4, '2025-03-15', '2025-04-10', '2025-04-12', 2),
	(5, 5, '2025-02-28', '2025-03-05', '2025-03-10', 4);

select * from reserva;


create table passeio (
codigo int auto_increment primary key,
cpfcliente int not null,
codpontoturistico int not null,
dt_passeio date not null,
passeio varchar(200) not null,
pacote_passeio text not null,
foreign key (cpfcliente) references cliente(cpf),
foreign key (codpontoturistico) references pontoturistico(codigo)
);

insert into passeio (cpfcliente, codpontoturistico, dt_passeio, passeio, pacote_passeio)
values
  (1, 1, '2025-06-01', 'Visita à Catedral ', 'Tour guiado pela catedral, incluindo acesso à torre.'),
  (2, 2, '2025-06-05', 'Passeio pelo Museu de História Natural', 'Visita com guia especializado aos esqueletos e habitats pré-históricos.'),
  (3, 3, '2025-06-10', 'Exploração da antiga igreja barroca', 'Entrada para exposições e apresentações musicais.'),
  (4, 4, '2025-06-15', 'Noite de jazz e blues na Casa de Shows do Cais do Porto', 'Ingresso para show com bebida inclusa e acesso VIP.'),
  (5, 5, '2025-06-20', 'Tour pelo Museu de Arte Moderna com realidade aumentada', 'Pacote completo com audioguia e atividades interativas.');
  
select * from passeio;
  
  
create table fundadormuseu(
codfundador int,
codmuseu int,
primary key (codfundador, codmuseu),
foreign key (codfundador) references fundador(codigo),
foreign key (codmuseu) references museu(codpontoturistico)
);
  
insert into fundadormuseu (codfundador, codmuseu)
values 
	(1, 2),
    (2, 2),
    (3, 2),
    (4, 5),
    (5, 5);
    
select * from fundadormuseu;
