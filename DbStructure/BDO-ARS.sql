/*
SQLyog Community
MySQL - 5.7.14-log : Database - activityreportdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`activityreportdb` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `activityreportdb`;

/*Table structure for table `tblbdcomrequest` */

DROP TABLE IF EXISTS `tblbdcomrequest`;

CREATE TABLE `tblbdcomrequest` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Template` varchar(45) DEFAULT NULL,
  `TDelivered` int(11) DEFAULT NULL,
  `TResolved` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `tblbdcomrequest` */

insert  into `tblbdcomrequest`(`Id`,`Template`,`TDelivered`,`TResolved`) values 
(1,'INSTALLATION',0,0),
(2,'REPROGRAMMING',3,6),
(3,'SERVICING',596,1725),
(4,'REPAIR',0,0);

/*Table structure for table `tblbdpending` */

DROP TABLE IF EXISTS `tblbdpending`;

CREATE TABLE `tblbdpending` (
  `Id` int(25) NOT NULL AUTO_INCREMENT,
  `Template` varchar(255) DEFAULT NULL,
  `Day7` int(25) DEFAULT NULL,
  `Day730` int(25) DEFAULT NULL,
  `Day30` int(25) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `tblbdpending` */

insert  into `tblbdpending`(`Id`,`Template`,`Day7`,`Day730`,`Day30`) values 
(1,'1. INSTALLATION',NULL,NULL,NULL),
(2,'    A. On-hold',0,0,0),
(3,'    B. Cancelled',0,0,0),
(4,'2. REPROGRAMMING',NULL,NULL,NULL),
(5,'    A. Awaiting Payment From Merchant',0,0,3),
(6,'    B. Defective Terminal (For Repair)',0,0,0),
(7,'3. SERVICING',NULL,NULL,NULL),
(8,'    A. c/o Citas - Ongoing Call-Out',0,0,0),
(9,'    B. c/o Citas - For Repair',0,0,294),
(10,'    C. c/o BDO - Negative Call-Out / For Dispo',0,0,0);

/*Table structure for table `tblbdpendingrep` */

DROP TABLE IF EXISTS `tblbdpendingrep`;

CREATE TABLE `tblbdpendingrep` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Template` varchar(255) DEFAULT NULL,
  `Day7` int(15) DEFAULT NULL,
  `Day730` int(15) DEFAULT NULL,
  `Day30` int(15) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `tblbdpendingrep` */

insert  into `tblbdpendingrep`(`Id`,`Template`,`Day7`,`Day730`,`Day30`) values 
(1,'STEP 1. CALL-OUT & SHIPMENT FROM MERCHANT',NULL,NULL,NULL),
(3,'    B. Awaiting Shipment from Merchant',0,0,0),
(4,'STEP 2. DIAGNOSIS & JOB ORDER c/o CITAS',NULL,NULL,NULL),
(5,'    A. For Diagnosis / Job Order',0,0,0),
(8,'STEP 3. AWAITING MERCHANT PAYMENT',NULL,NULL,NULL),
(9,'    A. Awaiting Payment - Sent Job Order',0,0,0),
(10,'STEP 4. ONGOING REPAIR c/o CITAS',NULL,NULL,NULL),
(11,'    A. Ongoing Repair (Paid by Merchant)',0,0,0),
(12,'    B. Ongoing Repair  (Within Warranty)',0,0,0),
(13,'    C. Ongoing Preparation (Re-test)',0,0,0),
(14,'STEP 5. DONE REPAIR - RELEASED TO COURIER',NULL,NULL,NULL),
(15,'    A. Done Repair / Unit Received by Merchant',0,0,0),
(16,'    B. In-transit to Merchant',0,0,0);

/*Table structure for table `tblbdpenrequest` */

DROP TABLE IF EXISTS `tblbdpenrequest`;

CREATE TABLE `tblbdpenrequest` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Template` varchar(55) DEFAULT NULL,
  `Day7` int(11) DEFAULT NULL,
  `Day730` int(11) DEFAULT NULL,
  `Day30` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `tblbdpenrequest` */

insert  into `tblbdpenrequest`(`Id`,`Template`,`Day7`,`Day730`,`Day30`) values 
(1,'INSTALLATION',0,0,0),
(2,'REPROGRAMMING',0,0,3),
(3,'SERVICING',0,0,381),
(4,'REPAIR',0,0,0);

/*Table structure for table `tblinstallation` */

DROP TABLE IF EXISTS `tblinstallation`;

CREATE TABLE `tblinstallation` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Merchant_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Name` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Address` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Municipality` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Province` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Contact_Person` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Contact_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Business_Unit` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Request_Method` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Requested_By` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Action_Comments` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Airway_Bill` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Model` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Serial_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `OS_Version` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Profiled` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Terminal_Prep` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_1st_Call_Out` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_2nd_Call_Out` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_3rd_Call_Out` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Released` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received_Merchant` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Dependency_for_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_of_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Bracket` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `All_Card_Test` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reason` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `SLA` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reason_Failed_SLA` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblinstallation` */

/*Table structure for table `tblinventory` */

DROP TABLE IF EXISTS `tblinventory`;

CREATE TABLE `tblinventory` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Serial_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Delivered_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Wc_Expire` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Warranty_Claim` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Asset` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Part_Num` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Model` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Box_Num` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Released_To_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received_From_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Location` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Imported_To_MIS` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Released_Date_To` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Received_Date_From` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblinventory` */

/*Table structure for table `tblrepair` */

DROP TABLE IF EXISTS `tblrepair`;

CREATE TABLE `tblrepair` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Case_Referral` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Serial_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Name` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Unit_Ship` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Pending_Shipment` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Email_Address` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `For_Diagnosis_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Diagnosis` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Quotation_Created` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Quotation_Sent` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Receipt_of_Terminal` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_of_Billing_Quotation` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Billing_Quotation_Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Payment_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `On_Going_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `For_Preparation` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Released` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_of_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Dependency_for_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Airway_Bill_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `1st_Callback` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `2nd_Callback` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `3rd_Callback` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Bracket` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Model` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblrepair` */

/*Table structure for table `tblreprogramming` */

DROP TABLE IF EXISTS `tblreprogramming`;

CREATE TABLE `tblreprogramming` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Requested_By` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Name` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Serial_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Rep` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Contact_Number` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Address` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reprogramming_Request` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `New_TID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `New_MID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_1st_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_2nd_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_3rd_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_4th_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_5th_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Attended` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `SMS_Advisory` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Dependency_for_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_of_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Bracket` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Under_Warranty` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `CITAS_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Call_Out_SLA` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reason` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Model` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblreprogramming` */

/*Table structure for table `tblservicing` */

DROP TABLE IF EXISTS `tblservicing`;

CREATE TABLE `tblservicing` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Case_Referral` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Name` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_ID` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Rep` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchants_Contact_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchants_Address` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reported_Problem` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Problem` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Received` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_1st_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_2nd_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_3rd_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_4th_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_5th_Attempt` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Case_Resolution` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Dependency_for_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Attended` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Serial_No` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Merchant_Terminal_Send` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Ship_of_Unit` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Receipt_of_Defective_Unit` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Diagnostic_Findings` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Billing_Quotation` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Proof_of_payment` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Date_Released` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Under_Warranty` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Status_of_Repair` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Repair_Remarks` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_of_Pending` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Aging_Bracket` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `SLA` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Reason_Failed_SLA` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `Terminal_Model` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblservicing` */

/*Table structure for table `tblterminalcount` */

DROP TABLE IF EXISTS `tblterminalcount`;

CREATE TABLE `tblterminalcount` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Terminal_Model` varchar(255) DEFAULT NULL,
  `Template` varchar(255) DEFAULT NULL,
  `Completed` varchar(255) DEFAULT NULL,
  `Pending` varchar(255) DEFAULT NULL,
  `Cancelled` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblterminalcount` */

/*Table structure for table `tblusers` */

DROP TABLE IF EXISTS `tblusers`;

CREATE TABLE `tblusers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `User_Level` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tblusers` */

insert  into `tblusers`(`ID`,`Username`,`Password`,`User_Level`) values 
(1,'Rocky','Bantolo','Super Admin'),
(2,'User','User','Admin');

/* Function  structure for function  `ReplaceSpecialCharacters` */

/*!50003 DROP FUNCTION IF EXISTS `ReplaceSpecialCharacters` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `ReplaceSpecialCharacters`(p_Sql VARCHAR(255)) RETURNS varchar(255) CHARSET latin1
BEGIN
    DECLARE v_Result VARCHAR(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
    SET v_Result = p_Sql;

    SET v_Result = REPLACE(v_Result, 'ñ', 'n');
    SET v_Result = REPLACE(v_Result, 'Ñ', 'N');
    SET v_Result = REPLACE(v_Result, '\t', '');
    SET v_Result = REPLACE(v_Result, '\n', '');
    SET v_Result = REPLACE(v_Result, '\r', '');
    SET v_Result = REPLACE(v_Result, ' ', '');
    SET v_Result = REPLACE(v_Result, ',', '');
    SET v_Result = REPLACE(v_Result, "'", '');

    RETURN v_Result;
END */$$
DELIMITER ;

