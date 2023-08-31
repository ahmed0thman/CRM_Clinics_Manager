-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Aug 31, 2023 at 12:57 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `medical_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `action`
--

CREATE TABLE `action` (
  `mack_address` varchar(30) NOT NULL,
  `action_window` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `action`
--

INSERT INTO `action` (`mack_address`, `action_window`) VALUES
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done'),
('E09D31CF44B5', 'Patient done');

-- --------------------------------------------------------

--
-- Table structure for table `analysis`
--

CREATE TABLE `analysis` (
  `id` int(11) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `analysis`
--

INSERT INTO `analysis` (`id`, `name`) VALUES
(2, 'bones'),
(3, 'lever'),
(4, 'heart'),
(5, 'sonar'),
(6, '7amada');

-- --------------------------------------------------------

--
-- Table structure for table `check_up`
--

CREATE TABLE `check_up` (
  `patient` int(11) NOT NULL,
  `_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `check_up`
--

INSERT INTO `check_up` (`patient`, `_date`) VALUES
(101, '2020-08-20'),
(106, '2020-08-20'),
(101, '2020-08-20'),
(106, '2020-08-20'),
(101, '2020-09-02'),
(101, '2020-09-03'),
(101, '2021-03-01');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `diagnosis`
--

INSERT INTO `diagnosis` (`id`, `patient`, `diagnosis`, `_date`, `need_ray`, `need_analysis`) VALUES
(5, 101, 'ahmed is so sick', '2020-08-22', 1, 1),
(10, 101, 'asgdfggj', '2021-02-16', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_analysis`
--

CREATE TABLE `diagnosis_analysis` (
  `diagnosis` int(11) NOT NULL,
  `analysis` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `diagnosis_analysis`
--

INSERT INTO `diagnosis_analysis` (`diagnosis`, `analysis`) VALUES
(5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_ray`
--

CREATE TABLE `diagnosis_ray` (
  `diagnosis` int(11) NOT NULL,
  `ray` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `diagnosis_ray`
--

INSERT INTO `diagnosis_ray` (`diagnosis`, `ray`) VALUES
(5, 4);

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_treatment`
--

CREATE TABLE `diagnosis_treatment` (
  `diagnosis` int(11) NOT NULL,
  `treatment` int(11) NOT NULL,
  `describtion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `diagnosis_treatment`
--

INSERT INTO `diagnosis_treatment` (`diagnosis`, `treatment`, `describtion`) VALUES
(5, 4, 'some words'),
(10, 6, 'hjkhmvbk.');

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
  `suffer_from` text DEFAULT NULL,
  `historical_disease` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`id`, `name`, `phone`, `address`, `nationalID`, `age`, `birth_date`, `government`, `suffer_from`, `historical_disease`) VALUES
(101, 'ahmed Hisham', '011236940', 'samannud', '2981102', 22, '2020-08-05', 'gharbia', 'some problems', 'a lot of problems'),
(103, 'mohamed', '01846841531', 'samannud', '2991002', 30, '2020-08-05', 'gharbia', 'some isssues', 'some diseases'),
(104, 'zyad', '01546531', 'mit ghamr', '4151256352', 20, '2020-08-05', 'dkahlia', 'looooooooooool', 'lol'),
(105, 'ayman', '01225617488', 'alex', '2981026546541', 33, '1988-06-15', 'alexa', 'ayman suffer from ', 'some diseases for ayman'),
(106, 'amgad', '01285694151', 'mahala', '45132135', 20, '2020-08-05', 'ooooo', 'jsut a test for this person ', 'jsut a test for this person '),
(107, 'mostafa', '01067149663', 'banha', '8952654654113', 17, '2003-06-11', 'benha', 'some issues', 'some issues'),
(108, 'islam', '01458963058', 'fayom', '4163436874865', 20, '2020-08-05', 'fayom', 'some issues', 'some issues islam'),
(109, 'shehab salem', '01165941130', 'el menia', '4684146543546', 60, '2020-08-05', '', 'cant sleep', ''),
(110, 'mostafa mahmoud', '0124646499', 'menia', '468491684864', 30, '2020-08-05', 'dakahlia', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `patient_treatment`
--

CREATE TABLE `patient_treatment` (
  `patient` int(11) NOT NULL,
  `treatment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patient_treatment`
--

INSERT INTO `patient_treatment` (`patient`, `treatment`) VALUES
(104, 4),
(104, 7),
(105, 6),
(105, 4),
(107, 2),
(108, 6),
(103, 5),
(103, 4),
(110, 1),
(110, 2),
(106, 4),
(109, 6),
(101, 5),
(101, 3);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `person`
--

INSERT INTO `person` (`id`, `name`, `phone`, `username`, `pass`, `e_mail`, `address`, `type`) VALUES
(1, 'ahmed', '01123', 'ahmed', '1234', 'ahmed@ahmed', 'samannud', 'Doctor'),
(2, 'mahmoud', '01235468', 'maho', '123123', 'maho@maho', 'manora', 'Secritary');

-- --------------------------------------------------------

--
-- Table structure for table `ray`
--

CREATE TABLE `ray` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ray`
--

INSERT INTO `ray` (`id`, `name`) VALUES
(2, 'blood'),
(3, 'animia'),
(4, 'pregnant'),
(5, '7mamah'),
(6, 'lunges');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `patient` int(11) NOT NULL,
  `_date` date NOT NULL,
  `queue` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`patient`, `_date`, `queue`) VALUES
(103, '2020-08-26', 2),
(104, '2020-08-26', 3),
(105, '2023-06-24', 3),
(106, '2021-02-16', 4),
(107, '2020-08-23', 6),
(108, '2023-06-24', 2),
(109, '2021-02-16', 2),
(110, '2021-02-16', 3);

-- --------------------------------------------------------

--
-- Table structure for table `treatments`
--

CREATE TABLE `treatments` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `treatments`
--

INSERT INTO `treatments` (`id`, `name`) VALUES
(6, 'clamnight'),
(2, 'congestal'),
(8, 'paroxdep'),
(1, 'raibes'),
(3, 'rostolam'),
(4, 'serquil'),
(7, 'viagra'),
(5, 'vilazover');

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
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `analysis`
--
ALTER TABLE `analysis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `diagnosis`
--
ALTER TABLE `diagnosis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `person`
--
ALTER TABLE `person`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `ray`
--
ALTER TABLE `ray`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `treatments`
--
ALTER TABLE `treatments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

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
  ADD CONSTRAINT `fk_pd` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `diagnosis_analysis`
--
ALTER TABLE `diagnosis_analysis`
  ADD CONSTRAINT `fk_ada` FOREIGN KEY (`analysis`) REFERENCES `analysis` (`id`),
  ADD CONSTRAINT `fk_dda` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `diagnosis_ray`
--
ALTER TABLE `diagnosis_ray`
  ADD CONSTRAINT `fk_ddr` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_rdr` FOREIGN KEY (`ray`) REFERENCES `ray` (`id`);

--
-- Constraints for table `diagnosis_treatment`
--
ALTER TABLE `diagnosis_treatment`
  ADD CONSTRAINT `fk_dddt` FOREIGN KEY (`diagnosis`) REFERENCES `diagnosis` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_tdt` FOREIGN KEY (`treatment`) REFERENCES `treatments` (`id`);

--
-- Constraints for table `patient_treatment`
--
ALTER TABLE `patient_treatment`
  ADD CONSTRAINT `fk_ppt` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_tpt` FOREIGN KEY (`treatment`) REFERENCES `treatments` (`id`);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_pr` FOREIGN KEY (`patient`) REFERENCES `patient` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
