-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04-Jun-2022 às 04:13
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `scdas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `atendidos`
--

CREATE TABLE `atendidos` (
  `Codigo` int(11) NOT NULL,
  `DataAdmissao` date NOT NULL,
  `DataDesligamento` date NOT NULL,
  `ProgramaIns` varchar(100) NOT NULL,
  `OutroPrograma` varchar(100) DEFAULT NULL,
  `DataCadastro` date NOT NULL,
  `NomeUsuario` varchar(100) NOT NULL,
  `GrauPerdaAud` varchar(100) NOT NULL,
  `DataAudiometria` date NOT NULL,
  `DoencasAss` varchar(100) NOT NULL,
  `DataNascimento` date NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `RG` varchar(20) NOT NULL,
  `CRA` varchar(20) NOT NULL,
  `NomePai` varchar(100) NOT NULL,
  `NomeMae` varchar(100) NOT NULL,
  `NomeResp` varchar(100) NOT NULL,
  `RGResp` varchar(20) NOT NULL,
  `CPFResp` varchar(20) NOT NULL,
  `Endereco` varchar(150) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Celular` varchar(20) NOT NULL,
  `TelRecado` varchar(20) NOT NULL,
  `Escola` varchar(100) NOT NULL,
  `Escolaridade` varchar(50) NOT NULL,
  `Periodo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `atendidos`
--

INSERT INTO `atendidos` (`Codigo`, `DataAdmissao`, `DataDesligamento`, `ProgramaIns`, `OutroPrograma`, `DataCadastro`, `NomeUsuario`, `GrauPerdaAud`, `DataAudiometria`, `DoencasAss`, `DataNascimento`, `CPF`, `RG`, `CRA`, `NomePai`, `NomeMae`, `NomeResp`, `RGResp`, `CPFResp`, `Endereco`, `Telefone`, `Celular`, `TelRecado`, `Escola`, `Escolaridade`, `Periodo`) VALUES
(1, '2022-05-04', '2022-05-21', 'Espaço Auditivo', '1', '2022-04-01', 'Ze', '1', '2022-04-12', '1', '2016-12-27', '111.113.213-21', '32.163.541-1', '1', '1', '1', '1', '13.213.213-2', '132.165.146-51', '1', '(32)1321-3211', '(13)21321-3213', '(32)13213-2131', '1', '1', 'Manhã');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `atendidos`
--
ALTER TABLE `atendidos`
  ADD PRIMARY KEY (`Codigo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `atendidos`
--
ALTER TABLE `atendidos`
  MODIFY `Codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
