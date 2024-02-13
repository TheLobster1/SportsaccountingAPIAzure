-- MariaDB dump 10.19  Distrib 10.4.27-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: sportsaccounting
-- ------------------------------------------------------
-- Server version	10.4.27-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE IF NOT EXISTS `sportsaccounting` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sportsaccounting`;
--
-- Temporary table structure for view `bar_information`
--
GRANT USAGE ON *.* TO `ADMIN`@`%` IDENTIFIED BY PASSWORD '*64243AC6D3A3E3F43356175BA820F9B0A8B95DC9';

GRANT ALL PRIVILEGES ON `sportsaccounting`.* TO `ADMIN`@`%`;


# Privileges for `USER`@`%`

GRANT USAGE ON *.* TO `USER`@`%`;

GRANT SELECT, EXECUTE, SHOW VIEW ON `sportsaccounting`.* TO `USER`@`%`;

DROP TABLE IF EXISTS `bar_information`;
/*!50001 DROP VIEW IF EXISTS `bar_information`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `bar_information` AS SELECT
 1 AS `expenses`,
  1 AS `income`,
  1 AS `total` */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `categoryName` varchar(50) NOT NULL,
  PRIMARY KEY (`categoryName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES ('bar'),('membership fee'),('other'),('rental');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detailedinfo`
--

DROP TABLE IF EXISTS `detailedinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detailedinfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `amount` double NOT NULL,
  `currency` varchar(3) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(1) NOT NULL,
  `type` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2326 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detailedinfo`
--

LOCK TABLES `detailedinfo` WRITE;
/*!40000 ALTER TABLE `detailedinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `detailedinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `file`
--

DROP TABLE IF EXISTS `file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `file` (
  `transactionReference` varchar(255) NOT NULL,
  `availableBalanceId` int(11) DEFAULT NULL,
  `finalClosingBalanceId` int(11) DEFAULT NULL,
  `finalOpeningBalanceId` int(11) DEFAULT NULL,
  `forwardAvailableBalanceId` int(11) DEFAULT NULL,
  `accountIdentification` varchar(37) NOT NULL,
  `sequenceNumber` varchar(255) DEFAULT NULL,
  `statementNumber` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionReference`),
  KEY `availableBalanceId` (`availableBalanceId`),
  KEY `finalClosingBalanceId` (`finalClosingBalanceId`),
  KEY `finalOpeningBalanceId` (`finalOpeningBalanceId`),
  KEY `forwardAvailableBalanceId` (`forwardAvailableBalanceId`),
  CONSTRAINT `file_ibfk_1` FOREIGN KEY (`availableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_2` FOREIGN KEY (`finalClosingBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_3` FOREIGN KEY (`finalOpeningBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_4` FOREIGN KEY (`forwardAvailableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `member` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `email` varchar(320) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
/*!40000 ALTER TABLE `member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `rental_information`
--

DROP TABLE IF EXISTS `rental_information`;
/*!50001 DROP VIEW IF EXISTS `rental_information`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `rental_information` AS SELECT
 1 AS `expenses`,
  1 AS `income`,
  1 AS `turnover` */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction` (
  `bankReference` varchar(20) NOT NULL,
  `transactionReference` varchar(255) NOT NULL,
  `categoryName` varchar(50) NOT NULL,
  `balanceId` int(11) NOT NULL,
  `entryDate` date NOT NULL,
  `guessedEntryDate` date NOT NULL,
  `id` varchar(4) NOT NULL,
  `fundsCode` varchar(50) DEFAULT NULL,
  `transactionDetailsId` int(11) NOT NULL,
  PRIMARY KEY (`bankReference`),
  KEY `transactionReference` (`transactionReference`),
  KEY `categoryName` (`categoryName`),
  KEY `balanceId` (`balanceId`),
  KEY `transaction_ibfk_4` (`transactionDetailsId`),
  CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`transactionReference`) REFERENCES `file` (`transactionReference`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`categoryName`) REFERENCES `category` (`categoryName`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_3` FOREIGN KEY (`balanceId`) REFERENCES `detailedinfo` (`Id`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_4` FOREIGN KEY (`transactionDetailsId`) REFERENCES `transaction_details` (`Id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction_connect`
--

DROP TABLE IF EXISTS `transaction_connect`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction_connect` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `memberId` int(11) NOT NULL,
  `bankReference` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `bankReference` (`bankReference`),
  KEY `memberId` (`memberId`),
  CONSTRAINT `transaction_connect_ibfk_1` FOREIGN KEY (`bankReference`) REFERENCES `transaction` (`bankReference`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_connect_ibfk_2` FOREIGN KEY (`memberId`) REFERENCES `member` (`Id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_connect`
--

LOCK TABLES `transaction_connect` WRITE;
/*!40000 ALTER TABLE `transaction_connect` DISABLE KEYS */;
/*!40000 ALTER TABLE `transaction_connect` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction_details`
--

DROP TABLE IF EXISTS `transaction_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction_details` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `transactionDetails` varchar(255) NOT NULL,
  `extraDetails` varchar(255) DEFAULT NULL,
  `customDetails` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1767 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_details`
--

LOCK TABLES `transaction_details` WRITE;
/*!40000 ALTER TABLE `transaction_details` DISABLE KEYS */;
/*!40000 ALTER TABLE `transaction_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `email` varchar(320) NOT NULL,
  `password` varchar(64) NOT NULL,
  `joinDate` date NOT NULL,
  `userType` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `EMAIL` (`email`),
  KEY `userType` (`userType`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`userType`) REFERENCES `usertype` (`userType`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `CheckIfUserExists` BEFORE INSERT ON `user` FOR EACH ROW IF 


	EXISTS(SELECT 1 FROM user WHERE 	userName = NEW.userName) 


THEN


    SIGNAL SQLSTATE '45000' 


    SET MESSAGE_TEXT = 'Username is 	taken';


END IF */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `usertype`
--

DROP TABLE IF EXISTS `usertype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usertype` (
  `userType` varchar(20) NOT NULL,
  PRIMARY KEY (`userType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertype`
--

LOCK TABLES `usertype` WRITE;
/*!40000 ALTER TABLE `usertype` DISABLE KEYS */;
INSERT INTO `usertype` VALUES ('admin'),('user');
/*!40000 ALTER TABLE `usertype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'sportsaccounting'
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertTransactionWithDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertTransactionWithDetails`(IN `bank_Reference` VARCHAR(20), IN `transaction_Reference` VARCHAR(255), IN `category_Name` VARCHAR(50), IN `balance_Id` INT(11), IN `entry_Date` DATE, IN `guessed_EntryDate` DATE, IN `funds_Code` VARCHAR(50), IN `idd` VARCHAR(4), IN `transaction_Details` VARCHAR(255), IN `extra_Details` VARCHAR(255), IN `custom_Details` VARCHAR(255))
BEGIN



START TRANSACTION;



INSERT INTO transaction_details (transactionDetails, extraDetails, customDetails) VALUES (transaction_Details, extra_Details, custom_Details);



SET @details_id = LAST_INSERT_ID();



INSERT INTO `transaction` (bankReference, transactionReference, categoryName, balanceId, entryDate, guessedEntryDate, id, fundsCode, transactionDetailsId) VALUES (bank_Reference, transaction_Reference, category_Name, balance_Id, entry_Date, guessed_EntryDate, idd, funds_Code, @details_id);



COMMIT;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SowCustomDetailsBasedOnBankReference` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SowCustomDetailsBasedOnBankReference`(IN `bankReference` VARCHAR(20))
SELECT d.customDetails FROM transaction_details d JOIN transaction t ON d.id = t.transactionDetailsId WHERE t.bankReference = bankReference ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `bar_information`
--

/*!50001 DROP VIEW IF EXISTS `bar_information`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bar_information` AS select `subquery`.`expenses` AS `expenses`,`subquery`.`income` AS `income`,`subquery`.`expenses` + `subquery`.`income` AS `total` from (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'bar') and `detailedinfo`.`amount` <> 0) `subquery` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rental_information`
--

/*!50001 DROP VIEW IF EXISTS `rental_information`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rental_information` AS select `subquery`.`expenses` AS `expenses`,`subquery`.`income` AS `income`,`subquery`.`expenses` + `subquery`.`income` AS `turnover` from (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'rental') and `detailedinfo`.`amount` <> 0) `subquery` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-07 22:48:49