/* Function  structure for function  `SPLIT_STRING` */

/*!50003 DROP FUNCTION IF EXISTS `SPLIT_STRING` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `SPLIT_STRING`(str TEXT , delim VARCHAR(12) , pos INT) RETURNS text CHARSET utf8
BEGIN
    DECLARE output TEXT;
    
    SET output = REPLACE(SUBSTRING(SUBSTRING_INDEX(CONCAT(str, delim), delim, pos), 
                    LENGTH(SUBSTRING_INDEX(CONCAT(str, delim), delim, pos - 1)) + 1), delim, '');
    
    RETURN output;
END */$$
DELIMITER ;

/* Procedure structure for procedure `spBackup` */

/*!50003 DROP PROCEDURE IF EXISTS  `spBackup` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spBackup`(  
     StatementType VARCHAR(50),
     SearchPart VARCHAR(50),
     SearchBy VARCHAR(50)

)
BEGIN
	
	DECLARE v_Status VARCHAR(45);
	DECLARE p_WHERE LONGTEXT;
	DECLARE p_ORDERBY LONGTEXT;
	DECLARE p_GROUPBY LONGTEXT;
	DECLARE p_SQL LONGTEXT;
    
	IF (StatementType = 'View' )
	THEN
			IF (SearchPart = "ComRequest" )
			THEN
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', ' Template, TDelivered + TResolved as Total, TDelivered, TResolved
										     FROM tblbdcomrequest  ');

			ELSEIF (SearchPart = "PenRequest" )
			THEn
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', 'Template, 7Days + 7_30Days + 30Days AS Total, 7Days, 7_30Days, 30Days
										    FROM tblbdpenrequest  ');
								
			ELSEIF (SearchPart = "BDPending" )
			THEN
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', ' Template, 7Days + 7_30Days + 30Days As Total, 7Days, 7_30Days, 30Days
										    FROM tblbdpending  ');
								
			ELSEIF (SearchPart = "BDPenRepair" )
			THEN
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', 'Template, 7Days + 7_30Days + 30Days AS Total, 7Days, 7_30Days, 30Days
										   FROM tblbdpendingrep');
										    
			ELSEIF (SearchPart = "TerminalStatus" )
			THEN
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', 'ID, Terminal_Model, Template, Completed, Pending 
										   FROM tblterminalcount ');
										 									    
			end if;
			
				
	ELSEIF (StatementType = "Count")
	THEN
	
			IF (SearchPart = "Terminal Inventory" )
			THEN

				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', ' COUNT(ID) AS Total
										    FROM tblinventory
										    WHERE Model LIKE "%" ', SearchBy, ' "%" ');
										   				
			END IF;
	/*	
		ELSEIF ( p_SearchBy = 'Citas' )
		THEN
						
			IF 	  ( p_SearchPart = "BdComRequest" )
			THEN		    
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', ' Template, TDelivered + TResolved as TOTAL, TDelivered, TResolved
										FROM tblbdcomrequest ');

			ELSEIF ( p_SearchPart = "BdPenRequest" )
			THEN		    
				SET p_SQL = '';	
				SET p_SQL = CONCAT ( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT ( p_SQL, ' ', ' Template, 7DAYS + 7_30DAYS + 30DAYS AS TOTAL, 7DAYS, 7_30DAYS, 30DAYS
										FROM tblbdpenrequest ');

			ELSEIF ( p_SearchPart = "BdPendings" )
			THEN		    
				SET p_SQL = '';	
				SET p_SQL = CONCAT( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT( p_SQL, ' ', ' Template, 7DAYS + 7_30DAYS + 30DAYS AS TOTAL, 7DAYS, 7_30DAYS, 30DAYS
										FROM tblbdpending ');
								 
			ELSEIF ( p_SearchPart = "BdpRepair" )
			THEN		    
				SET p_SQL = '';	
				SET p_SQL = CONCAT( p_SQL, ' SELECT ' );
				SET p_SQL = CONCAT( p_SQL, ' ', ' Template, 7DAYS + 7_30DAYS + 30DAYS AS TOTAL, 7DAYS, 7_30DAYS, 30DAYS
										FROM tblbdpendingrep ');
			END IF; 
		
		
			IF ( p_SearchPart = "INSTALLATION" )
			THEN		    
				SET p_SQL = '';	
				SET p_SQL = CONCAT(p_SQL,'SELECT');
				SET p_SQL = CONCAT(p_SQL, ' ', 'Status_Remarks, Dependency_for_Pending, `Status`,
								SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) <=7  THEN 1 ELSE 0 END) AS 7DAYS,							 
								SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) BETWEEN 8 AND 30 THEN 1 ELSE 0 END) AS 7_30DAYS,
								SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) > 30 THEN 1 ELSE 0 END) AS 30DAYS,						  
								SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) <=7  THEN 1 ELSE 0 END)
								+ SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) > 7  AND
								   DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d"))< 30 THEN 1 ELSE 0 END)
								+ SUM(CASE WHEN DATEDIFF (CURRENT_DATE,DATE_FORMAT(STR_TO_DATE(Date_Request_Received, "%m/%d/%Y"), "%Y-%m-%d")) > 30 THEN 1 ELSE 0 END) AS TOTAL

								FROM tblinstallation
								GROUP BY Status_Remarks ORDER BY `Status` DESC');
			END IF;
			
		*/
																
			#SELECT CONCAT('Before:Len(p_SQL) = ', LENGTH(p_SQL));
			SELECT CONCAT('Before:p_SQL = ', p_SQL);
						
			SET p_SQL = REPLACE(p_SQL, '"', "'");
			#SELECT CONCAT('After:Len(p_SQL) = ', LENGTH(p_SQL));
			#SELECT CONCAT('After:p_SQL = ', p_SQL);	

			SET @QUERY = p_SQL;
			# Execute Query 
			PREPARE QUERY FROM @QUERY;
			EXECUTE QUERY;
								
	
	END IF;    
END */$$
DELIMITER ;

/* Procedure structure for procedure `spCollectionDelete` */

/*!50003 DROP PROCEDURE IF EXISTS  `spCollectionDelete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spCollectionDelete`(
    IN StatementType VARCHAR(255),
    IN SearchBy VARCHAR(255),
    IN SearchValue VARCHAR(255)
)
BEGIN  

DECLARE v_ID INTEGER;

DECLARE p_WHERE longtext;
DECLARE p_GROUPBY longtext;
DECLARE p_ORDERBY longtext;

START TRANSACTION;

IF (StatementType = 'Delete') 
THEN  		
	case SearchBy
	
		when 'Installation' then
		
			SET @QUERY = CONCAT("TRUNCATE TABLE tblinstallation");	
		
		when 'Reprogramming' then
		
			SET @QUERY = CONCAT("TRUNCATE TABLE tblreprogramming");	
		
		when 'Servicing' then
		
			SET @QUERY = CONCAT("TRUNCATE TABLE tblservicing");	
		
		when 'Repair'then
		
			SET @QUERY = CONCAT("TRUNCATE TABLE tblrepair");		
							
		when'Inventory' then
		
			SET @QUERY = CONCAT("TRUNCATE TABLE tblinventory");	
	END case;          

	# Execute Query 
	PREPARE QUERY FROM @QUERY;
	EXECUTE QUERY;	

END IF; 

COMMIT;
       
END */$$
DELIMITER ;

/* Procedure structure for procedure `spCollectionDetails` */

/*!50003 DROP PROCEDURE IF EXISTS  `spCollectionDetails` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spCollectionDetails`( 
     p_StatementType VARCHAR(50),
     p_SearchBy VARCHAR(50),
     p_SearchValue VARCHAR(50)
)
BEGIN  
	
	declare v_SearchBy longtext;
	DECLARE v_ViewBy LONGTEXT;
	
	#SET v_Column = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,1));
	
	IF (p_StatementType = "View") THEN
	
		SET v_SearchBy  = TRIM(SPLIT_STRING(p_SearchBy, '|' ,1));
		SET v_ViewBy  = TRIM(SPLIT_STRING(p_SearchBy, '|' ,2));

		#SELECT v_SearchBy;
		#SELECT v_ViewBy;
		
		CASE v_SearchBy 
					
			WHEN "Source" THEN
				
				case v_ViewBy
									
					when "Info" then
					
						call `spViewSourceDetails`(p_StatementType, v_ViewBy, p_SearchValue);
					
					WHEN "Inventory" THEN
					
						CALL `spViewSourceDetails`(p_StatementType, v_ViewBy, p_SearchValue);

				End case;
				
							
			WHEN "Terminal" THEN
				
				CASE v_ViewBy
									
					WHEN "Completed" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
						
					WHEN "Pending" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
						
					WHEN "Bd of Pending" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
						
					WHEN "Bd of Pending Repair" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
						
					WHEN "Status" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
					
					WHEN "History" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
											
					WHEN "Summary" THEN
					
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
						
					WHEN "Status Summary" THEN
						
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
					
					WHEN "Status Remarks" THEN
								
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
					
					WHEN "Duplicate Request" THEN
								
						CALL `spViewTerminalDetails`(p_StatementType, v_ViewBy, p_SearchValue);
										
				END CASE;
				
				
							
		END CASE;
				
	END IF;
	
	
	#SELECT (CONCAT('Query = ' , v_SearchBy));
							       			
END */$$
DELIMITER ;

