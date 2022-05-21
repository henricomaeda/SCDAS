create database if not exists `scdas`;
use `scdas`;

drop table if exists `scdas`.`atendidos`;
drop table if exists `scdas`.`ruas`;
drop table if exists `scdas`.`bairros`;
drop table if exists `scdas`.`cidades`;
drop table if exists `scdas`.`estados`;
drop table if exists `scdas`.`dados_pessoais`;
drop table if exists `scdas`.`responsaveis`;
drop table if exists `scdas`.`contatos`;
drop table if exists `scdas`.`funcionarios`;
drop table if exists `scdas`.`usuarios`;

create table `scdas`.`usuarios` (
	`usu_login` varchar(100) not null,
	`usu_senha` varchar(25) not null,
	`usu_tipo` varchar(20) not null,
	primary key (`usu_login`)
) ENGINE = InnoDB;

create table `scdas`.`funcionarios` (
	`fun_codigo` int not null auto_increment,
	`fun_nome` varchar(100) not null,
	`fun_programaprojeto` varchar(100) not null,
	`fun_celular` varchar(20) not null,
	`fun_cargo` varchar(100) not null,
	`fun_email` varchar(50) not null,
	`fun_cpf` varchar(20) not null,
	`usu_login` varchar(100) not null,
	primary key (`fun_codigo`),
	index `fk_funcionarios_usuarios_idx` (`usu_login` asc),
	constraint `fk_funcionarios_usuarios`
		foreign key (`usu_login`)
		references `scdas`.`usuarios` (`usu_login`)
		on delete no action
		on update no action
) ENGINE = InnoDB;

create table `scdas`.`contatos` (
	`con_codigo` int not null auto_increment,
	`con_telefone` varchar(20) not null,
	`con_celular` varchar(20) not null,
	`con_telefonerecado` varchar(20) not null,
	primary key (`con_codigo`)
) ENGINE = InnoDB;

create table `scdas`.`responsaveis` (
	`res_cpf` varchar(20) not null,
	`res_rg` varchar(20) not null,
	`res_nome` varchar(100) not null,
	primary key (`res_cpf`)
) ENGINE = InnoDB;

create table `scdas`.`dados_pessoais` (
	`dad_cpf` varchar(20) not null,
	`dad_rg` varchar(20) not null,
	`dad_nome` varchar(100) not null,
	`dad_nomepai` varchar(100) not null,
	`dad_nomemae` varchar(100) not null,
	`res_cpf` varchar(20) not null,
	index `fk_dados_pessoais_responsaveis1_idx` (`res_cpf` asc),
	primary key (`dad_cpf`),
	constraint `fk_dados_pessoais_responsaveis1`
		foreign key (`res_cpf`)
		references `scdas`.`responsaveis` (`res_cpf`)
		on delete no action
		on update no action
) ENGINE = InnoDB;

create table `scdas`.`estados` (
	`est_id` varchar(2) not null,
	`est_nome` varchar(100) not null,
	primary key (`est_id`)
) ENGINE = InnoDB;

create table `scdas`.`cidades` (
	`cid_codigo` int not null auto_increment,
	`cid_nome` varchar(100) not null,
	`est_id` varchar(2) not null,
	primary key (`cid_codigo`),
	index `fk_cidades_estados1_idx` (`est_id` asc),
	constraint `fk_cidades_estados1`
		foreign key (`est_id`)
		references `scdas`.`estados` (`est_id`)
		on delete no action
		on update no action
) ENGINE = InnoDB;

create table `scdas`.`bairros` (
	`bai_codigo` int not null auto_increment,
	`bai_nome` varchar(100) not null,
	`cid_codigo` int not null,
	primary key (`bai_codigo`),
	index `fk_bairros_cidades1_idx` (`cid_codigo` asc),
	constraint `fk_bairros_cidades1`
		foreign key (`cid_codigo`)
		references `scdas`.`cidades` (`cid_codigo`)
		on delete no action
		on update no action
) ENGINE = InnoDB;

create table `scdas`.`ruas` (
	`rua_numero` int not null,
	`rua_nome` varchar(100) not null,
	`bai_codigo` int not null,
	primary key (`rua_numero`),
	index `fk_ruas_bairros1_idx` (`bai_codigo` asc),
	constraint `fk_ruas_bairros1`
		foreign key (`bai_codigo`)
		references `scdas`.`bairros` (`bai_codigo`)
		on delete no action
		on update no action
) ENGINE = InnoDB;

create table `scdas`.`atendidos` (
	`ate_codigo` int not null auto_increment,
	`ate_dataadmissao` date not null,
	`ate_datadesligamento` date not null,
	`ate_programainserido` varchar(100) not null,
	`ate_outroprograma` varchar(100) binary null,
	`ate_datacadastro` date not null,
	`ate_grauperdaauditiva` varchar(100) not null,
	`ate_dataaudiometria` date not null,
	`ate_doencasassociadas` varchar(100) not null,
	`ate_datanascimento` date not null,
	`ate_cra` varchar(20) not null,
	`ate_escola` varchar(100) not null,
	`ate_escolaridade` varchar(50) not null,
	`ate_periodo` varchar(50) not null,
	`con_codigo` int not null,
	`dad_cpf` varchar(20) not null,
	`rua_numero` int not null,
	primary key (`ate_codigo`),
	index `fk_atendidos_contatos1_idx` (`con_codigo` asc),
	index `fk_atendidos_dados_pessoais1_idx` (`dad_cpf` asc),
	index `fk_atendidos_ruas1_idx` (`rua_numero` asc),
	constraint `fk_atendidos_contatos1`
		foreign key (`con_codigo`)
		references `scdas`.`contatos` (`con_codigo`)
		on delete no action
		on update no action,
	constraint `fk_atendidos_dados_pessoais1`
		foreign key (`dad_cpf`)
		references `scdas`.`dados_pessoais` (`dad_cpf`)
		on delete no action
		on update no action,
	constraint `fk_atendidos_ruas1`
		foreign key (`rua_numero`)
		references `scdas`.`ruas` (`rua_numero`)
		on delete no action
		on update no action
) ENGINE = InnoDB;