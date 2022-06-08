create database if not exists scdas;
use scdas;

drop table if exists funcionarios;
create table funcionarios (
	Codigo					int  				auto_increment,
	Nome					varchar(100)		not null,
	ProgramaProjeto			varchar(100)		not null,
	Celular					varchar(20)			not null,
	Cargo					varchar(100)		not null,
	Login					varchar(100)		not null,
	Senha					varchar(25)			not null,
	Email					varchar(50)			not null,
	tipo					varchar(20)			not null,
	cpf						varchar(20)			not null,
primary key	(Codigo));

insert into funcionarios (
	Codigo,
	Nome,
	ProgramaProjeto,
	Celular,
	Cargo,
	Login,
	Senha,
	Email,
	tipo,
	cpf
) values (
	null,
	'Henrico',
	'TI',
	'12981521877',
	'Desenvolvedor',
	'admin',
	'000000',
	'henrico.maeda@etec.sp.gov.br',
	'Administrador',
	'12345678900'
);

drop table if exists atendidos;
create table atendidos (
	Codigo					int    				auto_increment,
	DataAdmissao			date				not null,
	DataDesligamento		date				not null,
	ProgramaIns				varchar(100)		not null,
	OutroPrograma			varchar(100)			null,
	DataCadastro			date				not null,
	NomeUsuario				varchar(100)		not null,
	GrauPerdaAud			varchar(100)		not null,
	DataAudiometria			date				not null,
	DoencasAss				varchar(100)		not null,
	DataNascimento			date				not null,
	CPF						varchar(20)			not null,
	RG						varchar(20)			not null,
	CRA						varchar(20)			not null,
	NomePai					varchar(100)		not null,
	NomeMae					varchar(100)		not null,
	NomeResp				varchar(100)			null,
	RGResp					varchar(20)			not null,
	CPFResp					varchar(20)			not null,
	Endereco				varchar(150)		not null,
	Telefone				varchar(20)			not null,
	Celular					varchar(20)			not null,
	TelRecado				varchar(20)			not null,
	Escola					varchar(100)		not null,
	Escolaridade			varchar(50)			not null,
	Periodo					varchar(50)			not null,
primary key	(Codigo));