/* Procedure structure for procedure `spCollectionInsert` */

/*!50003 DROP PROCEDURE IF EXISTS  `spCollectionInsert` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spCollectionInsert`(
    IN StatementType VARCHAR(50),
    IN SearchBy VARCHAR(50),
    IN SearchValue VARCHAR(50),
    IN pSQL LONGTEXT,
    OUT outErrorMessage VARCHAR(200),
    OUT outLastInsertID INT
)
BEGIN
    DECLARE v_LastID INT;
    declare v_Sql varchar(255);
    
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            GET DIAGNOSTICS CONDITION 1
                outErrorMessage = MESSAGE_TEXT;
        END;

    START TRANSACTION;
    
    IF (StatementType = 'Insert') THEN
    
	#v_Sql = RemoveSpecialCharacters(p_Sql);
	
        CASE SearchBy
        
            WHEN 'Installation' THEN
            
                SET @Query = CONCAT('INSERT INTO tblinstallation
                (
                    Merchant_ID, Terminal_ID, Merchant_Name, Address, Municipality,
                    Province, Contact_Person, Contact_No, Business_Unit, Request_Method,
                    Requested_By, Action_Comments, Terminal_Status, Airway_Bill,
                    Terminal_Model, Serial_No, OS_Version, Date_Received, Date_Profiled,
                    Date_Terminal_Prep, Date_1st_Call_Out, Date_2nd_Call_Out,
                    Date_3rd_Call_Out, Date_Released, Date_Received_Merchant, Status,
                    Status_Remarks, Dependency_for_Pending, Aging_of_Pending,
                    Aging_Bracket, All_Card_Test, Reason, SLA, Reason_Failed_SLA
                )
                VALUES ', v_Sql);

            WHEN 'Reprogramming' THEN
            
                SET @Query = CONCAT('INSERT INTO tblreprogramming
                (
                    Requested_By, Merchant_Name, Terminal_ID, Merchant_ID, Serial_No,
                    Merchant_Rep, Merchant_Contact_Number, Merchant_Address,
                    Reprogramming_Request, New_TID, New_MID, Date_Received,
                    Date_1st_Attempt, Date_2nd_Attempt, Date_3rd_Attempt,
                    Date_4th_Attempt, Date_5th_Attempt, Date_Attended, SMS_Advisory,
                    Status, Status_Remarks, Dependency_for_Pending, Aging_of_Pending,
                    Aging_Bracket, Under_Warranty, CITAS_Remarks, Call_Out_SLA, Reason,
                    Terminal_Model
                )
                VALUES ', v_Sql);

            WHEN 'Servicing' THEN
            
                SET @Query = CONCAT('INSERT INTO tblservicing
                (
                    Case_Referral, Merchant_Name, Terminal_ID, Merchant_ID,
                    Merchant_Rep, Merchants_Contact_No, Merchants_Address,
                    Reported_Problem, Terminal_Problem, Date_Received, Date_1st_Attempt,
                    Date_2nd_Attempt, Date_3rd_Attempt, Date_4th_Attempt, Date_5th_Attempt,
                    Case_Resolution, Status, Status_Remarks, Dependency_for_Pending,
                    Date_Attended, Serial_No, Merchant_Terminal_Send,
                    Date_Ship_of_Unit, Date_Receipt_of_Defective_Unit,
                    Diagnostic_Findings, Date_Billing_Quotation,
                    Date_Proof_of_payment, Date_Released, Under_Warranty,
                    Status_of_Repair, Repair_Remarks, Aging_of_Pending, Aging_Bracket,
                    SLA, Reason_Failed_SLA, Terminal_Model
                )
                VALUES ', v_Sql);

            WHEN 'Repair' THEN
            
                SET @Query = CONCAT('INSERT INTO tblrepair
                (
                    Case_Referral, Serial_No, Merchant_ID, Terminal_ID, Merchant_Name,
                    Merchant_Unit_Ship, Aging_Pending_Shipment, Email_Address,
                    Date_Received, For_Diagnosis_Repair, Diagnosis,
                    Date_Quotation_Created, Date_Quotation_Sent, Aging_Receipt_of_Terminal,
                    Aging_of_Billing_Quotation, Billing_Quotation_Status,
                    Date_Payment_Received, On_Going_Repair, For_Preparation, Date_Released,
                    Aging_of_Repair, Status_Remarks, Status, Dependency_for_Pending,
                    Remarks, Airway_Bill_No, 1st_Callback, 2nd_Callback, 3rd_Callback,
                    Aging_Bracket, Terminal_Model
                )
                VALUES ', v_Sql);

            WHEN 'Inventory' THEN
            
                SET @Query = CONCAT('INSERT INTO tblinventory
                (
                    Serial_No, Date_Delivered_Received, Date_Wc_Expire, Warranty_Claim,
                    Asset, Part_Num, Model, Box_Num, Status, Date_Released_To_Repair,
                    Date_Received_From_Repair, Remarks, Location, Imported_To_MIS,
                    Released_Date_To, Received_Date_From, Aging
                )
                VALUES ', v_Sql);
                
        END CASE;
        
        PREPARE stmt FROM @Query;
	EXECUTE stmt;
	DEALLOCATE PREPARE stmt;

        SET outErrorMessage = '';
        
        SELECT LAST_INSERT_ID() INTO v_LastID;
        SET outLastInsertID = IFNULL(v_LastID, 0);
        
    END IF;
    
    COMMIT;
    
END */$$
DELIMITER ;

/* Procedure structure for procedure `spCollectionUpdate` */

