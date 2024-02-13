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

--
-- Temporary table structure for view `bar_information`
--

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
) ENGINE=InnoDB AUTO_INCREMENT=718 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detailedinfo`
--

LOCK TABLES `detailedinfo` WRITE;
/*!40000 ALTER TABLE `detailedinfo` DISABLE KEYS */;
INSERT INTO `detailedinfo` VALUES (632,564.35,'EUR','2014-02-20','C','available_balance'),(633,564.35,'EUR','2014-02-20','C','final_closing_balance'),(634,662.23,'EUR','2014-02-19','C','final_opening_balance'),(635,564.35,'EUR','2014-02-24','C','forward_available_balance'),(636,1.56,'EUR','2014-02-20','C','transaction'),(637,-1.57,'EUR','2014-02-20','D','transaction'),(638,1.57,'EUR','2014-02-20','C','transaction'),(639,-1.14,'EUR','2014-02-20','D','transaction'),(640,1.45,'EUR','2014-02-20','C','transaction'),(641,-12.75,'EUR','2014-02-20','D','transaction'),(642,32,'EUR','2014-02-20','C','transaction'),(643,-119,'EUR','2014-02-20','D','transaction'),(644,1843.16,'EUR','2023-02-10','C','available_balance'),(645,1843.16,'EUR','2023-02-10','C','final_closing_balance'),(646,590.97,'EUR','2023-02-09','C','final_opening_balance'),(647,1843.16,'EUR','2023-02-14','C','forward_available_balance'),(648,219.81,'EUR','2023-02-10','C','transaction'),(649,231.54,'EUR','2023-02-10','C','transaction'),(650,105.98,'EUR','2023-02-10','C','transaction'),(651,-293.19,'EUR','2023-02-10','D','transaction'),(652,21.82,'EUR','2023-02-10','C','transaction'),(653,-419.74,'EUR','2023-02-10','D','transaction'),(654,202.93,'EUR','2023-02-10','C','transaction'),(655,-615.22,'EUR','2023-02-10','D','transaction'),(656,254.29,'EUR','2023-02-10','C','transaction'),(657,130.61,'EUR','2023-02-10','C','transaction'),(658,248.12,'EUR','2023-02-10','C','transaction'),(659,27.01,'EUR','2023-02-10','C','transaction'),(660,256.34,'EUR','2023-02-10','C','transaction'),(661,100.27,'EUR','2023-02-10','C','transaction'),(662,209.12,'EUR','2023-02-10','C','transaction'),(663,184.44,'EUR','2023-02-10','C','transaction'),(664,155.7,'EUR','2023-02-10','C','transaction'),(665,117.3,'EUR','2023-02-10','C','transaction'),(666,123.97,'EUR','2023-02-10','C','transaction'),(667,-210.01,'EUR','2023-02-10','D','transaction'),(668,135.06,'EUR','2023-02-10','C','transaction'),(669,132.1,'EUR','2023-02-10','C','transaction'),(670,158.62,'EUR','2023-02-10','C','transaction'),(671,159.62,'EUR','2023-02-10','C','transaction'),(672,118.15,'EUR','2023-02-10','C','transaction'),(673,157.02,'EUR','2023-02-10','C','transaction'),(674,233.4,'EUR','2023-02-10','C','transaction'),(675,-772.64,'EUR','2023-02-10','D','transaction'),(676,131.75,'EUR','2023-02-10','C','transaction'),(677,-786.73,'EUR','2023-02-10','D','transaction'),(678,137.63,'EUR','2023-02-10','C','transaction'),(679,276.6,'EUR','2023-02-10','C','transaction'),(680,184.15,'EUR','2023-02-10','C','transaction'),(681,-200.68,'EUR','2023-02-10','D','transaction'),(682,10.24,'EUR','2023-02-10','C','transaction'),(683,243.51,'EUR','2023-02-10','C','transaction'),(684,122.61,'EUR','2023-02-10','C','transaction'),(685,169.54,'EUR','2023-02-10','C','transaction'),(686,175.55,'EUR','2023-02-10','C','transaction'),(687,205.89,'EUR','2023-02-10','C','transaction'),(688,241.8,'EUR','2023-02-10','C','transaction'),(689,-751.93,'EUR','2023-02-10','D','transaction'),(690,160.93,'EUR','2023-02-10','C','transaction'),(691,200.94,'EUR','2023-02-10','C','transaction'),(692,175.41,'EUR','2023-02-10','C','transaction'),(693,-432.08,'EUR','2023-02-10','D','transaction'),(694,258.12,'EUR','2023-02-10','C','transaction'),(695,-62.33,'EUR','2023-02-10','D','transaction'),(696,20.89,'EUR','2023-02-10','C','transaction'),(697,-144.84,'EUR','2023-02-10','D','transaction'),(698,179.52,'EUR','2023-02-10','C','transaction'),(699,-71.7,'EUR','2023-02-10','D','transaction'),(700,-114.45,'EUR','2023-02-10','D','transaction'),(701,-365.23,'EUR','2023-02-10','D','transaction'),(702,-416.22,'EUR','2023-02-10','D','transaction'),(703,-359.34,'EUR','2023-02-10','D','transaction'),(704,-725.76,'EUR','2023-02-10','D','transaction'),(705,260.01,'EUR','2023-02-10','C','transaction'),(706,54,'EUR','2023-02-10','C','transaction'),(707,196.22,'EUR','2023-02-10','C','transaction'),(708,215.84,'EUR','2023-02-10','C','transaction'),(709,239.74,'EUR','2023-02-10','C','transaction'),(710,274.74,'EUR','2023-02-10','C','transaction'),(711,-436.7,'EUR','2023-02-10','D','transaction'),(712,186.83,'EUR','2023-02-10','C','transaction'),(713,235.14,'EUR','2023-02-10','C','transaction'),(714,199.45,'EUR','2023-02-10','C','transaction'),(715,110.37,'EUR','2023-02-10','C','transaction'),(716,-287.79,'EUR','2023-02-10','D','transaction'),(717,168.13,'EUR','2023-02-10','C','transaction');
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
INSERT INTO `file` VALUES ('P140220000000001',632,633,634,635,'NL69INGB0123456789EUR',NULL,'00000'),('P230210000000001',644,645,646,647,'NL65RABO0224663562EUR',NULL,'13040');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
INSERT INTO `member` VALUES (1,'Bob Ross','bobross@bob.ross'),(2,'Ross Bob','Ross@mike.ok'),(3,'Miroslav Penchev','miroslav@member.com');
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
INSERT INTO `transaction` VALUES ('00000000001005','P140220000000001','bar',636,'2014-02-20','2014-02-20','NTRF',NULL,193),('00000000001006','P140220000000001','bar',637,'2014-02-20','2014-02-20','NTRF',NULL,194),('00000000001007','P140220000000001','rental',638,'2014-02-20','2014-02-20','NRTI',NULL,195),('00000000001008','P140220000000001','bar',640,'2014-02-20','2014-02-20','NDDT',NULL,197),('00000000001009','P140220000000001','rental',639,'2014-02-20','2014-02-20','NDDT',NULL,196),('00000000001010','P140220000000001','bar',641,'2014-02-20','2014-02-20','NRTI',NULL,198),('00000000001011','P140220000000001','bar',642,'2014-02-20','2014-02-20','NTRF',NULL,199),('00000000001012','P140220000000001','bar',643,'2014-02-20','2014-02-20','NTRF',NULL,200),('00000000001263','P230210000000001','bar',658,'2023-02-10','2023-02-10','NTRF',NULL,211),('00000000001432','P230210000000001','bar',685,'2023-02-10','2023-02-10','NTRF',NULL,238),('00000000001537','P230210000000001','bar',663,'2023-02-10','2023-02-10','NTRF',NULL,216),('00000000001731','P230210000000001','bar',669,'2023-02-10','2023-02-10','NTRF',NULL,222),('00000000001733','P230210000000001','bar',666,'2023-02-10','2023-02-10','NTRF',NULL,219),('00000000001746','P230210000000001','bar',700,'2023-02-10','2023-02-10','NTRF',NULL,253),('00000000001775','P230210000000001','bar',675,'2023-02-10','2023-02-10','NDDT',NULL,228),('00000000001857','P230210000000001','bar',673,'2023-02-10','2023-02-10','NTRF',NULL,226),('00000000001883','P230210000000001','bar',692,'2023-02-10','2023-02-10','NTRF',NULL,245),('000000000019','P230210000000001','bar',654,'2023-02-10','2023-02-10','NTRF',NULL,207),('00000000002155','P230210000000001','bar',699,'2023-02-10','2023-02-10','NTRF',NULL,252),('00000000002224','P230210000000001','bar',709,'2023-02-10','2023-02-10','NTRF',NULL,262),('00000000002275','P230210000000001','bar',668,'2023-02-10','2023-02-10','NTRF',NULL,221),('00000000002474','P230210000000001','bar',664,'2023-02-10','2023-02-10','NTRF',NULL,217),('00000000002533','P230210000000001','bar',677,'2023-02-10','2023-02-10','NDDT',NULL,230),('0000000000257','P230210000000001','bar',705,'2023-02-10','2023-02-10','NTRF',NULL,258),('00000000002810','P230210000000001','bar',671,'2023-02-10','2023-02-10','NTRF',NULL,224),('00000000002814','P230210000000001','bar',698,'2023-02-10','2023-02-10','NTRF',NULL,251),('00000000002970','P230210000000001','bar',691,'2023-02-10','2023-02-10','NTRF',NULL,244),('00000000002984','P230210000000001','bar',678,'2023-02-10','2023-02-10','NTRF',NULL,231),('00000000003010','P230210000000001','bar',683,'2023-02-10','2023-02-10','NTRF',NULL,236),('00000000003071','P230210000000001','bar',648,'2023-02-10','2023-02-10','NTRF',NULL,201),('00000000003106','P230210000000001','bar',657,'2023-02-10','2023-02-10','NTRF',NULL,210),('0000000000315','P230210000000001','bar',690,'2023-02-10','2023-02-10','NTRF',NULL,243),('0000000000336','P230210000000001','bar',651,'2023-02-10','2023-02-10','NDDT',NULL,204),('00000000004214','P230210000000001','bar',665,'2023-02-10','2023-02-10','NTRF',NULL,218),('00000000004299','P230210000000001','bar',710,'2023-02-10','2023-02-10','NTRF',NULL,263),('00000000004353','P230210000000001','bar',655,'2023-02-10','2023-02-10','NDDT',NULL,208),('00000000004381','P230210000000001','bar',652,'2023-02-10','2023-02-10','NTRF',NULL,205),('00000000004396','P230210000000001','bar',702,'2023-02-10','2023-02-10','NDDT',NULL,255),('00000000004415','P230210000000001','bar',701,'2023-02-10','2023-02-10','NDDT',NULL,254),('00000000004570','P230210000000001','bar',660,'2023-02-10','2023-02-10','NTRF',NULL,213),('00000000004688','P230210000000001','bar',670,'2023-02-10','2023-02-10','NTRF',NULL,223),('0000000000523','P230210000000001','bar',715,'2023-02-10','2023-02-10','NTRF',NULL,268),('00000000005235','P230210000000001','bar',687,'2023-02-10','2023-02-10','NTRF',NULL,240),('00000000005305','P230210000000001','bar',706,'2023-02-10','2023-02-10','NTRF',NULL,259),('00000000005374','P230210000000001','bar',679,'2023-02-10','2023-02-10','NTRF',NULL,232),('00000000005496','P230210000000001','bar',712,'2023-02-10','2023-02-10','NTRF',NULL,265),('0000000000556','P230210000000001','bar',711,'2023-02-10','2023-02-10','NDDT',NULL,264),('00000000006122','P230210000000001','bar',659,'2023-02-10','2023-02-10','NTRF',NULL,212),('00000000006167','P230210000000001','bar',704,'2023-02-10','2023-02-10','NDDT',NULL,257),('00000000006214','P230210000000001','bar',714,'2023-02-10','2023-02-10','NTRF',NULL,267),('00000000006456','P230210000000001','bar',708,'2023-02-10','2023-02-10','NTRF',NULL,261),('00000000006630','P230210000000001','bar',676,'2023-02-10','2023-02-10','NTRF',NULL,229),('00000000006802','P230210000000001','bar',672,'2023-02-10','2023-02-10','NTRF',NULL,225),('00000000006857','P230210000000001','bar',650,'2023-02-10','2023-02-10','NTRF',NULL,203),('0000000000689','P230210000000001','bar',713,'2023-02-10','2023-02-10','NTRF',NULL,266),('00000000007127','P230210000000001','bar',674,'2023-02-10','2023-02-10','NTRF',NULL,227),('00000000007154','P230210000000001','bar',693,'2023-02-10','2023-02-10','NDDT',NULL,246),('00000000007175','P230210000000001','bar',667,'2023-02-10','2023-02-10','NDDT',NULL,220),('00000000007438','P230210000000001','bar',680,'2023-02-10','2023-02-10','NTRF',NULL,233),('00000000007494','P230210000000001','bar',686,'2023-02-10','2023-02-10','NTRF',NULL,239),('00000000007552','P230210000000001','bar',707,'2023-02-10','2023-02-10','NTRF',NULL,260),('00000000007629','P230210000000001','bar',697,'2023-02-10','2023-02-10','NTRF',NULL,250),('00000000007655','P230210000000001','bar',649,'2023-02-10','2023-02-10','NTRF',NULL,202),('0000000000775','P230210000000001','bar',695,'2023-02-10','2023-02-10','NTRF',NULL,248),('00000000007763','P230210000000001','bar',661,'2023-02-10','2023-02-10','NTRF',NULL,214),('00000000008260','P230210000000001','bar',688,'2023-02-10','2023-02-10','NTRF',NULL,241),('00000000008278','P230210000000001','bar',656,'2023-02-10','2023-02-10','NTRF',NULL,209),('00000000008300','P230210000000001','bar',703,'2023-02-10','2023-02-10','NDDT',NULL,256),('00000000008443','P230210000000001','bar',717,'2023-02-10','2023-02-10','NTRF',NULL,270),('00000000008561','P230210000000001','bar',716,'2023-02-10','2023-02-10','NDDT',NULL,269),('00000000008670','P230210000000001','bar',682,'2023-02-10','2023-02-10','NTRF',NULL,235),('00000000008680','P230210000000001','bar',662,'2023-02-10','2023-02-10','NTRF',NULL,215),('00000000008751','P230210000000001','bar',653,'2023-02-10','2023-02-10','NDDT',NULL,206),('00000000009182','P230210000000001','bar',681,'2023-02-10','2023-02-10','NDDT',NULL,234),('00000000009236','P230210000000001','bar',696,'2023-02-10','2023-02-10','NTRF',NULL,249),('00000000009320','P230210000000001','bar',689,'2023-02-10','2023-02-10','NDDT',NULL,242),('00000000009418','P230210000000001','bar',694,'2023-02-10','2023-02-10','NTRF',NULL,247),('00000000009452','P230210000000001','bar',684,'2023-02-10','2023-02-10','NTRF',NULL,237);
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_connect`
--

