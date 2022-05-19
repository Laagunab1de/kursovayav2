-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 19 2022 г., 09:14
-- Версия сервера: 8.0.24
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `enrollebd`
--
CREATE DATABASE IF NOT EXISTS `enrollebd` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `enrollebd`;

-- --------------------------------------------------------

--
-- Структура таблицы `certificate`
--

CREATE TABLE `certificate` (
  `idCertificate` int NOT NULL,
  `GPA` varchar(45) DEFAULT NULL,
  `Originality` varchar(45) DEFAULT NULL,
  `Enrollelist_idEnrollelist` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `certificate`
--

INSERT INTO `certificate` (`idCertificate`, `GPA`, `Originality`, `Enrollelist_idEnrollelist`) VALUES
(36, '4.30', '1', 58);

-- --------------------------------------------------------

--
-- Структура таблицы `department`
--

CREATE TABLE `department` (
  `idDepartment` int NOT NULL,
  `Title` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `department`
--

INSERT INTO `department` (`idDepartment`, `Title`) VALUES
(4, 'Экономика и сервис');

-- --------------------------------------------------------

--
-- Структура таблицы `discipline`
--

CREATE TABLE `discipline` (
  `idDiscipline` int NOT NULL,
  `Title` varchar(45) DEFAULT NULL,
  `NuberOfPlaces` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `discipline`
--

INSERT INTO `discipline` (`idDiscipline`, `Title`, `NuberOfPlaces`) VALUES
(6, 'Программирование', 35);

-- --------------------------------------------------------

--
-- Структура таблицы `enrollelist`
--

CREATE TABLE `enrollelist` (
  `ID` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Patronymic` varchar(45) DEFAULT NULL,
  `AvailabilityOfBenefits` tinyint DEFAULT NULL,
  `NeedHostel` tinyint DEFAULT NULL,
  `DateOfAdmission` date DEFAULT NULL,
  `Discipline_idDiscipline` int NOT NULL,
  `Department_idDepartment` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `enrollelist`
--

INSERT INTO `enrollelist` (`ID`, `Name`, `Surname`, `Patronymic`, `AvailabilityOfBenefits`, `NeedHostel`, `DateOfAdmission`, `Discipline_idDiscipline`, `Department_idDepartment`) VALUES
(58, 'Иван', 'Иванов ', 'Иванович', 1, 0, '2022-06-24', 6, 4);

-- --------------------------------------------------------

--
-- Структура таблицы `otherorphan`
--

CREATE TABLE `otherorphan` (
  `idOtherOrphan` int NOT NULL,
  `CopyOfInsuranceCertificate` varchar(45) DEFAULT NULL,
  `CHIpolicy` varchar(45) DEFAULT NULL,
  `BirthCertificate` varchar(45) DEFAULT NULL,
  `CopyCourtDecisionConfirmingLegalStatus` varchar(45) DEFAULT NULL,
  `CopyDocumentLegalRepresentative` varchar(45) DEFAULT NULL,
  `InformationAboutPeriodStayOrphanage` varchar(45) DEFAULT NULL,
  `CertificateGuardianshipAuthoritiesStatus` varchar(45) DEFAULT NULL,
  `CopiesDocumentsHousing` varchar(45) DEFAULT NULL,
  `CertificateExtraordinaryReceiptLivingSpace` varchar(45) DEFAULT NULL,
  `ContactPhoneNumbers` varchar(45) DEFAULT NULL,
  `ResultsFluorographicExamination` varchar(45) NOT NULL,
  `Enrollelist_idEnrollelist` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `otherstandart`
--

CREATE TABLE `otherstandart` (
  `idOtherStandart` int NOT NULL,
  `Photo` varchar(45) DEFAULT NULL,
  `FlurographicExam` varchar(45) DEFAULT NULL,
  `Snils` varchar(45) DEFAULT NULL,
  `MedicalPalicy` varchar(45) DEFAULT NULL,
  `Enrollelist_idEnrollelist` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `otherstandart`
--

INSERT INTO `otherstandart` (`idOtherStandart`, `Photo`, `FlurographicExam`, `Snils`, `MedicalPalicy`, `Enrollelist_idEnrollelist`) VALUES
(3, 'да', 'да', 'да', 'да', 58);

-- --------------------------------------------------------

--
-- Структура таблицы `passportdetails`
--

CREATE TABLE `passportdetails` (
  `idPassportDetails` int NOT NULL,
  `Series` varchar(45) DEFAULT NULL,
  `Number` varchar(45) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `IssuedBy` varchar(45) DEFAULT NULL,
  `Enrollelist_idEnrollelist` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `passportdetails`
--

INSERT INTO `passportdetails` (`idPassportDetails`, `Series`, `Number`, `Birthday`, `IssuedBy`, `Enrollelist_idEnrollelist`) VALUES
(25, '56', '4418', '2006-02-24', 'УМВД РОССИИ ПО ПРИМОРСКОМУ КРАЮ', 58);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `certificate`
--
ALTER TABLE `certificate`
  ADD PRIMARY KEY (`idCertificate`),
  ADD KEY `Enrollelist_idEnrollelist` (`Enrollelist_idEnrollelist`);

--
-- Индексы таблицы `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`idDepartment`);

--
-- Индексы таблицы `discipline`
--
ALTER TABLE `discipline`
  ADD PRIMARY KEY (`idDiscipline`);

--
-- Индексы таблицы `enrollelist`
--
ALTER TABLE `enrollelist`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Discipline_idDiscipline` (`Discipline_idDiscipline`),
  ADD KEY `Department_idDepartment` (`Department_idDepartment`);

--
-- Индексы таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  ADD PRIMARY KEY (`idOtherOrphan`),
  ADD KEY `Enrollelist_idEnrollelist` (`Enrollelist_idEnrollelist`);

--
-- Индексы таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  ADD PRIMARY KEY (`idOtherStandart`),
  ADD KEY `Enrollelist_idEnrollelist` (`Enrollelist_idEnrollelist`);

--
-- Индексы таблицы `passportdetails`
--
ALTER TABLE `passportdetails`
  ADD PRIMARY KEY (`idPassportDetails`),
  ADD KEY `Enrollelist_idEnrollelist` (`Enrollelist_idEnrollelist`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `certificate`
--
ALTER TABLE `certificate`
  MODIFY `idCertificate` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `department`
--
ALTER TABLE `department`
  MODIFY `idDepartment` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `discipline`
--
ALTER TABLE `discipline`
  MODIFY `idDiscipline` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `enrollelist`
--
ALTER TABLE `enrollelist`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT для таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  MODIFY `idOtherOrphan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  MODIFY `idOtherStandart` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `passportdetails`
--
ALTER TABLE `passportdetails`
  MODIFY `idPassportDetails` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `certificate`
--
ALTER TABLE `certificate`
  ADD CONSTRAINT `certificate_ibfk_1` FOREIGN KEY (`Enrollelist_idEnrollelist`) REFERENCES `enrollelist` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `enrollelist`
--
ALTER TABLE `enrollelist`
  ADD CONSTRAINT `enrollelist_ibfk_1` FOREIGN KEY (`Discipline_idDiscipline`) REFERENCES `discipline` (`idDiscipline`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `enrollelist_ibfk_2` FOREIGN KEY (`Department_idDepartment`) REFERENCES `department` (`idDepartment`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  ADD CONSTRAINT `otherorphan_ibfk_1` FOREIGN KEY (`Enrollelist_idEnrollelist`) REFERENCES `enrollelist` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  ADD CONSTRAINT `otherstandart_ibfk_1` FOREIGN KEY (`Enrollelist_idEnrollelist`) REFERENCES `enrollelist` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `passportdetails`
--
ALTER TABLE `passportdetails`
  ADD CONSTRAINT `passportdetails_ibfk_1` FOREIGN KEY (`Enrollelist_idEnrollelist`) REFERENCES `enrollelist` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