/*!50003 DROP PROCEDURE IF EXISTS  `spCollectionUpdate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spCollectionUpdate`(  
    StatementType VARCHAR(30) /* = NULL */,
	SearchBy VARCHAR(50), /* = NULL */
	SearchValue VARCHAR(50), /* = NULL */
	pSql Varchar(50)
)
BEGIN
	
	IF ( StatementType = 'Update' )
	THEN	
			
		IF ( SearchBy = 'Dashboard' )
		THEN
		
		#BdComRequest
			
				 # -------- ( "Search Flag" , " Date_Column | Column_1 | Column_2 | Column_3 " , " ( Value_1 | Value 2 ) | Value 3 | Value 4 " , " SearchAgeBracket " )
				SET @Delivered = 0, @Resolved = 0;
				
				# INSTALLATION -----------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery("1","tblinstallation","|Status_Remarks|","Delivered|Picked up",""); 			SET @Delivered = @v_Result;
				/*CALL spFuncSearchQuery("1","tblinstallation","|Status_Remarks|","Resolved","");*/ 				SET @Resolved = 0;
				
				UPDATE tblbdcomrequest SET TDelivered = @Delivered, TResolved = @Resolved 					WHERE Template = "INSTALLATION"; 
																		SET @Delivered = 0, @Resolved = 0;
				
				# REPROGRAMMING -------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery("2","tblreprogramming","|Status_Remarks|","Done Repair","");				SET @Delivered = @v_Result;
				CALL spFuncSearchQuery("2","tblreprogramming","|Status_Remarks|","Resolved",""); 				SET @Resolved = @v_Result;
				
				UPDATE tblbdcomrequest SET TDelivered = @Delivered, TResolved = @Resolved 					WHERE Template = "REPROGRAMMING"; 
																		SET @Delivered = 0, @Resolved = 0;
				
				# SERVICING ----------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery("2","tblservicing","|Status_Remarks|","Done",""); 					SET @Delivered = @v_Result;
				CALL spFuncSearchQuery("2","tblservicing","|Status_Remarks|","Resolved","");  					SET @Resolved = @v_Result;
				
				UPDATE tblbdcomrequest SET  TDelivered = @Delivered, TResolved = @Resolved 					WHERE Template = "SERVICING";
																		SET @Delivered = 0, @Resolved = 0;
				
				# REPAIR --------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery("2","tblrepair","|Status_Remarks|","Unit Received",""); 					SET @Delivered = @v_Result;
				#CALL spFuncSearchQuery("2","tblrepair","|Status_Remarks|","Done",""); 						SET @Resolved = @v_Result;
				
				UPDATE tblbdcomrequest SET  TDelivered = @Delivered, TResolved = @Resolved 					WHERE Template = "REPAIR";
																		SET @Delivered = 0, @Resolved = 0;
		#BdPenRequest
				
				# -------------------- ("Search Flag" , "Date_Column | Column_1 | Column_2 " , "Value_1 | Value 2 | Value 3" , "SearchAgeBracket")
				SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				# INSTALLATION --------------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery ("1","tblinstallation","Date_Received|Status","Pending|Cancelled","7Days"); 			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblinstallation","Date_Received|Status","Pending|Cancelled","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblinstallation","Date_Received|Status","Pending|Cancelled","30Days"); 			SET @30Days = @v_Result;
				
				UPDATE tblbdpenrequest SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 						WHERE Template = "INSTALLATION";
																			SET @7Days = 0, @7_30Days = 0, @30Days = 0;

				# REPROGRAMMING -----------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery ("1","tblreprogramming","Date_Received|Status","Pending|Cancelled","7Days"); 			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblreprogramming","Date_Received|Status","Pending|Cancelled","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblreprogramming","Date_Received|Status","Pending|Cancelled","30Days"); 			SET @30Days = @v_Result;
				
				UPDATE tblbdpenrequest SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 						WHERE Template = "REPROGRAMMING";
																			SET @7Days = 0, @7_30Days = 0, @30Days = 0;

				# SERVICING --------------------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery ("1","tblservicing","Date_Received|Status","Pending|Cancelled","7Days"); 			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblservicing","Date_Received|Status","Pending|Cancelled","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblservicing","Date_Received|Status","Pending|Cancelled","30Days"); 			SET @30Days = @v_Result;
				
				UPDATE tblbdpenrequest SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  						WHERE Template = "SERVICING";
																			SET @7Days = 0, @7_30Days = 0, @30Days = 0;

				# REPAIR  ------------------------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery ("1","tblrepair","Date_Received|Status","Pending|Cancelled","7Days"); 				SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblrepair","Date_Received|Status","Pending|Cancelled","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("1","tblrepair","Date_Received|Status","Pending|Cancelled","30Days"); 				SET @30Days = @v_Result;
				
				UPDATE tblbdpenrequest SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  						WHERE Template = "REPAIR";
																			SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
		#BdPending
			
				SET @7Days = 0, @7_30Days = 0, @30Days = 0;
			
				# INSTALLATION ------------------------------------------------------------------------------------------------------------------------------------------------------------------------
				
				SET @7DAYS := 0, @7_30DAYS := 0, @30DAYS := 0;	
				
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Hold | Pending","7Days"); 			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Hold | Pending","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Hold | Pending","30Days"); 			SET @30Days = @v_Result;
			
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  								WHERE ID = 2; 	/*A. On Hold */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
																																				
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Cancelled | Cancelled","7Days"); 		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Cancelled | Cancelled","7_30Days"); 		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblinstallation","Date_Received | Status_Remarks | Status","Cancelled | Cancelled","30Days"); 		SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 								WHERE ID = 3; 	/*B. Cancelled */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;

				# REPROGRAMMING --------------------------------------------------------------------------------------------------------------------------------------------------------------------
				
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","Awaiting Payment | Pending","7Days"); 	SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","Awaiting Payment | Pending","7_30Days"); 	SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","Awaiting Payment | Pending","30Days"); 	SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  								WHERE ID = 5; 	/* A. Awaiting Payment From Merchant */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","For Repair | Pending","7Days"); 		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","For Repair | Pending","7_30Days"); 		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblreprogramming","Date_Received | Status_Remarks | Status","For Repair | Pending","30Days"); 		SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 								WHERE ID = 6; 	/* B. Defective Terminal (For Repair) */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
							
				# SERVICING -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
				
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Pending Call Out | Pending","7Days"); 		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Pending Call Out | Pending","7_30Days"); 		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Pending Call Out | Pending","30Days"); 		SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  								WHERE ID = 8; 	/* A. c/o Citas - Ongoing Call-Out */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","For Repair | Pending","7Days"); 			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","For Repair | Pending","7_30Days"); 		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","For Repair | Pending","30Days"); 			SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  								WHERE ID = 9; 	/* B. c/o Citas - For Repair */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Negative | Pending","7Days");			SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Negative | Pending","7_30Days"); 			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblservicing","Date_Received | Status_Remarks | Status","Negative | Pending","30Days"); 			SET @30Days = @v_Result;
				
				UPDATE tblbdpending SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  								WHERE ID = 10; 	/* C. c/o BDO - Negative Call-Out / For Dispo */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0; 
			
		#BdPendingRep
			
				SET @7Days = 0, @7_30Days = 0, @30Days = 0;
			
				# REPAIR -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
				CALL spFuncSearchQuery ("2","tblrepair","Merchant_Unit_Ship | Status_Remarks | Dependency_for_Pending","Awaiting Unit from Merchant | Merchant Dependency - Awaiting Shipment","7Days");		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Merchant_Unit_Ship | Status_Remarks | Dependency_for_Pending","Awaiting Unit from Merchant | Merchant Dependency - Awaiting Shipment","7_30Days");		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Merchant_Unit_Ship | Status_Remarks | Dependency_for_Pending","Awaiting Unit from Merchant | Merchant Dependency - Awaiting Shipment","30Days");		SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 															WHERE ID = 3; /* A. Awaiting Shipment from Merchant */
																													SET @7Days = 0, @7_30Days = 0, @30Days = 0;
						
				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Diagnosis | Pending","7Days"); 			SET @D_7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Diagnosis | Pending","7_30Days"); 		SET @D_7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Diagnosis | Pending","30Days"); 			SET @D_30Days = @v_Result;

				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Job Order | Pending","7Days");			SET @J_7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Job Order | Pending","7_30Days"); 		SET @J_7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Received | Status_Remarks | Status","For Job Order | Pending","30Days"); 			SET @J_30Days = @v_Result;

				SET @7Days := (@D_7Days + @J_7Days), @7_30Days := (@D_7_30Days + @J_7_30Days), @30Days := (@D_30Days + @J_30Days);
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 								WHERE ID = 5; /* A. For Diagnosis / For Job Order */
																					SET @7Days = 0, @7_30Days = 0, @30Days = 0;
																																						SET @D_7Days:=0, @J_7Days:=0, @D_7_30Days:=0, @J_7_30Days:=0, @D_30Days:=0, @J_30Days:=0;
				
				
				CALL spFuncSearchQuery ("2","tblrepair","Date_Quotation_Sent | Status_Remarks | Status","Awaiting payment | Pending","7Days");				SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Quotation_Sent | Status_Remarks | Status","Awaiting payment | Pending","7_30Days");			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Quotation_Sent | Status_Remarks | Status","Awaiting payment | Pending","30Days");				SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 										WHERE ID = 9; /* A. Awaiting Payment - Sent Job Order */
																							SET @7Days = 0, @7_30Days = 0, @30Days = 0;
			
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (paid by merchant) | Pending","7Days");		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (paid by merchant) | Pending","7_30Days");	SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (paid by merchant) | Pending","30Days");		SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  										WHERE ID = 11; /* A. Ongoing Repair (Paid by Merchant) */
																							SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (Within Warranty) | Pending","7Days");		SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (Within Warranty) | Pending","7_30Days");		SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Repair (Within Warranty) | Pending","30Days");		SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 										WHERE ID = 12; /* B. Ongoing Repair  (Within Warranty) */
																																						SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Prep | Pending","7Days");				SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Prep | Pending","7_30Days");				SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Payment_Received | Status_Remarks | Status","For Prep | Pending","30Days");				SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days  										WHERE ID = 13; /* C. Ongoing Preparation (Re-test) */
																							SET @7Days = 0, @7_30Days = 0, @30Days = 0;
				
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status","Completed","7Days");									SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status","Completed","7_30Days");								SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status","Completed","30Days");									SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 										WHERE ID = 15; /* A. Done Repair */
																							SET @7Days = 0, @7_30Days = 0, @30Days = 0;
																																						
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status_Remarks | Status","In-transit to Merchant | Pending","7Days");				SET @7Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status_Remarks | Status","In-transit to Merchant | Pending","7_30Days");			SET @7_30Days = @v_Result;
				CALL spFuncSearchQuery ("2","tblrepair","Date_Released | Status_Remarks | Status","In-transit to Merchant | Pending","30Days");				SET @30Days = @v_Result;
				
				UPDATE tblbdpendingrep SET Day7 = @7Days, Day730 = @7_30Days, Day30 = @30Days 										WHERE ID = 16; /* B. In Transit to Merchant */
																							SET @7Days = 0, @7_30Days = 0, @30Days = 0;
		#TerminalCount
			
				/*--------------- MP200 ------------*/
				
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Completed | MP200","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Pending | MP200","");				SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Cancelled | MP200","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 1;
																				SET @Completed= 0, @Pending = 0, @Cancelled = 0;
				
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Completed | MP200","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Pending | MP200","");				SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Cancelled | MP200","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 2;
																				SET @Completed= 0, @Pending = 0, @Cancelled = 0;
																																					
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Completed | MP200","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Pending | MP200","");					SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Cancelled | MP200","");				SET @Cancelled = @v_Result;
																																			
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 3;
																				SET @Completed= 0, @Pending = 0, @Cancelled = 0;
				
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Completed | MP200","");					SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Pending | MP200","");					SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Cancelled | MP200","");					SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 4;
																				SET @Completed= 0, @Pending = 0, @Cancelled = 0;
																																	
				/*--------------- S1E MINI ------------*/
																																
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Completed | S1E MINI","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Pending | S1E MINI","");				SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblinstallation"," | Status | Terminal_Model ","Cancelled | S1E MINI","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 5;
																																		SET @Completed= 0, @Pending = 0, @Cancelled = 0;
																																	
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Completed | S1E MINI","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Pending | S1E MINI","");				SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblreprogramming"," | Status | Terminal_Model ","Cancelled | S1E MINI","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 6;
																																		SET @Completed= 0, @Pending = 0, @Cancelled = 0;
																																	
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Completed | S1E MINI","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Pending | S1E MINI","");				SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblservicing"," | Status | Terminal_Model ","Cancelled | S1E MINI","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 7;
																																		SET @Completed= 0, @Pending = 0, @Cancelled = 0;
																																	
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Completed | S1E MINI","");				SET @Completed = @v_Result;
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Pending | S1E MINI","");					SET @Pending = @v_Result;
				CALL spFuncSearchQuery("2","tblrepair"," | Status | Terminal_Model ","Cancelled | S1E MINI","");				SET @Cancelled = @v_Result;
				
				UPDATE tblterminalcount SET Completed = @Completed, Pending = @Pending, Cancelled = @Cancelled					WHERE ID = 8;
																																		SET @Completed= 0, @Pending = 0, @Cancelled = 0;																														
																													
																																	
				
		END IF;
			
			/*
			
		ELSEIF (p_SearchBy = 'Citas')
		THEN
			
			IF  ( p_SearchPart = ' BdComRequest ' )
			THEN
				
			ELSEIF  ( p_SearchPart = ' BdPenRequest ' )
			THEN
				
			ELSEIF  ( p_SearchPart = ' BdPending ' )
			THEN
				
			ELSEIF  ( p_SearchPart = ' BdPendingRep ' )
			THEN
				
			END IF;
			*/
	END IF;    
	
