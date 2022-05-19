-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 06 2022 г., 02:39
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

-- --------------------------------------------------------

--
-- Структура таблицы `certificate`
--

CREATE TABLE `certificate` (
  `idCertificate` int NOT NULL,
  `GPA` varchar(45) DEFAULT NULL,
  `Originality` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
(1, 'заочное');

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
(2, 'Информационые системы', 45),
(3, 'Строительство', 30);

-- --------------------------------------------------------

--
-- Структура таблицы `enrollelist`
--

CREATE TABLE `enrollelist` (
  `idEnrollelist` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Patronymic` varchar(45) DEFAULT NULL,
  `AvailabilityOfBenefits` tinyint DEFAULT NULL,
  `NeedHostel` tinyint DEFAULT NULL,
  `DateOfAdmission` date DEFAULT NULL,
  `Discipline_idDiscipline` int NOT NULL,
  `Department_idDepartment` int NOT NULL,
  `OtherOrphan_idOtherOrphan` int NOT NULL,
  `OtherOrphan_Certificate_idCertificate` int NOT NULL,
  `OtherOrphan_PassportDetails_idPassportDetails` int NOT NULL,
  `OtherStandart_idOtherStandart` int NOT NULL,
  `OtherStandart_Certificate_idCertificate` int NOT NULL,
  `OtherStandart_PassportDetails_idPassportDetails` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `otherorphan`
--

CREATE TABLE `otherorphan` (
  `idOtherOrphan` int NOT NULL,
  `ApplicationForAdmission` varchar(45) DEFAULT NULL,
  `CopyOfInsuranceCertificate` varchar(45) DEFAULT NULL,
  `CHIpolicy` varchar(45) DEFAULT NULL,
  `BirthCertificate` varchar(45) DEFAULT NULL,
  `CopyCourtDecisionConfirmingLegalStatus` varchar(45) DEFAULT NULL,
  `CopyDocumentLegalRepresentative` varchar(45) DEFAULT NULL,
  `InformationAboutPeriodStayOrphanage` varchar(45) DEFAULT NULL,
  `CertificateGuardianshipAuthoritiesStatus` varchar(45) DEFAULT NULL,
  `CopiesDocumentsHousing` varchar(45) DEFAULT NULL,
  `CertificateExtraordinaryReceiptLivingSpace` varchar(45) DEFAULT NULL,
  `ContactPhoneNumbers` int DEFAULT NULL,
  `Certificate_idCertificate` int NOT NULL,
  `PassportDetails_idPassportDetails` int NOT NULL
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
  `VaccinationCertificate` varchar(45) DEFAULT NULL,
  `MedicalPalicy` varchar(45) DEFAULT NULL,
  `Certificate_idCertificate` int NOT NULL,
  `PassportDetails_idPassportDetails` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `passportdetails`
--

CREATE TABLE `passportdetails` (
  `idPassportDetails` int NOT NULL,
  `Series` varchar(45) DEFAULT NULL,
  `Number` varchar(45) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `IssuedBy` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `certificate`
--
ALTER TABLE `certificate`
  ADD PRIMARY KEY (`idCertificate`);

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
  ADD PRIMARY KEY (`idEnrollelist`,`Discipline_idDiscipline`,`Department_idDepartment`,`OtherOrphan_idOtherOrphan`,`OtherOrphan_Certificate_idCertificate`,`OtherOrphan_PassportDetails_idPassportDetails`,`OtherStandart_idOtherStandart`,`OtherStandart_Certificate_idCertificate`,`OtherStandart_PassportDetails_idPassportDetails`),
  ADD KEY `fk_Enrollelist_Discipline1_idx` (`Discipline_idDiscipline`),
  ADD KEY `fk_Enrollelist_Department1_idx` (`Department_idDepartment`),
  ADD KEY `fk_Enrollelist_OtherOrphan1_idx` (`OtherOrphan_idOtherOrphan`,`OtherOrphan_Certificate_idCertificate`,`OtherOrphan_PassportDetails_idPassportDetails`),
  ADD KEY `fk_Enrollelist_OtherStandart1_idx` (`OtherStandart_idOtherStandart`,`OtherStandart_Certificate_idCertificate`,`OtherStandart_PassportDetails_idPassportDetails`);

--
-- Индексы таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  ADD PRIMARY KEY (`idOtherOrphan`,`Certificate_idCertificate`,`PassportDetails_idPassportDetails`),
  ADD KEY `fk_OtherOrphan_Certificate1_idx` (`Certificate_idCertificate`),
  ADD KEY `fk_OtherOrphan_PassportDetails1_idx` (`PassportDetails_idPassportDetails`);

--
-- Индексы таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  ADD PRIMARY KEY (`idOtherStandart`,`Certificate_idCertificate`,`PassportDetails_idPassportDetails`),
  ADD KEY `fk_OtherStandart_Certificate_idx` (`Certificate_idCertificate`),
  ADD KEY `fk_OtherStandart_PassportDetails1_idx` (`PassportDetails_idPassportDetails`);

--
-- Индексы таблицы `passportdetails`
--
ALTER TABLE `passportdetails`
  ADD PRIMARY KEY (`idPassportDetails`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `certificate`
--
ALTER TABLE `certificate`
  MODIFY `idCertificate` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `department`
--
ALTER TABLE `department`
  MODIFY `idDepartment` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `discipline`
--
ALTER TABLE `discipline`
  MODIFY `idDiscipline` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `enrollelist`
--
ALTER TABLE `enrollelist`
  MODIFY `idEnrollelist` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  MODIFY `idOtherOrphan` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  MODIFY `idOtherStandart` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `passportdetails`
--
ALTER TABLE `passportdetails`
  MODIFY `idPassportDetails` int NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `enrollelist`
--
ALTER TABLE `enrollelist`
  ADD CONSTRAINT `fk_Enrollelist_Department1` FOREIGN KEY (`Department_idDepartment`) REFERENCES `department` (`idDepartment`),
  ADD CONSTRAINT `fk_Enrollelist_Discipline1` FOREIGN KEY (`Discipline_idDiscipline`) REFERENCES `discipline` (`idDiscipline`),
  ADD CONSTRAINT `fk_Enrollelist_OtherOrphan1` FOREIGN KEY (`OtherOrphan_idOtherOrphan`,`OtherOrphan_Certificate_idCertificate`,`OtherOrphan_PassportDetails_idPassportDetails`) REFERENCES `otherorphan` (`idOtherOrphan`, `Certificate_idCertificate`, `PassportDetails_idPassportDetails`),
  ADD CONSTRAINT `fk_Enrollelist_OtherStandart1` FOREIGN KEY (`OtherStandart_idOtherStandart`,`OtherStandart_Certificate_idCertificate`,`OtherStandart_PassportDetails_idPassportDetails`) REFERENCES `otherstandart` (`idOtherStandart`, `Certificate_idCertificate`, `PassportDetails_idPassportDetails`);

--
-- Ограничения внешнего ключа таблицы `otherorphan`
--
ALTER TABLE `otherorphan`
  ADD CONSTRAINT `fk_OtherOrphan_Certificate1` FOREIGN KEY (`Certificate_idCertificate`) REFERENCES `certificate` (`idCertificate`),
  ADD CONSTRAINT `fk_OtherOrphan_PassportDetails1` FOREIGN KEY (`PassportDetails_idPassportDetails`) REFERENCES `passportdetails` (`idPassportDetails`);

--
-- Ограничения внешнего ключа таблицы `otherstandart`
--
ALTER TABLE `otherstandart`
  ADD CONSTRAINT `fk_OtherStandart_Certificate` FOREIGN KEY (`Certificate_idCertificate`) REFERENCES `certificate` (`idCertificate`),
  ADD CONSTRAINT `fk_OtherStandart_PassportDetails1` FOREIGN KEY (`PassportDetails_idPassportDetails`) REFERENCES `passportdetails` (`idPassportDetails`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
