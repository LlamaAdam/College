-- MariaDB dump 10.17  Distrib 10.4.6-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: test2
-- ------------------------------------------------------
-- Server version	10.4.6-MariaDB

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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `ClientID` varchar(7) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LasstName` text DEFAULT NULL,
  `LegalAddress` text DEFAULT NULL,
  `Phone` text DEFAULT NULL,
  PRIMARY KEY (`ClientID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES ('CAM01','Arjun','Miller','84 Crossroad Way','228-256-7779'),('CEB01','Edgar',' Brown','521 Americana Dr','816-286-8273'),('CEJ01','Elizabeth','Johnson','108 Curle Rd','913-679-6259'),('CHW01','Hana','Wilson','508 Southwest Trfy','913-404-8249'),('CJJ01','Jane','Jones','509 101st St','804-754-327'),('CJM01','Jeremy','Moore','404 Westport Dr','202-561-7648'),('CKD01','Katy','Davis','42 Memorial Ln','703-680-7093'),('CKT01','Kitty','Taylor','93 NE Russel Rd','757-499-4422'),('CRW01','Raphael','Williams','131 Westrbook Dr','503-724-5047'),('CSS01','Solomon',' Smith','12 Main St','816-686-4119');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contract` (
  `ContractNo` int(11) NOT NULL,
  `ClientID` varchar(7) NOT NULL,
  `TrainerID` varchar(7) NOT NULL,
  `ExperationDate` date NOT NULL,
  PRIMARY KEY (`ContractNo`),
  KEY `FK_Contract_to_Client` (`ClientID`),
  KEY `FK_Contract_to_Trainer` (`TrainerID`),
  CONSTRAINT `FK_Contract_to_Client` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ClientID`),
  CONSTRAINT `FK_Contract_to_Trainer` FOREIGN KEY (`TrainerID`) REFERENCES `trainer` (`TrainerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
INSERT INTO `contract` VALUES (1,'CJJ01','TPJ01','2022-10-01'),(2,'CJM01','TSC01','2021-01-05'),(3,'CRW01','TIM01','2022-02-07'),(4,'CHW01','TAB01','2022-07-11'),(5,'CSS01','TVT01','2021-09-01'),(6,'CEB01','THR01','2022-07-09'),(7,'CKT01','TDA01','2021-10-12'),(8,'CKD01','THH01','2020-09-03'),(9,'CEJ01','TWW01','2021-10-02'),(10,'CAM01','THC01','2022-08-27');
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trainer`
--

DROP TABLE IF EXISTS `trainer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trainer` (
  `TrainerID` varchar(7) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LasstName` text DEFAULT NULL,
  `Salary` float DEFAULT NULL,
  `DaysAvailable` int(11) DEFAULT NULL,
  PRIMARY KEY (`TrainerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trainer`
--

LOCK TABLES `trainer` WRITE;
/*!40000 ALTER TABLE `trainer` DISABLE KEYS */;
INSERT INTO `trainer` VALUES ('TAB01','Andrew','Bell',75852,110011),('TDA01','Darren','Anderson',35975,1011010),('THC01','Harry','Carter',84269,1111),('THH01','Hafsa','Harris',47552,1111101),('THR01','Harris','Reed',34883,1101010),('TIM01','Isabelle','Martin',77460,10100),('TPJ01','Pete','Jackson',87083,1101000),('TSC01','Samuel','Cook',66436,1100),('TVT01','Veronica','Thomas',60483,11110),('TWW01','Wesley','White',80071,100100);
/*!40000 ALTER TABLE `trainer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weights`
--

DROP TABLE IF EXISTS `weights`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `weights` (
  `WeightID` varchar(7) NOT NULL,
  `WeightType` text DEFAULT NULL,
  `WeightIncruments` int(11) DEFAULT NULL,
  PRIMARY KEY (`WeightID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weights`
--

LOCK TABLES `weights` WRITE;
/*!40000 ALTER TABLE `weights` DISABLE KEYS */;
INSERT INTO `weights` VALUES ('BB05','Barbell',5),('CB25','CurlBar',10),('CM05','CalfMachine',5),('DB25','Dumbell',3),('DI00','DipBar',0),('KB10','Kettleball',10),('LC05','LegCurl',5),('LE05','LegExtension',5),('LP05','LegPress',5),('MF05','Machine fly',0),('PB00','PullupBar',0);
/*!40000 ALTER TABLE `weights` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workout`
--

DROP TABLE IF EXISTS `workout`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workout` (
  `WorkoutID` varchar(7) NOT NULL,
  `ExerciseName` text DEFAULT NULL,
  `Sets` varchar(6) DEFAULT NULL,
  `Weights_Used` varchar(7) DEFAULT NULL,
  PRIMARY KEY (`WorkoutID`),
  KEY `FK_Workout_to_Weights` (`Weights_Used`),
  CONSTRAINT `FK_Workout_to_Weights` FOREIGN KEY (`Weights_Used`) REFERENCES `weights` (`WeightID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workout`
--

LOCK TABLES `workout` WRITE;
/*!40000 ALTER TABLE `workout` DISABLE KEYS */;
INSERT INTO `workout` VALUES ('W01','BB BENCH','3X10-6','BB05'),('W02','CHEST SUPPORTED ROW','3X10-6','DB25'),('W03','DB OR BB BENCH','3X10-6','BB05'),('W04','FLAT CHEST PRESS','4X6','DB25'),('W05','HAMMER CURL','2X10','DB25'),('W06','HAMSTRING CURL','3X10-6','LE05'),('W07','HIP ABDUCTION','2X10','LE05'),('W08','HIP EXTENSION','2X10','LE05'),('W09','HIP THRUST','2X10','BB05'),('W10','LATERAL RAISE','4X10','DB25'),('W11','LEG EXTENSION','3X8','LE05'),('W12','LEG PRESS','3X5-7','LP05'),('W13','LEG PRESS SQUAT','4X8-10','BB05'),('W14','PEC FLY','3X10','MF05'),('W15','PREACHER CURL','3X8','CB25'),('W16','PULLDOWN','2X8-10','PB00'),('W17','PUSH UP','2XRPE9','DI00'),('W18','PUSH UP OR DIP','2XRPE9','DI00'),('W19','REAR DELT ','3X8','DB25'),('W20','SHOULDER PRESS','2X8-10','DB25'),('W21','SQUAT LEG PRESS','3X5-7','BB05'),('W22','STANDING CALF','4X8','CM05'),('W23','STRAIGHT ARM PULL OVER','3X10','KB10'),('W24','TRICEP EXT','3X8','KB10');
/*!40000 ALTER TABLE `workout` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workoutsetup`
--

DROP TABLE IF EXISTS `workoutsetup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workoutsetup` (
  `PlanID` varchar(7) NOT NULL,
  `WorkoutID` varchar(7) NOT NULL,
  KEY `FK_WORKOUTSETUP_to_WorkoutTime` (`PlanID`),
  KEY `FK_WORKOUTSETUP_to_Workout` (`WorkoutID`),
  CONSTRAINT `FK_WORKOUTSETUP_to_Workout` FOREIGN KEY (`WorkoutID`) REFERENCES `workout` (`WorkoutID`),
  CONSTRAINT `FK_WORKOUTSETUP_to_WorkoutTime` FOREIGN KEY (`PlanID`) REFERENCES `workouttime` (`PlanID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workoutsetup`
--

LOCK TABLES `workoutsetup` WRITE;
/*!40000 ALTER TABLE `workoutsetup` DISABLE KEYS */;
INSERT INTO `workoutsetup` VALUES ('PI01','W01'),('PI10','W01'),('PI01','W02'),('PI03','W02'),('PI05','W02'),('PI07','W02'),('PI05','W03'),('PI02','W04'),('PI06','W04'),('PI03','W05'),('PI07','W05'),('PI09','W05'),('PI01','W06'),('PI04','W06'),('PI05','W06'),('PI08','W06'),('PI09','W06'),('PI04','W07'),('PI08','W07'),('PI04','W08'),('PI08','W08'),('PI01','W09'),('PI04','W09'),('PI05','W09'),('PI08','W09'),('PI09','W09'),('PI02','W10'),('PI06','W10'),('PI04','W11'),('PI08','W11'),('PI09','W11'),('PI10','W11'),('PI01','W12'),('PI04','W12'),('PI09','W12'),('PI08','W13'),('PI02','W14'),('PI06','W14'),('PI10','W14'),('PI03','W15'),('PI07','W15'),('PI01','W16'),('PI03','W16'),('PI05','W16'),('PI07','W16'),('PI09','W16'),('PI02','W17'),('PI06','W18'),('PI03','W19'),('PI07','W19'),('PI10','W19'),('PI01','W20'),('PI02','W20'),('PI05','W20'),('PI06','W20'),('PI10','W20'),('PI05','W21'),('PI10','W21'),('PI05','W22'),('PI08','W22'),('PI03','W23'),('PI07','W23'),('PI09','W23'),('PI02','W24'),('PI06','W24'),('PI10','W24'),('PI10','W21'),('PI05','W22'),('PI08','W22'),('PI03','W23'),('PI07','W23'),('PI09','W23'),('PI02','W24'),('PI06','W24'),('PI10','W24');
/*!40000 ALTER TABLE `workoutsetup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workouttime`
--

DROP TABLE IF EXISTS `workouttime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workouttime` (
  `PlanID` varchar(7) NOT NULL,
  `ContractNo` int(11) NOT NULL,
  `Days` varchar(3) DEFAULT NULL,
  `Time` time DEFAULT NULL,
  `Workouts` varchar(7) NOT NULL,
  PRIMARY KEY (`PlanID`),
  KEY `FK_WorkoutTime_to_Contract` (`ContractNo`),
  CONSTRAINT `FK_WorkoutTime_to_Contract` FOREIGN KEY (`ContractNo`) REFERENCES `contract` (`ContractNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workouttime`
--

LOCK TABLES `workouttime` WRITE;
/*!40000 ALTER TABLE `workouttime` DISABLE KEYS */;
INSERT INTO `workouttime` VALUES ('PI01',1,'SMW','08:00:00','WS10'),('PI02',2,'WH','06:15:00','WS06'),('PI03',3,'TH','15:30:00','WS09'),('PI04',4,'SFA','11:20:00','WS02'),('PI05',5,'TWH','09:00:00','WS08'),('PI06',6,'TWF','09:30:00','WS04'),('PI07',7,'SWF','13:00:00','WS07'),('PI08',8,'SMT','07:45:00','WS03'),('PI09',9,'MH','10:00:00','WS01'),('PI10',10,'HFA','12:30:00','WS05');
/*!40000 ALTER TABLE `workouttime` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-07-14 23:35:49