END */$$
DELIMITER ;

/* Procedure structure for procedure `spFuncSearchDate` */

/*!50003 DROP PROCEDURE IF EXISTS  `spFuncSearchDate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spFuncSearchDate`( 
		 p_Tablename VARCHAR(255) /* = NULL */,
		 p_SearchValue VARCHAR(255) /* = NULL */

)
BEGIN
	
	DECLARE v_Tablename VARCHAR(255);
	declare v_DateColumn varchar(255);
	DECLARE v_DateFrom VARCHAR(255);
	DECLARE v_DateTo VARCHAR(255);

	DECLARE p_WHERE LONGTEXT;
	declare p_GROUPBY longtext;
	DECLARE p_SQL LONGTEXT;


		SET v_Tablename = p_Tablename;
		
		SET v_DateFrom = TRIM(SPLIT_STRING( p_SearchValue, '|' ,1));
		SET v_DateTo = TRIM(SPLIT_STRING( p_SearchValue, '|' ,2));

		SET p_WHERE = '';

		IF ( strcmp ( v_DateFrom, '0000-00-00' ) != 0 && strcmp ( v_DateTo, '0000-00-00' ) != 0) 
		THEN
		
			SET p_WHERE = CONCAT( p_WHERE, 'DATE_FORMAT(STR_TO_DATE(Date_Released' );
			SET p_WHERE = CONCAT( p_WHERE, ' ', ',"%m-%d-%Y"), "%Y-%m-%d") BETWEEN' );
			SET p_WHERE = CONCAT( p_WHERE, ' ','CAST(', "'", v_DateFrom , "'", ' AS DATE) AND CAST(',  "'" ,v_DateTo , "'" , ' AS DATE)' );

		END IF;
		


		#DEBUG
		#SELECT CONCAT('Before:Len(p_WHERE) = ', LENGTH(p_WHERE));
		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);

		SET p_SQL = '';
		SET p_SQL = CONCAT(p_SQL, 'Select' );
		SET p_SQL = CONCAT(p_SQL, ' ' , 'Terminal_Model, Status, COUNT(ID) As Total' );
		SET p_SQL = CONCAT(p_SQL, ' ' , 'From' );
		SET p_SQL = CONCAT(p_SQL, ' ' , v_Tablename );


		IF (LENGTH(p_WHERE) > 0)
		THEN
			SET p_SQL = CONCAT(p_SQL, ' ', 'WHERE');
			SET p_SQL = CONCAT(p_SQL, ' ', p_WHERE);
		END IF;
		
				
		SET p_GROUPBY = '';	
		SET p_GROUPBY = 'Terminal_Model, Status';
		
		IF ( LENGTH( p_GROUPBY) > 0 )
		THEN
			SET p_SQL = CONCAT( p_SQL, ' ', 'GROUP BY' );
			SET p_SQL = CONCAT( p_SQL, ' ', p_GROUPBY );
		END IF;

		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);
		#SELECT CONCAT('Before:p_SQL = ', p_SQL);

		#Execute Query
		SET @QUERY = p_SQL;
		PREPARE QUERY FROM @QUERY;
		EXECUTE QUERY;

END */$$
DELIMITER ;

/* Procedure structure for procedure `spFuncSearchQuery` */