LOCK TABLES `transaction_connect` WRITE;
/*!40000 ALTER TABLE `transaction_connect` DISABLE KEYS */;
INSERT INTO `transaction_connect` VALUES (8,2,'00000000001005'),(9,1,'00000000001006');
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
) ENGINE=InnoDB AUTO_INCREMENT=271 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_details`
--

LOCK TABLES `transaction_details` WRITE;
/*!40000 ALTER TABLE `transaction_details` DISABLE KEYS */;
INSERT INTO `transaction_details` VALUES (193,'/EREF/EV12341REP1231456T1234//CNTP/NL32INGB0000012345/INGBNL2\nA/ING BANK NV INZAKE WEB///REMI/USTD//EV10001REP1000000T1000/','/TRCD/00100/','This is a tranaction'),(194,'/PREF/M000000003333333//REMI/USTD//TOTAAL 1 VZ/','/TRCD/00200/',''),(195,'/RTRN/MS03//EREF/20120123456789//CNTP/NL32INGB0000012345/INGB\nNL2A/J.Janssen///REMI/USTD//Factuurnr 123456 Klantnr 00123/','/TRCD/00190/',''),(196,'/EREF/EV123REP123412T1234//MARF/MND-EV01//CSID/NL32ZZZ9999999\n91234//CNTP/NL32INGB0000012345/INGBNL2A/ING Bank N.V. inzake WeB/\n//REMI/USTD//EV123REP123412T1234/','/TRCD/01016/',''),(197,'/PREF/M000000001111111//CSID/NL32ZZZ999999991234//REMI/USTD//\nTOTAAL       1 POSTEN/','/TRCD/01000/',''),(198,'/RTRN/MS03//EREF/20120501P0123478//MARF/MND-120123//CSID/NL32\nZZZ999999991234//CNTP/NL32INGB0000012345/INGBNL2A/J.Janssen///REM\nI/USTD//CONTRIBUTIE FEB 2014/','/TRCD/01315/',''),(199,'/EREF/15814016000676480//CNTP/NL32INGB0000012345/INGBNL2A/J.J\nanssen///REMI/STRD/CUR/9001123412341234/','/TRCD/00108/',''),(200,'/EREF/15614016000384600//CNTP/NL32INGB0000012345/INGBNL2A/ING\nBANK NV///REMI/STRD/CUR/1070123412341234/\n/SUM/4/4/134,46/36,58/\n-}','/TRCD/00108/',''),(201,'/EREF/E5540739P2789815//CSID/NL9513398Z9262618//CNTP/NL71KNAB\n0946967347/KNABNL2H/B. Velde///REMI/USTD//Factuur 479359/','/TCRD/00764/',''),(202,'/EREF/E9145291P1331484//CSID/NL6048349Z1902933//CNTP/NL61KNAB\n0470120214/KNABNL2H/W. Vliet///REMI/USTD//Contributie FEB 2023/','/TCRD/00376/',''),(203,'/EREF/E1131600P9386256//MARF/M8-E89//CNTP/NL24KNAB0487479444/\nKNABNL2H/O. Molenaar///REMI/USTD//Contributie Feb 2023/','/TCRD/00741/',''),(204,'/EREF/E2083346P6336439//CSID/NL1542446Z9722783//CNTP/NL80KNAB\n0879627134/KNABNL2H/Bronsport B.V.///REMI/USTD//PAS 31776 CL/','/TCRD/00517/',''),(205,'/PREF/E5189179P5862277//CNTP/NL91KNAB0921965046/KNABNL2H/E. B\nroek///REMI/USTD//Donatie/','/TCRD/0028/',''),(206,'/PREF/E8334483P6388977//MARF/M6-E90//CSID/NL9861783Z3167965//\nCNTP/NL39BUNQ0466357948/BUNQNL2A/GlobalCollect terzake Idema///RE\nMI/USTD//iDeal betaling C858369/','/TCRD/00407/',''),(207,'/PREF/E8303409P3431603//CNTP/NL14INGB0486606673/INGBNL2A/B. S\nchipper///REMI/USTD//Contributie Feb 23/','/TCRD/00761/',''),(208,'/PREF/E3839262P8359520//MARF/M5-E94//CSID/NL1360778Z270700//C\nNTP/NL71INGB0279758193/INGBNL2A/EasyPay terzake Idema///REMI/USTD\n//iDeal betaling id-743467/','/TCRD/0081/',''),(209,'/EREF/E5514305P509145//MARF/M1-E89//CNTP/NL20RABO0477719129/R\nABONL2U/P. Doorn///REMI/USTD//Contributie Feb 23/','/TCRD/00524/',''),(210,'/EREF/E5602722P4426143//CNTP/NL54KNAB0808054604/KNABNL2H/G. P\nrins///REMI/USTD//contributie FEB 23/','/TCRD/00284/',''),(211,'/EREF/E1626282P2928254//CNTP/NL41BUNQ0630183183/BUNQNL2A/X. S\ncholten///REMI/USTD//contributie jan 2023/','/TCRD/00481/',''),(212,'/EREF/E2904864P9558370//CNTP/NL64KNAB0676747974/KNABNL2H/Y. W\nillemsen///REMI/USTD//Donatie/','/TCRD/00364/',''),(213,'/PREF/E2563480P4008493//CNTP/NL27KNAB0179763600/KNABNL2H/L. H\neijden///REMI/USTD//contributie Feb 23/','/TCRD/00560/',''),(214,'/EREF/E6314837P1485855//CNTP/NL73ABAN0973717846/ABNANL2A/Z. T\nimmermans///REMI/USTD//contributie jan 2023/','/TCRD/00434/',''),(215,'/PREF/E6912899P1698950//CNTP/NL59KNAB0715822173/KNABNL2H/Z. V\nerbeek///REMI/USTD//Factuur 369565/','/TCRD/00860/',''),(216,'/PREF/E2715383P5512892//CNTP/NL73INGB0812746635/INGBNL2A/M. M\neer///REMI/USTD//factuur 244271/','/TCRD/00316/',''),(217,'/EREF/E2780804P4128011//CNTP/NL47INGB0152742334/INGBNL2A/R. E\nvers///REMI/USTD//contributie FEB 2023/','/TCRD/00166/',''),(218,'/EREF/E5205411P140307//CSID/NL4533902Z1243432//CNTP/NL51KNAB0\n982081555/KNABNL2H/M. Ruiter///REMI/USTD//Contributie Feb 23/','/TCRD/00983/',''),(219,'/EREF/E6285741P7842408//CNTP/NL58KNAB0598988679/KNABNL2H/Y. V\nos///REMI/USTD//Factuur 442308 klantnr 3407/','/TCRD/00319/',''),(220,'/PREF/E9305136P2841140//CNTP/NL20ABAN0443979418/ABNANL2A/Leba\n Sport///REMI/USTD//DEBIT Mastercard-63212 CL/','/TCRD/0041/',''),(221,'/EREF/E9146890P2236965//CNTP/NL81KNAB0906443407/KNABNL2H/E. B\nosman///REMI/USTD//Contributie jan 23/','/TCRD/00656/',''),(222,'/EREF/E8819720P7677061//CNTP/NL21INGB0875944882/INGBNL2A/H. J\nong///REMI/USTD//Factuur 292079/','/TCRD/00527/',''),(223,'/PREF/E3000142P7033677//CNTP/NL83ABAN0132777040/ABNANL2A/A. L\nange///REMI/USTD//Contributie feb 23/','/TCRD/00215/',''),(224,'/EREF/E5583322P1010790//CSID/NL2468672Z8765377//CNTP/NL70ABAN\n0997307986/ABNANL2A/L. Linden///REMI/USTD//factuur 67249 Klantnr.\n 2085/','/TCRD/00357/',''),(225,'/EREF/E3982397P545015//CNTP/NL35ABAN0383884031/ABNANL2A/D. Di\njk///REMI/USTD//Factuur 51429/','/TCRD/0070/',''),(226,'/EREF/E2362192P7630321//CNTP/NL50BUNQ0452624625/BUNQNL2A/W. W\nijk///REMI/USTD//contributie Feb 2023/','/TCRD/00341/',''),(227,'/PREF/E7177657P5199492//CNTP/NL35BUNQ0287443903/BUNQNL2A/A. L\ninden///REMI/USTD//Factuur 36509 Klantnr. 5781/','/TCRD/00705/',''),(228,'/EREF/E7477698P3873262//CNTP/NL41KNAB0718683975/KNABNL2H/Glob\nalCollect terzake Van Holland Sport///REMI/USTD//iDeal betaling C\n290346/','/TCRD/00327/',''),(229,'/PREF/E5805350P3973371//CNTP/NL68KNAB0691348273/KNABNL2H/V. H\norst///REMI/USTD//Contributie feb 2023/','/TCRD/00179/',''),(230,'/EREF/E8892319P6584928//CNTP/NL14RABO0680124116/RABONL2U/Glob\nalCollect terzake Van Holland Sport///REMI/USTD//iDeal betaling I\nD513096/','/TCRD/0045/',''),(231,'/EREF/E7120935P4396388//CNTP/NL79KNAB0363450420/KNABNL2H/Y. H\neijden///REMI/USTD//Contributie FEB 23/','/TCRD/00634/',''),(232,'/EREF/E5690171P7594302//CNTP/NL22KNAB0218027542/KNABNL2H/Q. V\nries///REMI/USTD//Factuur 34475/','/TCRD/00969/',''),(233,'/EREF/E6855109P4682758//MARF/M5-E89//CNTP/NL19BUNQ0384526574/\nBUNQNL2A/U. Dijkstra///REMI/USTD//contributie FEB 23/','/TCRD/00957/',''),(234,'/PREF/E3044251P8694796//CNTP/NL96INGB0577781270/INGBNL2A/Bron\nsport B.V.///REMI/USTD//PAS 72375 CL/','/TCRD/00257/',''),(235,'/EREF/E7214426P9937990//CNTP/NL75ABAN0473922052/ABNANL2A/R. H\nermans///REMI/USTD//Donatie/','/TCRD/00622/',''),(236,'/PREF/E9100714P9145762//MARF/M3-E11//CNTP/NL72KNAB0255510512/\nKNABNL2H/E. Velde///REMI/USTD//Factuur 558193 Klantnr. 9326/','/TCRD/0022/',''),(237,'/PREF/E6064282P8117509//CNTP/NL51ABAN0924479540/ABNANL2A/F. P\neters///REMI/USTD//Factuur 777659/','/TCRD/00449/',''),(238,'/EREF/E8526859P2497591//CNTP/NL26ABAN0804851703/ABNANL2A/H. D\nijkstra///REMI/USTD//factuur 677970/','/TCRD/00469/',''),(239,'/PREF/E3855700P6975482//CNTP/NL19ABAN0553787199/ABNANL2A/C. H\nofman///REMI/USTD//Contributie feb 2023/','/TCRD/00579/',''),(240,'/PREF/E8485818P1130763//CNTP/NL70RABO0944434228/RABONL2U/F. V\nelde///REMI/USTD//Contributie feb 2023/','/TCRD/0097/',''),(241,'/EREF/E1775300P8371824//CNTP/NL59INGB0673817357/INGBNL2A/Q. D\nam///REMI/USTD//Contributie jan 2023/','/TCRD/00270/',''),(242,'/EREF/E5630773P4606260//CNTP/NL51INGB0954669995/INGBNL2A/Easy\nPay terzake Van Holland Sport///REMI/USTD//iDeal betaling id-5701\n22/','/TCRD/00542/',''),(243,'/EREF/E8229424P3364290//CNTP/NL90RABO0302646344/RABONL2U/K. P\nol///REMI/USTD//factuur 839896/','/TCRD/00214/',''),(244,'/PREF/E8735982P4243747//CNTP/NL36INGB0281154385/INGBNL2A/L. B\nruijn///REMI/USTD//factuur 122553, Klantnr. 1296/','/TCRD/00205/',''),(245,'/PREF/E1635589P7174116//CNTP/NL36RABO0668918084/RABONL2U/B. V\neenstra///REMI/USTD//contributie feb 2023/','/TCRD/00929/',''),(246,'/PREF/E6220466P8705410//CNTP/NL65INGB0753311062/INGBNL2A/Eile\nrs sport///REMI/USTD//PIN Maestro 58634/','/TCRD/0091/',''),(247,'/EREF/E9048762P9565988//CNTP/NL79KNAB0565913197/KNABNL2H/Z. L\noon///REMI/USTD//Contributie FEB 23/','/TCRD/00783/',''),(248,'/EREF/E4807394P7970318//MARF/M2-E75//CNTP/NL51BUNQ0889682023/\nBUNQNL2A/Jonker///REMI/USTD//Factuur 822096/','/TCRD/00586/',''),(249,'/PREF/E1855006P3607456//CNTP/NL21BUNQ0550787498/BUNQNL2A/T. R\nuiter///REMI/USTD//donatie/','/TCRD/00606/',''),(250,'/EREF/E2030015P5078582//CSID/NL9835955Z417764//CNTP/NL29RABO0\n513379413/RABONL2U/ACC16171///REMI/USTD//Factuur 714502/','/TCRD/00686/',''),(251,'/PREF/E3628807P8596134//CSID/NL588181Z3898439//CNTP/NL23RABO0\n170915053/RABONL2U/I. Bosch///REMI/USTD//contributie FEB 2023/','/TCRD/00758/',''),(252,'/PREF/E1190124P1671481//CNTP/NL12BUNQ0494253173/BUNQNL2A/Meij\ner///REMI/USTD//Factuur 22654/','/TCRD/00132/',''),(253,'/EREF/E5870162P7119624//MARF/M8-E73//CNTP/NL48ABAN0453199607/\nABNANL2A/ACC56289///REMI/USTD//Factuur 5628/','/TCRD/0052/',''),(254,'/PREF/E9460461P2200023//CSID/NL5153501Z2233334//CNTP/NL25BUNQ\n0641059404/BUNQNL2A/Hocras///REMI/USTD//DEBIT 26605/','/TCRD/00202/',''),(255,'/EREF/E3010800P28998//MARF/M0-E58//CSID/NL5224087Z3213508//CN\nTP/NL88KNAB0560085126/KNABNL2H/Bronsport B.V.///REMI/USTD//CARD M\naestro 40349/','/TCRD/00756/',''),(256,'/PREF/E1769441P4022342//CNTP/NL22INGB0217891282/INGBNL2A/Eile\nrs sport///REMI/USTD//PAS Mastercard-76226/','/TCRD/00683/',''),(257,'/PREF/E8200978P7714358//CNTP/NL71ABAN0490285670/ABNANL2A/Glob\nalCollect terzake Idema///REMI/USTD//iDeal betaling C676519/','/TCRD/00622/',''),(258,'/EREF/E6456270P6558092//CSID/NL3186224Z3833520//CNTP/NL43ABAN\n0605213509/ABNANL2A/Y. Kramer///REMI/USTD//Factuur 858341/','/TCRD/00252/',''),(259,'/PREF/E206475P4307241//CSID/NL8127536Z6472710//CNTP/NL38RABO0\n200587702/RABONL2U/G. Hendriks///REMI/USTD//donatie/','/TCRD/00860/',''),(260,'/EREF/E9144812P8391590//MARF/M3-E17//CNTP/NL15KNAB0510830517/\nKNABNL2H/P. Hendriks///REMI/USTD//contributie jan 23/','/TCRD/00555/',''),(261,'/PREF/E4069591P9373611//MARF/M3-E53//CNTP/NL22ABAN0888184186/\nABNANL2A/I. Hoekstra///REMI/USTD//Factuur 404661/','/TCRD/00962/',''),(262,'/EREF/E6034717P2805625//MARF/M7-E12//CSID/NL1016226Z8834423//\nCNTP/NL55ABAN0314725450/ABNANL2A/M. Heuvel///REMI/USTD//contribut\nie feb 23/','/TCRD/00951/',''),(263,'/PREF/E7289574P1983944//CSID/NL7850204Z7827379//CNTP/NL57KNAB\n0425723990/KNABNL2H/L. Willemsen///REMI/USTD//Factuur 769105/','/TCRD/0045/',''),(264,'/EREF/E279004P3481783//CSID/NL1622667Z3125210//CNTP/NL62INGB0\n952441111/INGBNL2A/Stripe terzake Eilers sport///REMI/USTD//iDeal\n payment ID426921/','/TCRD/0074/',''),(265,'/EREF/E9893981P3549046//CSID/NL3161179Z7401683//CNTP/NL89ABAN\n0906303878/ABNANL2A/Z. Hofman///REMI/USTD//contributie jan 23/','/TCRD/00136/',''),(266,'/EREF/E371755P9152533//CNTP/NL32BUNQ0866360666/BUNQNL2A/W. Bo\ns///REMI/USTD//Contributie feb 23/','/TCRD/00795/',''),(267,'/EREF/E4493847P3460775//CSID/NL5276310Z8504925//CNTP/NL57RABO\n0766517698/RABONL2U/P. Groen///REMI/USTD//contributie feb 2023/','/TCRD/00108/',''),(268,'/PREF/E4407973P616775//CNTP/NL76KNAB0731447414/KNABNL2H/X. Ku\nijpers///REMI/USTD//contributie Feb 23/','/TCRD/00998/',''),(269,'/EREF/E3539984P2478911//CNTP/NL53INGB0692028747/INGBNL2A/Leba\n Sport///REMI/USTD//card Mastercard-70040/','/TCRD/00962/',''),(270,'/EREF/E6824895P254005//CNTP/NL57BUNQ0223400521/BUNQNL2A/S. La\nnge///REMI/USTD//Factuur 98896/\n/SUM/19/51/7466,58/8718,77/\n-}','/TCRD/00602/','');
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (7,'wasda','wasda','wasda','wasda@','AQAAAAIAAYagAAAAECrAWUU4xReslH6H9RYeACDiEFfRrJQLdzyaOz/RVeVDUnUw','2023-03-28','user'),(11,'miroslav','miroslav','penchev','miroslav@mail.com','AQAAAAIAAYagAAAAEHdbLVdetm21VDd9DGXZBNQP6OmMXyISGIVcKqd4GajaKdoU','2023-03-30','admin');
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

-- Dump completed on 2023-04-05 13:11:43
