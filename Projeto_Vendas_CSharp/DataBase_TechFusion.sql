create database DataBase_TechFusion;
use DataBase_TechFusion;

create table fornecedor(
	Cod_fornc int primary key auto_increment,
    nome_fornc varchar(120),
    Local_trabalho varchar(120)
);

create table produto(
	Cod_prod int primary key auto_increment,
    Nome_prod varchar(70),
    preco_prod float(10,2),
    foto_prod varchar(200),
    CFK_fornc int,
    constraint FK_fornc foreign key (CFK_fornc) references fornecedor (Cod_fornc)
);

create table perfil(
	Cod_perfil int primary key auto_increment,
    cargo varchar(70)
);

create table usuario(
	Cod_usuario int primary key auto_increment,
	Nome_user varchar(70),
    idade_user int,
    foto_user varchar(200),
    data_Registro date,
    horario_Registro time,
    UserName varchar(70),
    senha varchar(90),
    CFK_prod int,
    CFK_perfil int,
    constraint FK_prod foreign key (CFK_prod) references produto(Cod_prod),
    constraint FK_perfil foreign key (CFK_perfil) references perfil(Cod_perfil)
);

create table Historico_pedidos(
	Cod_hist int primary key auto_increment,
    dia_ped date,
    hora_ped time,
    CFK_prod int,
    CFK_User int,
    constraint FK_user foreign key (CFK_User) references usuario(Cod_usuario),
    constraint FK_prod foreign key (CFK_prod)references produto(Cod_prod)
);

insert into perfil(cargo) values("ADM"), ("Gerente"), ("Cliente"),("Revendedor"),("Técnico");
insert into fornecedor(nome_fornc, Local_trabalho) values ("Adam", "SESI"), ("Gabriel", "SENAI"), ("Rafael", "FIEP");

select * from fornecedor;
select * from produto;
select * from perfil;
select * from usuario;
-- select * from