/*!50003 DROP PROCEDURE IF EXISTS  `spFuncSearchQuery` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spFuncSearchQuery`( 
		IN p_SearchOption VARCHAR(255) /* = NULL */,
		IN p_Tablename VARCHAR(255) /* = NULL */,
		IN p_SearchColumn VARCHAR(255) /* = NULL */,
		IN p_SearchValue VARCHAR(255) /* = NULL */,
		IN p_SearchByDays VARCHAR(255) /* = NULL */

)
BEGIN
	
	DECLARE v_Tablename VARCHAR(255);
	DECLARE v_Column1 VARCHAR(255);
	DECLARE v_Column2 VARCHAR(255);
	DECLARE v_Column3 VARCHAR(255);
	DECLARE v_Column4 VARCHAR(255);
	
	DECLARE v_DateColumn VARCHAR(255);
	DECLARE v_SearchVal1 VARCHAR(255);
	DECLARE v_SearchVal2 VARCHAR(255);
	DECLARE v_SearchVal3 VARCHAR(255);
	DECLARE v_SearchVal4 VARCHAR(255);
	DECLARE v_SearchOption VARCHAR(255);


	DECLARE p_WHERE LONGTEXT;
	DECLARE p_ORDERBY LONGTEXT;
	DECLARE p_GROUPBY LONGTEXT;
	DECLARE p_SQL LONGTEXT;


		SET v_Tablename = p_Tablename;
		set v_SearchOption = p_SearchOption;
		SET @v_Result = null;


		SET v_DateColumn = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,1));
		SET v_Column1 = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,2));
		SET v_Column2 = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,3));
		SET v_Column3 = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,4));

		SET v_SearchVal1 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,1));
		SET v_SearchVal2 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,2));
		SET v_SearchVal3 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,3));
		SET v_SearchVal4 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,4));
			
				

		# Option 1: Search Multilple Value
		IF (v_SearchOption = "1")
		THEN

			SET p_WHERE = '';
	
			IF ( LENGTH( v_SearchVal1 ) > 0 && length( v_Column1 ) > 0 )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column1 ,' IN' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "(" '"', v_SearchVal1 , '"' " , " '"', v_SearchVal2 , '"' ")" );
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;

			IF ( LENGTH( v_SearchVal3 ) > 0 && LENGTH( v_Column2 ) > 0 )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column2 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal3, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;
			
			IF ( LENGTH( v_SearchVal4 ) > 0 && LENGTH( v_Column3 ) > 0 )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column3 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal4, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;

			IF ( LENGTH(v_DateColumn) = 0 )
			THEN
				SET p_WHERE = LEFT(p_WHERE, LENGTH(p_WHERE) - 4); # Remove AND from END of WHERE CLAUSE
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');
			END IF;
			
		end if;
		
		# Option 2: Search By Index
		IF (v_SearchOption = "2")
		THEN

			SET p_WHERE = '';

			if ( LENGTH( v_SearchVal1 ) > 0 && LENGTH( v_Column1 ) > 0) 
			then
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column1 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal1, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			end if;

			IF ( length( v_SearchVal2 ) > 0 && LENGTH( v_Column2 ) > 0)
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column2 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal2, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;
			
			IF ( LENGTH( v_SearchVal3 ) > 0 && LENGTH( v_Column3 ) > 0) 
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column3 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal3, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;
			
			IF ( LENGTH(v_DateColumn) = 0)
			THEN
				SET p_WHERE = LEFT(p_WHERE, LENGTH(p_WHERE) - 4); # Remove AND from END of WHERE CLAUSE
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');
			END IF;

		END IF;

		# Option 3: Search By Value
		IF (v_SearchOption = "3")
		THEN

			SET p_WHERE = '';

			IF ( LENGTH( v_SearchVal1 ) > 0 && LENGTH( v_Column1 ) > 0) 
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column1 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal1, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'OR');
			END IF;

			IF ( LENGTH( v_SearchVal2 ) > 0 && LENGTH( v_Column2 ) > 0)
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column2 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal2, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'OR');
			END IF;
			
			IF ( LENGTH( v_SearchVal3 ) > 0 && LENGTH( v_Column3 ) > 0) 
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column3 ,' LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal3, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'OR');
			END IF;

					
			IF ( LENGTH(v_DateColumn) = 0)
			THEN
				SET p_WHERE = LEFT(p_WHERE, LENGTH(p_WHERE) - 3); # Remove OR from END of WHERE CLAUSE
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');
				
			else
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;

		END IF;
		
		#Check Age By Bracket
		IF ( length(v_DateColumn) > 0 )
		THEN 

			IF (p_SearchByDays = '7Days' )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ','DATEDIFF (CURRENT_DATE,DATE_FORMAT (STR_TO_DATE(');
				SET p_WHERE = CONCAT(p_WHERE,	 v_DateColumn );
				SET p_WHERE = CONCAT(p_WHERE,  ', "%m-%d-%Y"), "%Y-%m-%d")) <=7');
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');

			ELSEIF (p_SearchByDays = '7_30Days' )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ','DATEDIFF (CURRENT_DATE,DATE_FORMAT (STR_TO_DATE(');
				SET p_WHERE = CONCAT(p_WHERE,	 v_DateColumn );
				SET p_WHERE = CONCAT(p_WHERE,  ', "%m-%d-%Y"), "%Y-%m-%d")) BETWEEN 8 AND 30');
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');

			ELSEIF (p_SearchByDays = '30Days' )
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ','DATEDIFF (CURRENT_DATE,DATE_FORMAT (STR_TO_DATE(');
				SET p_WHERE = CONCAT(p_WHERE,	 v_DateColumn );
				SET p_WHERE = CONCAT(p_WHERE,  ', "%m-%d-%Y"), "%Y-%m-%d")) > 30');
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'INTO @v_Result');
			END IF;

		END IF;

		#DEBUG
		#SELECT CONCAT('Before:Len(p_WHERE) = ', LENGTH(p_WHERE));
		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);

		SET p_SQL = '';
		SET p_SQL = CONCAT(p_SQL,'SELECT');
		SET p_SQL = CONCAT(p_SQL, ' ', 'COUNT(ID)');
		SET p_SQL = CONCAT(p_SQL, ' ', 'FROM');
		SET p_SQL = CONCAT(p_SQL, ' ', v_Tablename);

		IF (LENGTH(p_WHERE) > 0)
		THEN
			SET p_SQL = CONCAT(p_SQL, ' ', 'WHERE');
			SET p_SQL = CONCAT(p_SQL, ' ', p_WHERE);
		END IF;

		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);
		#SELECT CONCAT('Before:p_SQL = ', p_SQL);

		#Execute Query
		SET @QUERY = p_SQL;
		PREPARE QUERY FROM @QUERY;
		EXECUTE QUERY;


END */$$
DELIMITER ;

/* Procedure structure for procedure `spFuncSearchStatus` */

/*!50003 DROP PROCEDURE IF EXISTS  `spFuncSearchStatus` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spFuncSearchStatus`( 
		 p_Tablename VARCHAR(255) /* = NULL */,
		 p_Columname VARCHAR(255) /* = NULL */,
		 p_SearchValue VARCHAR(255) /* = NULL */

)
BEGIN
	
	DECLARE v_Tablename VARCHAR(255);
	DECLARE v_Column1 VARCHAR(255);
	DECLARE v_Column2 VARCHAR(255);
	declare v_Date_Column VARCHAR(255);
	
	DECLARE v_SearchVal1 VARCHAR(255);
	DECLARE v_SearchVal2 VARCHAR(255);
	DECLARE v_SearchVal3 VARCHAR(255);
	DECLARE v_SearchVal4 VARCHAR(255);

	DECLARE p_WHERE LONGTEXT;
	DECLARE p_SQL LONGTEXT;


		SET v_Tablename = p_Tablename;
		
		SET v_Column1 = TRIM(SPLIT_STRING( p_Columname, '|' ,1));
		SET v_Column2 = TRIM(SPLIT_STRING( p_Columname, '|' ,2));

		SET v_SearchVal1 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,1));
		SET v_SearchVal2 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,2));
		
		set v_SearchVal3 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,3));
		SET v_SearchVal4 = TRIM(SPLIT_STRING( p_SearchValue, '|' ,4));


		SET p_WHERE = '';

		IF ( LENGTH( v_SearchVal1 ) > 0 && LENGTH( v_Column1 ) > 0) 
		THEN
			SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column1 ,' Like' );
			SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal1, "%'");
			SET p_WHERE = CONCAT(p_WHERE, ' ', 'And');
		END IF;

		IF ( LENGTH( v_SearchVal2 ) > 0 && LENGTH( v_Column2 ) > 0)
		THEN
			SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column2 ,' Like' );
			SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_SearchVal2, "%'");
			SET p_WHERE = CONCAT(p_WHERE, ' ', 'And');
		END IF;

		SET p_WHERE = LEFT(p_WHERE, LENGTH(p_WHERE) - 4); # Remove AND from END of WHERE CLAUSE

		IF ( LENGTH( v_SearchVal3 ) > 0 && LENGTH( v_Column1 ) > 0 )
		THEN
			SET p_WHERE = CONCAT(p_WHERE, ' ', v_Column1 ,' In' );
			SET p_WHERE = CONCAT(p_WHERE, ' ', "(" '"', v_SearchVal3 , '"' " , " '"', v_SearchVal4 , '"' ")" );
		END IF;


		#DEBUG
		#SELECT CONCAT('Before:Len(p_WHERE) = ', LENGTH(p_WHERE));
		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);


		SET p_SQL = '';
		SET p_SQL = CONCAT(p_SQL, 'Select' );
		SET p_SQL = CONCAT(p_SQL, ' ' , 'Merchant_ID,
								  Terminal_ID,
								  Serial_No,
								  Merchant_Name, 
								  Status, Status_Remarks, 
								  Dependency_for_Pending, 
								  (DATE_FORMAT(STR_TO_DATE(Date_Received, "%d/%m/%Y %H:%i"), "%m/%d/%Y %H:%i%p") ) AS `Date_Received`' );
		SET p_SQL = CONCAT(p_SQL, ' ' , 'From' );
		SET p_SQL = CONCAT(p_SQL, ' ' , v_Tablename );


		IF (LENGTH(p_WHERE) > 0)
		THEN
			SET p_SQL = CONCAT(p_SQL, ' ', 'WHERE' );
			SET p_SQL = CONCAT(p_SQL, ' ', p_WHERE );
		END IF;

		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);
		#SELECT CONCAT('Before:p_SQL = ', p_SQL);

		#Execute Query
		SET @QUERY = p_SQL;
		PREPARE QUERY FROM @QUERY;
		EXECUTE QUERY;

END */$$
DELIMITER ;

/* Procedure structure for procedure `spUpdateUser` */

/*!50003 DROP PROCEDURE IF EXISTS  `spUpdateUser` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdateUser`(
    IN p_StatementType VARCHAR(100),
    IN p_SearchBy VARCHAR(100),
    IN p_SearchValue longtext
)
BEGIN  

DECLARE v_ID INTEGER;
DECLARE v_Description VARCHAR(45);
DECLARE v_TableName VARCHAR(45);

/*User*/
DECLARE v_UserID INTEGER;
DECLARE v_UserName VARCHAR(45);
DECLARE v_Password VARCHAR(45);
DECLARE v_Email VARCHAR(45);
DECLARE v_Name VARCHAR(45);
DECLARE v_UserType VARCHAR(45);

DECLARE v_InvoiceID INTEGER;
DECLARE v_SubmitID VARCHAR(45);

DECLARE p_WHERE longtext;
DECLARE p_ORDERBY longtext;
DECLARE p_SQL longtext;

START TRANSACTION;
			
IF (p_StatementType = 'Update') 
THEN  		

	IF (p_SearchBy = 'Update User Password') 
	THEN
		SET v_UserID = CAST(TRIM(SPLIT_STRING(p_SearchValue, '|' ,1)) AS UNSIGNED INTEGER);
		SET v_UserName = TRIM(SPLIT_STRING(p_SearchValue, '|' ,2));		
		SET v_Password = TRIM(SPLIT_STRING(p_SearchValue, '|' ,3));
				
		UPDATE tbluser
		SET		
		`Password` = v_Password
		WHERE (UserID = v_UserID AND UserName = v_UserName);
		
	ELSEIF (p_SearchBy = 'Update User') 
	THEN
		SET v_UserID = CAST(TRIM(SPLIT_STRING(p_SearchValue, '|' ,1)) AS UNSIGNED INTEGER);
		SET v_UserName = TRIM(SPLIT_STRING(p_SearchValue, '|' ,2));	
		SET v_Name = TRIM(SPLIT_STRING(p_SearchValue, '|' ,3));	
		SET v_Email = TRIM(SPLIT_STRING(p_SearchValue, '|' ,4));	
		SET v_Password = TRIM(SPLIT_STRING(p_SearchValue, '|' ,5));
		SET v_UserType = TRIM(SPLIT_STRING(p_SearchValue, '|' ,6));
				
		UPDATE tbluser
		SET
		UserName = v_UserName,
		FullName = v_Name,
		Email = v_Email,				
		`Password` = v_Password,
		UserType = v_UserType
		WHERE (UserID = v_UserID);	
		
	
						
	END IF;				
	
END IF; 

COMMIT; 
       
END */$$
DELIMITER ;

/* Procedure structure for procedure `spViewSourceDetails` */

