-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Feb 25, 2021 alle 10:15
-- Versione del server: 10.4.14-MariaDB
-- Versione PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `smokecount`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `città`
--

CREATE TABLE `città` (
  `ID_città` int(11) NOT NULL,
  `Nome` varchar(25) NOT NULL,
  `Regione` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `città`
--

INSERT INTO `città` (`ID_città`, `Nome`, `Regione`) VALUES
(1, 'Reggio Emilia', 'Emilia Romagna'),
(2, 'Milano', 'Lombardia'),
(3, 'Bologna', 'Emilia Romagna');

-- --------------------------------------------------------

--
-- Struttura della tabella `dati`
--

CREATE TABLE `dati` (
  `ID_Dati` int(11) NOT NULL,
  `N_sigarette_fumate` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `dati`
--

INSERT INTO `dati` (`ID_Dati`, `N_sigarette_fumate`) VALUES
(1, 8),
(2, 10),
(3, 9),
(4, 15),
(5, 20),
(6, 14),
(7, 12),
(8, 16),
(9, 24),
(10, 20),
(11, 19),
(12, 26),
(13, 3),
(14, 5),
(15, 6),
(16, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `giorno`
--

CREATE TABLE `giorno` (
  `ID_giorno` int(11) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `giorno`
--

INSERT INTO `giorno` (`ID_giorno`, `Data`) VALUES
(1, '2021-02-21'),
(2, '2021-02-22'),
(3, '2021-02-23'),
(4, '2021-02-24');

-- --------------------------------------------------------

--
-- Struttura della tabella `pacchetto`
--

CREATE TABLE `pacchetto` (
  `ID_pacchetto` int(11) NOT NULL,
  `Tipo` varchar(10) NOT NULL,
  `Nome` varchar(25) NOT NULL,
  `Costo` decimal(10,2) NOT NULL,
  `Immagine` varchar(255) DEFAULT NULL,
  `Catrame` varchar(255) NOT NULL,
  `Nicotina` varchar(255) NOT NULL,
  `Monossido` varchar(255) NOT NULL,
  `N_Sigarette` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `pacchetto`
--

INSERT INTO `pacchetto` (`ID_pacchetto`, `Tipo`, `Nome`, `Costo`, `Immagine`, `Catrame`, `Nicotina`, `Monossido`, `N_Sigarette`) VALUES
(1, 'Pacchetto', 'Winston Blue', '5.00', 'winston.jpg', '8 Mg.', '0.60 Mg', '9 Mg.', 20),
(2, 'Pacchetto', 'Marlboro Gold', '5.60', 'marlborogold.jpg', '8 Mg.', '0.6 Mg', '9 Mg.', 20),
(3, 'Trinciato', 'Pueblo', '6.70', 'pueblotrinciato.jpg', '10 Mg.', '1 Mg.', '10 Mg.', 60),
(4, 'Pacchetto', 'Merit', '5.50', 'merit.jpg', '8 Mg.', '0.6 Mg.', '10 Mg.', 20);

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE `utenti` (
  `ID_utenti` int(11) NOT NULL,
  `Nome` varchar(25) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `IsPrivacy` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `utenti`
--

INSERT INTO `utenti` (`ID_utenti`, `Nome`, `Email`, `Password`, `IsPrivacy`) VALUES
(14, 'bobby', 'pluto@gmail.com', '', 1),
(15, 'Luchino', 'pippo@gmail.com', '1', 1),
(16, 'RedKyrie', 'tommyred2002@gmail.com', '1', 1),
(17, 'RedKyrie', 'tommyred2002@gmail.com', '', 1),
(18, 'biblisuh', 'tommyred2002@gmail.com', '', 1),
(19, 'biblisuh', 'pluto@gmail.com', '', 1),
(20, 'biblisuh', 'pluto@gmail.com', '', 1),
(21, 'biblisuh', 'pluto@gmail.com', '', 1);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `città`
--
ALTER TABLE `città`
  ADD PRIMARY KEY (`ID_città`);

--
-- Indici per le tabelle `dati`
--
ALTER TABLE `dati`
  ADD PRIMARY KEY (`ID_Dati`);

--
-- Indici per le tabelle `giorno`
--
ALTER TABLE `giorno`
  ADD PRIMARY KEY (`ID_giorno`);

--
-- Indici per le tabelle `pacchetto`
--
ALTER TABLE `pacchetto`
  ADD PRIMARY KEY (`ID_pacchetto`);

--
-- Indici per le tabelle `utenti`
--
ALTER TABLE `utenti`
  ADD PRIMARY KEY (`ID_utenti`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `città`
--
ALTER TABLE `città`
  MODIFY `ID_città` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT per la tabella `dati`
--
ALTER TABLE `dati`
  MODIFY `ID_Dati` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT per la tabella `giorno`
--
ALTER TABLE `giorno`
  MODIFY `ID_giorno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT per la tabella `pacchetto`
--
ALTER TABLE `pacchetto`
  MODIFY `ID_pacchetto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT per la tabella `utenti`
--
ALTER TABLE `utenti`
  MODIFY `ID_utenti` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
