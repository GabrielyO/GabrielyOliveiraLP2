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

-- Copiando dados para a tabela caderno.aluno: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` (`ID`, `NOMECOMPLETO`, `LOGIN`, `SENHA`) VALUES
	(2, 'Bruna Figueiredo de Jesus', 'bruninha', 'bruna'),
	(10, 'Gabriely de oliveira Nascimento', 'gabybicho', '040400'),
	(13, 'Lucas Barcelos Barros', 'barcelos', '270200'),
	(14, 'Lucas Bulhões Lopes', 'bulhoes', '010102'),
	(19, 'Paula Vasconcelos Dutra', 'paulinha', 'paula'),
	(22, 'Thamires Mendes de Lima', 'mlthami', '040200'),
	(23, 'Thiago Nascimento Maia', 'thiagomaia', '140799');
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

-- Copiando dados para a tabela caderno.monitoria: ~3 rows (aproximadamente)
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
	(14, 14, 2);
/*!40000 ALTER TABLE `monitoria` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
