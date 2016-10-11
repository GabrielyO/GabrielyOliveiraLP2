-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para caderno
CREATE DATABASE IF NOT EXISTS `caderno` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `caderno`;


-- Copiando estrutura para tabela caderno.aluno
CREATE TABLE IF NOT EXISTS `aluno` (
  `ID` int(10) unsigned NOT NULL,
  `NOMECOMPLETO` varchar(100) NOT NULL,
  `LOGIN` varchar(10) NOT NULL,
  `SENHA` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.aluno: ~24 rows (aproximadamente)
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` (`ID`, `NOMECOMPLETO`, `LOGIN`, `SENHA`) VALUES
	(1, 'André Lucas', 'andre', 'andre'),
	(2, 'Bruna Figueiredo de Jesus', 'bruninha', 'bruna'),
	(3, 'Carlos Linhares', 'carlos', 'carlos'),
	(4, 'Crhistian', 'crhistian', 'crhistian'),
	(5, 'Davi Dias', 'dias', 'dias'),
	(6, 'Davi Santos', 'santos', 'santos'),
	(7, 'Dhiogo', 'dhiogo', 'dhiogo'),
	(8, 'Eduardo', 'eduardo', 'eduardo'),
	(9, 'Felipe Reis', 'felipe', 'felipe'),
	(10, 'Gabriely de oliveira Nascimento', 'gabybicho', 'gabriely'),
	(11, 'Leonardo', 'leonardo', 'leonardo'),
	(12, 'Lucas Alves', 'alves', 'alves'),
	(13, 'Lucas Barcelos Barros', 'barcelos', 'barcelos'),
	(14, 'Lucas Bulhões Lopes', 'bulhoes', 'lopes'),
	(15, 'Lucas Reis', 'reis', 'reis'),
	(16, 'Marcos Paulo', 'marcos', 'marcos'),
	(17, 'Marcus Vinicius', 'marcus', 'marcus'),
	(18, 'Nathalia', 'nathalia', 'nathalia'),
	(19, 'Paula Vasconcelos Dutra', 'paulinha', 'paula'),
	(20, 'Pedro Henrique', 'pedro', 'pedro'),
	(21, 'Rodrigo Jucá', 'rodrigo', 'rodrigo'),
	(22, 'Thamires Mendes de Lima', 'mlthami', 'thamires'),
	(23, 'Thiago Nascimento Maia', 'thiagomaia', 'thiago'),
	(24, 'Ursula Rosa', 'ursula', 'ursula');
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;


-- Copiando estrutura para tabela caderno.materia
CREATE TABLE IF NOT EXISTS `materia` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NOME` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.materia: ~14 rows (aproximadamente)
/*!40000 ALTER TABLE `materia` DISABLE KEYS */;
INSERT INTO `materia` (`ID`, `NOME`) VALUES
	(1, 'MATEMÁTICA'),
	(2, 'INGLÊS'),
	(3, 'PORTUGUÊS'),
	(4, 'FÍSICA'),
	(5, 'QUÍMICA'),
	(6, 'SOCIOLOGIA'),
	(7, 'FILOSOFIA'),
	(8, 'BIOLOGIA'),
	(9, 'ED_FÍSICA'),
	(10, 'LP2'),
	(11, 'BD'),
	(12, 'HISTÓRIA'),
	(13, 'GEOGRAFIA'),
	(14, 'DESENHO');
/*!40000 ALTER TABLE `materia` ENABLE KEYS */;


-- Copiando estrutura para tabela caderno.monitoria
CREATE TABLE IF NOT EXISTS `monitoria` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ID_MATERIA` int(10) unsigned NOT NULL,
  `ID_ALUNO` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID_ALUNO` (`ID_ALUNO`),
  KEY `ID_MATÉRIA` (`ID_MATERIA`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.monitoria: ~28 rows (aproximadamente)
/*!40000 ALTER TABLE `monitoria` DISABLE KEYS */;
INSERT INTO `monitoria` (`ID`, `ID_MATERIA`, `ID_ALUNO`) VALUES
	(1, 1, 2),
	(2, 2, 2),
	(3, 3, 2),
	(4, 4, 2),
	(5, 5, 2),
	(6, 6, 2),
	(7, 7, 2),
	(8, 8, 2),
	(9, 9, 2),
	(10, 10, 2),
	(11, 11, 2),
	(12, 12, 2),
	(13, 13, 2),
	(14, 14, 2),
	(15, 1, 19),
	(16, 2, 19),
	(17, 3, 19),
	(18, 4, 19),
	(19, 5, 19),
	(20, 6, 19),
	(21, 7, 19),
	(22, 8, 19),
	(23, 9, 19),
	(24, 10, 19),
	(25, 11, 19),
	(26, 12, 19),
	(27, 13, 19),
	(28, 14, 19);
/*!40000 ALTER TABLE `monitoria` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
