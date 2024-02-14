-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         11.4.0-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando datos para la tabla pizzeria.almacen: ~6 rows (aproximadamente)
REPLACE INTO `almacen` (`Id`, `Nombre`, `Categoria`, `Cantidad`, `Precio`, `FechaDeCompra`, `FechaDeExp`) VALUES
	('sdht', 'sdth', 'sdht', 'aeyh', 'shy', '20/02/2024 06:08:58 p. m.', 'sh'),
	('1', 'dfg', 'afg', 'afdg', '35', '14/02/2024 06:10:33 p. m.', '14/02/2024 06:10:33 p. m.'),
	('1', 'dfg', 'afg', 'afdg', '35', '15/02/2024 06:10:33 p. m.', '21/02/2024 06:10:33 p. m.'),
	('1', 'fdsg', 'aag', 'asdg', '335', '16/02/2024 06:20:11 p. m.', '14/02/2024 06:20:11 p. m.'),
	('1', 'da', 'ad', 'vzx', '35', '17/02/2024 06:20:41 p. m.', '20/02/2024 06:20:41 p. m.'),
	('12', 'jo', 'fs', 'sh', '34', '14/02/2024 06:23:44 p. m.', '28/02/2024 06:23:44 p. m.');

-- Volcando datos para la tabla pizzeria.factura: ~2 rows (aproximadamente)
REPLACE INTO `factura` (`Pedido`, `Cliente`, `Telefono`, `Direccion`, `MetodoDePago`, `Descripcion`, `Cantidad`, `Subtotal`, `Total`, `Iva`, `Neto_a_Cancelar`) VALUES
	('0', 'dsfh', 'sdh', 'dfsh', NULL, 'Napolitana\r\nCocaCola\r\n', '1\r\n2\r\n', '30\r\n6\r\n', '36.00', '4.32', '40.32'),
	('0', 'dga', 'asdfg', 'ag', 'Debito', 'Napolitana\r\nPepsi\r\n', '1\r\n2\r\n', '30\r\n5\r\n', '35.00', '4.20', '39.20');

-- Volcando datos para la tabla pizzeria.producto: ~1 rows (aproximadamente)
REPLACE INTO `producto` (`Id`, `Nombre`, `Descripcion`, `Precio`, `Categoria`) VALUES
	(1, 'Napolitana', 'Salsa, Queso, Anchoas, Aceitunas Negras Fileteadas', '15', 'Comida');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
