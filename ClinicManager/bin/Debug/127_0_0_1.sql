-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 12, 2020 at 02:27 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `medical_management`
--
DROP DATABASE IF EXISTS `medical_management`;
CREATE DATABASE IF NOT EXISTS `medical_management2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `medical_management`;

-- --------------------------------------------------------

--
-- Table structure for table `analysis`
--

CREATE TABLE `analysis` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `check_up`
--

CREATE TABLE `check_up` (
  `patient` int(11) NOT NULL,
  `_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis`
--

CREATE TABLE `diagnosis` (
  `id` int(11) NOT NULL,
  `patient` int(11) NOT NULL,
  `diagnosis` text NOT NULL,
  `_date` date NOT NULL,
  `need_ray` tinyint(1) NOT NULL,
  `need_analysis` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_analysis`
--

CREATE TABLE `diagnosis_analysis` (
  `diagnosis` int(11) NOT NULL,
  `analysis` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_ray`
--

CREATE TABLE `diagnosis_ray` (
  `diagnosis` int(11) NOT NULL,
  `ray` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_treatment`
--

CREATE TABLE `diagnosis_treatment` (
  `diagnosis` int(11) NOT NULL,
  `treatment` int(11) NOT NULL,
  `duration` int(11) NOT NULL,
  `duration_type` varchar(20) NOT NULL,
  `consuming` varchar(20) NOT NULL,
  `_interval` int(11) NOT NULL,
  `interval_type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `address` varchar(100) DEFAULT NULL,
  `nationalID` varchar(20) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `government` varchar(50) DEFAULT NULL,
  `suffer_from` text,
  `historical_disease` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `patient_treatment`
--

CREATE TABLE `patient_treatment` (
  `patient` int(11) NOT NULL,
  `treatment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE `person` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `username` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `e_mail` varchar(50) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ray`
--

CREATE TABLE `ray` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `patient` int(11) NOT NULL,
  `_date` date NOT NULL,
  `queue` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `treatments`
--

CREATE TABLE `treatments` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `analysis`
--
ALTER TABLE `analysis`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `check_up`
--
ALTER TABLE `check_up`
  ADD KEY `fk_pcu` (`patient`);

--
-- Indexes for table `diagnosis`
--
ALTER TABLE `diagnosis`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `patient` (`patient`,`_date`);

--
-- Indexes for table `diagnosis_analysis`
--
ALTER TABLE `diagnosis_analysis`
  ADD KEY `fk_dda` (`diagnosis`),
  ADD KEY `fk_ada` (`analysis`);

--
-- Indexes for table `diagnosis_ray`
--
ALTER TABLE `diagnosis_ray`
  ADD KEY `fk_ddr` (`diagnosis`),
  ADD KEY `fk_rdr` (`ray`);

--
-- Indexes for table `diagnosis_treatment`
--
ALTER TABLE `diagnosis_treatment`
  ADD KEY `fk_dddt` (`diagnosis`),
  ADD KEY `fk_tdt` (`treatment`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient_treatment`
--
ALTER TABLE `patient_treatment`
  ADD KEY `fk_ppt` (`patient`),
  ADD KEY `fk_tpt` (`treatment`);

--
-- Indexes for table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ray`
--
ALTER TABLE `ray`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`patient`,`_date`);

--
-- Indexes for table `treatments`
--
ALTER TABLE `treatments`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `analysis`
--
ALTER TABLE `analysis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `diagnosis`
--
ALTER TABLE `diagnosis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `person`
--
ALTER TABLE `person`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ray`
--
ALTER TABLE `ray`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `treatments`
--
ALTER TABLE `treatments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `check_up`
--
ALTER TABLE `check_up`
  ADD CONSTRAINT `fk_pcu` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`);

--
-- Constraints for table `diagnosis`
--
ALTER TABLE `diagnosis`
  ADD CONSTRAINT `fk_pd` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`);

--
-- Constraints for table `diagnosis_analysis`
--
ALTER TABLE `diagnosis_analysis`
  ADD CONSTRAINT `fk_ada` FOREIGN KEY (`analysis`) REFERENCES `analysis` (`id`),
  ADD CONSTRAINT `fk_dda` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`);

--
-- Constraints for table `diagnosis_ray`
--
ALTER TABLE `diagnosis_ray`
  ADD CONSTRAINT `fk_ddr` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`),
  ADD CONSTRAINT `fk_rdr` FOREIGN KEY (`ray`) REFERENCES `ray` (`id`);

--
-- Constraints for table `diagnosis_treatment`
--
ALTER TABLE `diagnosis_treatment`
  ADD CONSTRAINT `fk_dddt` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`),
  ADD CONSTRAINT `fk_tdt` FOREIGN KEY (`treatment`) REFERENCES `treatments` (`id`);

--
-- Constraints for table `patient_treatment`
--
ALTER TABLE `patient_treatment`
  ADD CONSTRAINT `fk_ppt` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`),
  ADD CONSTRAINT `fk_tpt` FOREIGN KEY (`treatment`) REFERENCES `treatments` (`id`);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_pr` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
