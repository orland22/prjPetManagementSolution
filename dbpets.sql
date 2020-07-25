-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 18, 2020 at 02:42 PM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpets`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbreed`
--

CREATE TABLE `tblbreed` (
  `breedID` int(11) NOT NULL,
  `breedname` varchar(20) DEFAULT NULL,
  `typeID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblbreed`
--

INSERT INTO `tblbreed` (`breedID`, `breedname`, `typeID`) VALUES
(28, 'Shitzu', 12),
(29, 'Persian', 13),
(30, 'Goldfish', 14);

-- --------------------------------------------------------

--
-- Table structure for table `tblowner`
--

CREATE TABLE `tblowner` (
  `ownerID` int(11) NOT NULL,
  `ownerName` varchar(20) DEFAULT NULL,
  `ownerAddress` varchar(30) DEFAULT NULL,
  `ownerContactNumber` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblowner`
--

INSERT INTO `tblowner` (`ownerID`, `ownerName`, `ownerAddress`, `ownerContactNumber`) VALUES
(15, 'Orland M Celestino', 'km.12 Indangan', '09424594927'),
(16, 'Luke Monteza', 'Buhangin', '09595345858'),
(17, 'Joshua Tanucan', 'Tigatoo', '09234234664');

-- --------------------------------------------------------

--
-- Table structure for table `tblpet`
--

CREATE TABLE `tblpet` (
  `petID` int(11) NOT NULL,
  `ownerID` int(11) DEFAULT NULL,
  `petName` varchar(20) DEFAULT NULL,
  `petBirthdate` date DEFAULT NULL,
  `petGender` varchar(6) DEFAULT NULL,
  `petStatus` varchar(10) DEFAULT NULL,
  `petBreed` int(11) DEFAULT NULL,
  `petNotes` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblpet`
--

INSERT INTO `tblpet` (`petID`, `ownerID`, `petName`, `petBirthdate`, `petGender`, `petStatus`, `petBreed`, `petNotes`) VALUES
(1, 15, 'Lucy', '2016-12-06', 'Male', 'Active', 28, 'Skinny'),
(2, 16, 'Markus', '2009-06-13', 'Male', 'Active', 29, 'chubby'),
(3, 17, 'Marry', '2005-06-13', 'Female', 'Inactive', 30, 'baby');

-- --------------------------------------------------------

--
-- Table structure for table `tbltype`
--

CREATE TABLE `tbltype` (
  `typeID` int(11) NOT NULL,
  `typeName` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbltype`
--

INSERT INTO `tbltype` (`typeID`, `typeName`) VALUES
(12, 'Dog'),
(13, 'Cat'),
(14, 'Fish');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbreed`
--
ALTER TABLE `tblbreed`
  ADD PRIMARY KEY (`breedID`),
  ADD KEY `typeID` (`typeID`);

--
-- Indexes for table `tblowner`
--
ALTER TABLE `tblowner`
  ADD PRIMARY KEY (`ownerID`);

--
-- Indexes for table `tblpet`
--
ALTER TABLE `tblpet`
  ADD PRIMARY KEY (`petID`),
  ADD KEY `ownerID` (`ownerID`),
  ADD KEY `petBreed` (`petBreed`);

--
-- Indexes for table `tbltype`
--
ALTER TABLE `tbltype`
  ADD PRIMARY KEY (`typeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbreed`
--
ALTER TABLE `tblbreed`
  MODIFY `breedID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tblowner`
--
ALTER TABLE `tblowner`
  MODIFY `ownerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tblpet`
--
ALTER TABLE `tblpet`
  MODIFY `petID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbltype`
--
ALTER TABLE `tbltype`
  MODIFY `typeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblbreed`
--
ALTER TABLE `tblbreed`
  ADD CONSTRAINT `tblbreed_ibfk_1` FOREIGN KEY (`typeID`) REFERENCES `tbltype` (`typeID`);

--
-- Constraints for table `tblpet`
--
ALTER TABLE `tblpet`
  ADD CONSTRAINT `tblpet_ibfk_1` FOREIGN KEY (`ownerID`) REFERENCES `tblowner` (`ownerID`),
  ADD CONSTRAINT `tblpet_ibfk_2` FOREIGN KEY (`petBreed`) REFERENCES `tblbreed` (`breedID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
