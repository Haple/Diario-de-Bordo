-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.6.15-log - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.4.0.5174
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para projeto_diario
CREATE DATABASE IF NOT EXISTS `projeto_diario` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `projeto_diario`;

-- Copiando estrutura para tabela projeto_diario.anotacoes
CREATE TABLE IF NOT EXISTS `anotacoes` (
  `COD` int(11) NOT NULL AUTO_INCREMENT,
  `CONTEUDO` varchar(1000) DEFAULT NULL,
  `HORARIO` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`COD`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela projeto_diario.anotacoes: 1 rows
/*!40000 ALTER TABLE `anotacoes` DISABLE KEYS */;
INSERT INTO `anotacoes` (`COD`, `CONTEUDO`, `HORARIO`) VALUES
	(11, '"Chama-se curso superior e não curso para ser superior." - Anônimo ', '2017-11-15 10:08:25'),
	(10, '"O talento pode vencer jogos, mas é o trabalho em equipe é que ganha campeonatos." - Michael Jordan', '2017-11-15 10:06:21');
/*!40000 ALTER TABLE `anotacoes` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
