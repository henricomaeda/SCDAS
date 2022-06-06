insert into atendidos (
    Codigo,
    DataAdmissao,
    DataDesligamento,
    ProgramaIns,
    OutroPrograma,
    DataCadastro,
    NomeUsuario,
    GrauPerdaAud,
    DataAudiometria,
    DoencasAss,
    DataNascimento,
    CPF,
    RG,
    CRA,
    NomePai,
    NomeMae,
    NomeResp,
    RGResp,
    CPFResp,
    Endereco,
    Telefone,
    Celular,
    TelRecado,
    Escola,
    Escolaridade,
    Periodo
) values (
    null,
    '2021-06-12',
    '2022-04-11',
    'Programa Social',
    'xxx',
    '2021-06-01',
    'Vitor Silva Costa',
    'leve',
    '2022-04-01',
    'nenhuma',
    '2005-03-03',
    '777.897.458-78',
    '45.987.458-7',
    '784512',
    'Jose Silva Costa',
    'Joana Silva Costa',
    'xxx',
    '34.557.438-7',
    '897.797.228-78',
    'Rua das Flores 44 Campo Lindo',
    '(12)3921-3711',
    '(12)9921-4511',
    '(12)3987-3411',
    'Escola Pedro Maza',
    'Ensino Medio',
    'Tarde'
);

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
	'Adriano',
	'TI',
	'12988156355',
	'Desenvolvedor',
	'admin',
	'111111',
	'adriano@etec.sp.gov.br',
	'Administrador',
	'31684712831'
),
(
	null,
	'Felipe',
	'TI',
	'1298897745',
	'Desenvolvedor',
	'admin',
	'222222',
	'felipe@etec.sp.gov.br',
	'Administrador',
	'51712884798'
),
(
	null,
	'Aparecida',
	'Recepcao',
	'1298774488',
	'Recepcao',
	'aparecida',
	'333333',
	'aparecida@aadas.sp.gov.br',
	'Funcionario',
	'71718884798'
),
(
	null,
	'Aline',
	'RH',
	'1298874512',
	'RH',
	'aline',
	'444444',
	'aline@aadas.sp.gov.br',
	'Funcionario',
	'44710084790'
),


 INSERT INTO atendidos( Codigo, DataAdmissao, DataDesligamento, ProgramaIns, OutroPrograma, DataCadastro, NomeUsuario, GrauPerdaAud, DataAudiometria, DoencasAss, DataNascimento, CPF, RG, CRA, NomePai, NomeMae, NomeResp, RGResp, CPFResp, Endereco, Telefone, Celular, TelRecado, Escola, Escolaridade, Periodo ) 
 
 VALUES( NULL, '2020-07-22', '2022-05-18', 'Librando Historias', 'xxx', '2020-06-13', 'Clara Martins Fontes', 'moderada', '2022-05-01', 'nenhuma', '2004-04-03', '117.127.444-98', '12.747.338-7', '178613', 'Paulo Martins Fontes', 'Lucia Martins Fontes', 'xxx', '17.417.008-8', '117.117.221-04', 'Rua dos Avioes 6547 Campo Lindo', '(12)3999-1511', '(12)9781-3311', '(00)0000-0000', 'Escola Estevam Ferri', 'Ensino Medio', 'Tarde' ), 
 ( NULL, '2021-07-22', '2022-04-11', 'Programa Social', 'xxx', '2021-06-01', 'Renato Conceicao das Neves', 'severa', '2022-04-15', 'nenhuma', '2005-03-08', '478.321.787-78', '11.987.058-7', '369147', 'Marcio Conceicao das Neves', 'Sara Conceicao das Neves', 'xxx', '88.147.438-7', '003.080.707-78', 'Rua das Borboletas 777 Vila Industrial', '(12)3921-4771', '(12)9878-5511', '(12)3941-7703', 'Escola Alceu ', 'Ensino Fundamental', 'Tarde' ),
/*06-06-2022*/
( NULL, '2021-07-14', '2022-05-21', 'Programa Social', 'xxx', '2021-07-15', 'Marcelo Freitas Soares', 'leve', '2022-04-16', 'nenhuma', '2004-02-08', '458.451.787-78', '45.457.058-8', '454557', 'Jose Freitas Soares', 'Marta Freitas Soares', 'xxx', '45.154.438-0', '453.080.457-70', 'Rua Padre Jose Filho 5215 Pq das Americas', '(12)3987-4771', '(12)9118-0211', '(00)0000-0000', 'Escola Olga Franco ', 'Ensino Fundamental', 'Tarde' ),
( NULL, '2021-07-15', '2022-05-04', 'Librando Historias', 'xxx', '2021-08-22', 'Felipe Lima Santos', 'moderada', '2022-04-28', 'nenhuma', '2004-02-21', '118.151.087-08', '15.987.068-8', '000989', 'Marcio Lima Santos', 'Silvia Lima Santos', 'xxx', '05.964.400-0', '223.220.457-70', 'Av Juscelino Kubistcheck 5005 Monte Castelo', '(12)3887-0071', '(12)9998-0361', '(00)0000-0000', 'Escola Estevam Ferri ', 'Ensino Medio', 'Manha' ),
( NULL, '2021-01-14', '2022-04-21', 'Espaco Auditivo', 'xxx', '2021-11-15', 'Roseli Cunha Flores', 'leve', '2022-09-22', 'nenhuma', '2003-10-08', '808.801.787-78', '19.197.058-9', '165498', 'Jose Cunha Flores', 'Josefa Cunha Flores', 'xxx', '77.754.438-0', '005.080.457-70', 'Rua 45 100 Jd Sao Jose', '(12)3944-0871', '(12)9989-6911', '(00)0000-0000', 'Escola Benedito Filho', 'Ensino Medio', 'Manha' ),
( NULL, '2021-03-03', '2022-05-04', 'Librando Historias', 'xxx', '2021-01-22', 'Lucas Ribeiro Marques', 'severa', '2022-04-27', 'nenhuma', '2001-08-21', '948.871.087-21', '88.987.047-0', '987478', 'Silvio Ribeiro Marques', 'Marcia Ribeiro Marques', 'xxx', '77.894.700-0', '693.960.457-80', 'Av Juscelino Kubistcheck 4785 Monte Castelo', '(12)3941-2671', '(12)9858-0021', '(00)0000-0000', 'Escola Estevam Ferri ', 'Ensino Medio', 'Tarde' ),
( NULL, '2020-11-24', '2022-04-30', 'Programa Social', 'xxx', '202-10-15', 'Joao Esteves Souza', 'moderada', '2022-04-22', 'nenhuma', '2009-11-08', '498.221.547-28', '29.857.049-9', '195144', 'Fabio Esteves Souza', 'Fabiana Esteves Souza', 'xxx', '07.755.408-7', '955.740.587-20', 'Rua dos Miosotis 36 Jd Motorama', '(12)3933-8201', '(12)9922-5511', '(12)3950-8500', 'Escola Francisco Flor', 'Ensino Medio', 'Manha' ),
( NULL, '2021-07-07', '2022-05-28', 'Librando Historias', 'xxx', '2021-05-12', 'Agnaldo Nunes Gomes', 'severa', '2022-04-17', 'nenhuma', '2004-03-23', '508.941.804-11', '74.185.807-2', '14739', 'Jorge Nunes Gomes', 'Geni Nunes Gomes', 'xxx', '82.195.195-0', '752.487.457-50', 'Rua Aviao Alvear 488 Jd Souto', '(12)3989-5541', '(12)9951-7321', '(12)3992-1500', 'Escola Marioto', 'Ensino Medio', 'Manha' );