/*!50003 DROP PROCEDURE IF EXISTS  `spViewSourceDetails` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spViewSourceDetails`( 
     p_StatementType VARCHAR(50),
     p_SearchBy VARCHAR(50),
     p_SearchValue VARCHAR(50)
)
BEGIN  
	
	DECLARE v_SearchVal VARCHAR(50);
	declare v_SearchTable Varchar(50);

	#SET v_Column = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,1));

	IF (p_StatementType = "View") THEN
	
				
		CASE p_SearchBy 
		
			
			WHEN "Info" THEN
			
				SET v_SearchTable  = TRIM(SPLIT_STRING(p_SearchValue, '|' ,1));
				SET v_SearchVal    = TRIM(SPLIT_STRING(p_SearchValue, '|' ,2));
				
				SET @Query = CONCAT('SELECT ID,
							Terminal_Model,
							', IF(v_SearchTable IN ("tblservicing", "tblrepair"), 'Case_Referral,', ''), '
							Merchant_ID,
							Terminal_ID,
							Serial_No,
							Merchant_Name,
							`Status`,
							Status_Remarks,
							Dependency_for_Pending,
							Date_Received,
							TIMESTAMPDIFF(MONTH, DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d"), NOW()) AS Terminal_Age
							
						    FROM ', v_SearchTable , '
						    
						    WHERE Terminal_Model LIKE "%', v_SearchVal, '%"
						    OR Serial_No LIKE "%', v_SearchVal, '%"
						    OR Merchant_Name LIKE "%', v_SearchVal, '%"
						    LIMIT 100;');

				PREPARE stmt FROM @Query;
				EXECUTE stmt;
				DEALLOCATE PREPARE stmt;
				
			
			when "Inventory" then
				
				Select Count(*) as TotalInvent
				from tblinventory
				Where Terminal_Model Like Concat('%', p_SearchValue, '%');
				

		END CASE;
				
	END IF;
	
	
	#SELECT (CONCAT('Query = ' , v_SearchBy));
							       			
END */$$
DELIMITER ;

/* Procedure structure for procedure `spViewTerminalDetails` */

/*!50003 DROP PROCEDURE IF EXISTS  `spViewTerminalDetails` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spViewTerminalDetails`( 
     p_StatementType VARCHAR(50),
     p_SearchBy VARCHAR(50),
     p_SearchValue VARCHAR(50)
)
BEGIN  

	DECLARE v_Tablename VARCHAR(50);	
	DECLARE v_DateFrom VARCHAR(50);
	DECLARE v_DateTo VARCHAR(50);

	
	#SET v_Column = TRIM(SPLIT_STRING( p_SearchColumn, '|' ,1));
	
	IF (p_StatementType = "View") THEN
	

		CASE p_SearchBy 
							
			WHEN "Completed" THEN 
					
				SELECT
				
				    s.Source,
				    COALESCE(d.Delivered, 0) AS Delivered,
				    COALESCE(r.Resolved, 0) AS Resolved,
				    COALESCE(d.Delivered, 0) + COALESCE(r.Resolved, 0) AS Total
				    
				FROM
				(
				    SELECT 'INSTALLATION' AS Source
				    UNION ALL
				    SELECT 'REPROGRAMMING' AS Source
				    UNION ALL
				    SELECT 'SERVICING' AS Source
				    UNION ALL
				    SELECT 'REPAIR' AS Source
				) AS s
				
				LEFT JOIN (
				
				    SELECT
				    
					t.Source,
					COUNT(*) AS Delivered
					
				    FROM (
				    
					SELECT 'INSTALLATION' AS Source, Terminal_Model, Status_Remarks FROM tblinstallation
					
					UNION ALL
					SELECT 'REPROGRAMMING' AS Source, Terminal_Model, Status_Remarks FROM tblreprogramming
					
					UNION ALL
					SELECT 'SERVICING' AS Source, Terminal_Model, Status_Remarks FROM tblservicing
					
					UNION ALL
					SELECT 'REPAIR' AS Source, Terminal_Model, Status_Remarks FROM tblrepair
					
				    ) AS t
				    
				    WHERE (Status_Remarks IN ('Delivered', 'Picked Up'))
					OR (Status_Remarks LIKE '%Done Repair%')
					OR (Status_Remarks LIKE '%Done%')
					OR (Status_Remarks LIKE '%Unit Received%')
					
				    GROUP BY t.Source
				    
				) AS d ON s.Source = d.Source
				
				LEFT JOIN (
				
				    SELECT
				    
					t.Source,
					COUNT(*) AS Resolved
					
				    FROM (
				    
					SELECT 'INSTALLATION' AS Source, Terminal_Model, Status_Remarks FROM tblinstallation
					UNION ALL
					SELECT 'REPROGRAMMING' AS Source, Terminal_Model, Status_Remarks FROM tblreprogramming
					UNION ALL
					SELECT 'SERVICING' AS Source, Terminal_Model, Status_Remarks FROM tblservicing
					UNION ALL
					SELECT 'REPAIR' AS Source, Terminal_Model, Status_Remarks FROM tblrepair
					
				    ) AS t
				    
				    WHERE Status_Remarks LIKE '%Resolved%'
				    GROUP BY t.Source
				    
				) AS r ON s.Source = r.Source

				WHERE EXISTS (
				    SELECT 1
				    FROM tblinstallation
				    WHERE Terminal_Model LIKE CONCAT('%', p_SearchValue, '%')
				)
				
				OR s.Source = s.Source
				ORDER BY FIELD(s.Source, 'INSTALLATION', 'REPROGRAMMING', 'SERVICING', 'REPAIR');




			WHEN "Pending" THEN
			
				SELECT
				    s.Source,
				    COALESCE(t.`7Days`, 0) AS `7Days`,
				    COALESCE(t.`7-30Days`, 0) AS `7-30Days`,
				    COALESCE(t.`30Days`, 0) AS `30Days`,
				    COALESCE(t.`7Days`, 0) + COALESCE(t.`7-30Days`, 0) + COALESCE(t.`30Days`, 0) AS Total
				    
				FROM (
				
				    SELECT 'INSTALLATION' AS Source
				    
				    UNION ALL
				    SELECT 'REPROGRAMMING' AS Source
				    
				    UNION ALL
				    SELECT 'SERVICING' AS Source
				    
				    UNION ALL
				    SELECT 'REPAIR' AS Source
				    
				) AS s
				
				LEFT JOIN (
				
				    SELECT
				    
					Source,
					SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) <= 7 THEN 1 ELSE 0 END) AS `7Days`,
					SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) BETWEEN 8 AND 30 THEN 1 ELSE 0 END) AS `7-30Days`,
					SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) > 30 THEN 1 ELSE 0 END) AS `30Days`
				    
				    FROM (
				    
					SELECT 'INSTALLATION' AS Source, Date_Received FROM tblinstallation WHERE `Status` IN ('Pending', 'Cancelled')
					UNION ALL
					SELECT 'REPROGRAMMING' AS Source, Date_Received FROM tblreprogramming WHERE `Status` IN ('Pending', 'Cancelled')
					UNION ALL
					SELECT 'SERVICING' AS Source, Date_Received FROM tblservicing WHERE `Status` IN ('Pending', 'Cancelled')
					UNION ALL
					SELECT 'REPAIR' AS Source, Date_Received FROM tblrepair WHERE `Status` IN ('Pending', 'Cancelled')
					
				    ) AS combined
				    
				  GROUP BY Source
				) AS t ON s.Source = t.Source
				
				ORDER BY FIELD(s.Source, 'INSTALLATION', 'REPROGRAMMING', 'SERVICING', 'REPAIR');

								
	
	
	
			WHEN "Status" THEN
			
				SELECT 
				
				    COALESCE(t.Terminal_Model, '-') AS Terminal_Model,
				    s.Source,
				    COALESCE(t.Completed, 0) AS Completed,
				    COALESCE(t.Pending, 0) AS Pending,
				    COALESCE(t.Cancelled, 0) AS Cancelled,
				    COALESCE(t.Completed, 0) + COALESCE(t.Pending, 0) + COALESCE(t.Cancelled, 0) AS Total
				    
				FROM (
				
				    SELECT 'INSTALLATION' AS Source
				    UNION ALL
				    SELECT 'REPROGRAMMING' AS Source
				    UNION ALL
				    SELECT 'SERVICING' AS Source
				    UNION ALL
				    SELECT 'REPAIR' AS Source
				    
				) AS s
				
				LEFT JOIN (
				
				    SELECT
					
					Terminal_Model, Source,
					SUM(CASE WHEN `Status` = 'Completed' THEN 1 ELSE 0 END) AS Completed,
					SUM(CASE WHEN `Status` = 'Pending' THEN 1 ELSE 0 END) AS Pending,
					SUM(CASE WHEN `Status` = 'Cancelled' THEN 1 ELSE 0 END) AS Cancelled
					
				    FROM (
					SELECT Terminal_Model, 'INSTALLATION' AS Source, `Status`
					FROM tblinstallation
				      
					UNION ALL
					
					SELECT Terminal_Model, 'REPROGRAMMING' AS Source, `Status`
					FROM tblreprogramming

					
					UNION ALL
					
					SELECT Terminal_Model, 'SERVICING' AS Source, `Status`
					FROM tblservicing

					
					UNION ALL
					
					SELECT Terminal_Model, 'REPAIR' AS Source, `Status`
					FROM tblrepair
					
				    ) AS subquery
				    
				    WHERE Terminal_Model LIKE CONCAT('%', p_SearchValue, '%')
				    GROUP BY Terminal_Model, Source
				    
				) AS t ON s.Source = t.Source
				
				ORDER BY FIELD(s.Source, 'INSTALLATION', 'REPROGRAMMING', 'SERVICING', 'REPAIR');
				
				
				

					
			WHEN "Status Summary" THEN
			
				SELECT 
				
				    s.Source,
				    COALESCE(t.Completed, 0) AS `Completed`,
				    COALESCE(t.Pending, 0) AS `Pending`,
				    COALESCE(t.Cancelled, 0) AS `Cancelled`,
				    COALESCE(t.Waiting, 0) AS `Waiting`,
				    COALESCE(t.Completed, 0) + COALESCE(t.Pending, 0) + COALESCE(t.Cancelled, 0) AS Total
				    
				FROM (
				
				    SELECT 'INSTALLATION' AS Source
				    UNION ALL
				    SELECT 'REPROGRAMMING' AS Source
				    UNION ALL
				    SELECT 'SERVICING' AS Source
				    UNION ALL
				    SELECT 'REPAIR' AS Source
				    
				) AS s
				
				LEFT JOIN (
				
				    SELECT 
				    
					Source,
					SUM(CASE WHEN `Status` LIKE '%Completed%' THEN 1 ELSE 0 END) AS `Completed`,
					SUM(CASE WHEN `Status` LIKE '%Pending%' THEN 1 ELSE 0 END) AS `Pending`,
					SUM(CASE WHEN `Status` LIKE '%Cancelled%' THEN 1 ELSE 0 END) AS `Cancelled`,
					SUM(CASE WHEN Date_Received = '-' THEN 1 ELSE 0 END) AS `Waiting`
					
				    FROM (
				    
					SELECT 'INSTALLATION' AS Source, `Status`, Date_Received, Terminal_Model
					FROM tblinstallation
					UNION ALL
					SELECT 'REPROGRAMMING' AS Source, `Status`, Date_Received, Terminal_Model
					FROM tblreprogramming
					UNION ALL
					SELECT 'SERVICING' AS Source, `Status`, Date_Received, Terminal_Model
					FROM tblservicing
					UNION ALL
					SELECT 'REPAIR' AS Source, `Status`, Date_Received, Terminal_Model
					FROM tblrepair
					
				    ) AS sub
				    
				    WHERE Terminal_Model LIKE CONCAT('%', p_SearchValue, '%')
				    GROUP BY Source
				    
				) AS t ON s.Source = t.Source
				
				ORDER BY FIELD(s.Source, 'INSTALLATION', 'REPROGRAMMING', 'SERVICING', 'REPAIR');


												
								
				
			WHEN "Status Remarks" THEN
			
				SELECT Terminal_Model, Source, `Status_Remarks`, `Status`,
				    SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) <= 7 THEN 1 ELSE 0 END) AS `7Days`,
				    SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) BETWEEN 8 AND 30 THEN 1 ELSE 0 END) AS `7-30Days`,
				    SUM(CASE WHEN DATEDIFF(CURDATE(), DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d")) > 30 THEN 1 ELSE 0 END) AS `30Days`,
				    COUNT(*) AS Total
				FROM (
				    SELECT Terminal_Model, 'INSTALLATION' AS Source, `Status_Remarks`, `Status`, Date_Received
				    FROM tblinstallation

				    UNION ALL

				    SELECT Terminal_Model, 'REPROGRAMMING' AS Source, `Status_Remarks`, `Status`, Date_Received
				    FROM tblreprogramming

				    UNION ALL

				    SELECT Terminal_Model, 'SERVICING' AS Source, `Status_Remarks`, `Status`, Date_Received
				    FROM tblservicing

				    UNION ALL

				    SELECT Terminal_Model, 'REPAIR' AS Source, `Status_Remarks`, `Status`, Date_Received
				    FROM tblrepair
				) AS combined

				WHERE Terminal_Model LIKE CONCAT('%', p_SearchValue, '%')
				    OR Status_Remarks LIKE CONCAT('%', p_SearchValue, '%')
				   
				GROUP BY Terminal_Model, Source, `Status_Remarks`, `Status`
				ORDER BY FIELD(Source, 'INSTALLATION', 'REPROGRAMMING', 'SERVICING', 'REPAIR');
					
					
					
					
			WHEN 'History' THEN
			
				#Set Parameters for Values
				SET v_Tablename = TRIM(SPLIT_STRING (p_SearchValue, '|' ,1));
				SET v_DateFrom 	= TRIM(SPLIT_STRING (p_SearchValue, '|' ,2));
				SET v_DateTo 	= TRIM(SPLIT_STRING (p_SearchValue, '|' ,3));
					
				#Set Query			
				SET @Query = CONCAT('SELECT Terminal_Model, Status, COUNT(ID) As Total
						FROM ', v_Tablename ,'
						WHERE DATE_FORMAT(STR_TO_DATE(Date_Released, "%m-%d-%Y"), "%Y-%m-%d")
						BETWEEN CAST('"'", v_DateFrom ,"'" 'AS DATE) AND CAST('"'",v_DateTo ,"'"'AS DATE)
						GROUP BY Terminal_Model, Status');
				
				#Execute Query
				PREPARE stmt FROM @Query;
				EXECUTE stmt;
				DEALLOCATE PREPARE stmt;
				
				
			when 'Duplicate Request' then
			 
				SET @Query = CONCAT('SELECT ID,
						Terminal_Model,
						', IF(p_SearchValue IN ("tblservicing", "tblrepair"), 'Case_Referral,', ''), '
						Merchant_ID,
						Terminal_ID,
						Serial_No,
						Merchant_Name,
						`Status`,
						Status_Remarks,
						Dependency_for_Pending,
						Date_Received,
						TIMESTAMPDIFF(MONTH, DATE_FORMAT(STR_TO_DATE(Date_Received, "%m-%d-%Y"), "%Y-%m-%d"), NOW()) AS Terminal_Age
					    FROM ', p_SearchValue , '
					    WHERE `Status` LIKE "%CANCELLED%" AND Status_Remarks LIKE "%DUPLICATE%" 
					    ORDER BY ID ASC;');

				PREPARE stmt FROM @Query;
				EXECUTE stmt;
				DEALLOCATE PREPARE stmt;


												
		END CASE;
				
	END IF;
	
	
	#SELECT (CONCAT('Query = ' , v_SearchBy));
							       			
END */$$
DELIMITER ;

/* Procedure structure for procedure `spViewUser` */

/*!50003 DROP PROCEDURE IF EXISTS  `spViewUser` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spViewUser`( 
		IN p_Username VARCHAR(255) /* = NULL */,
		IN p_Password VARCHAR(255) /* = NULL */


)
BEGIN
	
	DECLARE v_Username VARCHAR(255);
	DECLARE v_Password VARCHAR(255);
	DECLARE p_WHERE LONGTEXT;
	DECLARE p_SQL LONGTEXT;


		SET v_Username = p_Username;
		SET v_Password = p_Password;

		
			SET p_WHERE = '';

			IF ( LENGTH( v_SearchVal1 ) > 0 && LENGTH( v_Column1 ) > 0) 
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ', ' Username LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_Username, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;

			IF ( LENGTH( v_SearchVal2 ) > 0 && LENGTH( v_Column2 ) > 0)
			THEN
				SET p_WHERE = CONCAT(p_WHERE, ' ','Password LIKE' );
				SET p_WHERE = CONCAT(p_WHERE, ' ', "'%", v_Password, "%'");
				SET p_WHERE = CONCAT(p_WHERE, ' ', 'AND');
			END IF;

		SET p_WHERE = LEFT(p_WHERE, LENGTH(p_WHERE) - 4); # Remove AND from END of WHERE CLAUSE

		#DEBUG
		#SELECT CONCAT('Before:Len(p_WHERE) = ', LENGTH(p_WHERE));
		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);

		SET p_SQL = '';
		SET p_SQL = CONCAT(p_SQL,'SELECT');
		SET p_SQL = CONCAT(p_SQL, ' ', 'ID, Username, Password, User_Level');
		SET p_SQL = CONCAT(p_SQL, ' ', 'FROM tblusers');


		IF (LENGTH(p_WHERE) > 0)
		THEN
			SET p_SQL = CONCAT(p_SQL, ' ', 'WHERE');
			SET p_SQL = CONCAT(p_SQL, ' ', p_WHERE);
		END IF;

		#SELECT CONCAT('Before:p_WHERE = ', p_WHERE);
		#SELECT CONCAT('Before:p_SQL = ', p_SQL);

		#Execute Query
		SET @QUERY = p_SQL;
		PREPARE QUERY FROM @QUERY;
		EXECUTE QUERY;

END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
