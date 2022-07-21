#날짜 : 2022/07/21
#이름 : 김태언
#내용 : SQL_연습문제

#실습 6-1
CREATE DATABASE `OrderDB`;
CREATE USER 'master'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `OrderDB`.* TO 'master'@'%';
FLUSH PRIVILEGES;

#실습 6-2
CREATE TABLE `Customer` (
  `custId` VARCHAR(10) PRIMARY KEY,
  `name`   VARCHAR(10) NOT NULL,
  `hp`     VARCHAR(13) UNIQUE,
  `addr`   VARCHAR(100),
  `rdate`  DATE NOT NULL
);

CREATE TABLE `Product` (
  `prodNo`   INT PRIMARY KEY AUTO_INCREMENT,
  `prodName` VARCHAR(10) NOT NULL,
  `stock`    INT DEFAULT 0,
  `price`    INT,
  `company`  VARCHAR(20) NOT NULL
);

CREATE TABLE `Order` (
  `orderNo`      INT PRIMARY KEY AUTO_INCREMENT,
  `orderId`      VARCHAR(10) NOT NULL,
  `orderProduct` INT NOT NULL,
  `orderCount`   INT DEFAULT 1,
  `orderDate`    DATETIME NOT NULL
);
#실습 6-3
INSERT INTO `Customer` (`custId`, `name`, `rdate`) VALUES ('heoj', '허준', 20220107)
INSERT INTO `Customer` VALUES ('jang', '장보고', '010-1234-1003', '완도군 청산면', 20220103)
INSERT INTO `Customer` VALUES ('jeongc', '정철', '010-1234-1006', '경기도 용인시', 20220106)
INSERT INTO `Customer` VALUES ('jeongyy', '정약용', '010-1234-1010', '경기도 광주시', 20220110)
INSERT INTO `Customer` VALUES ('kang', '강감찬', '010-1234-1004', '서울시 마포구', 20220104)
INSERT INTO `Customer` VALUES ('kimcc', '김춘추', '010-1234-1002', '경주시 보문동', 20220102)
INSERT INTO `Customer` VALUES ('kimys', '김유신', '010-1234-1001', '김해시 봉황동', 20220101)
INSERT INTO `Customer` (`custId`, `name`, `rdate`) VALUES ('leesg', '이성계', 20220105)
INSERT INTO `Customer` VALUES ('leess', '이순신', '010-1234-1008', '서울시 영등포구', 20220108)
INSERT INTO `Customer` VALUES ('songsh', '송상현', '010-1234-1009', '부산시 동래구', 20220109)

INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('새우깡', 5000, 1500, '농심')
INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('초코파이', 2500, 2500, '오리온')
INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('포카칩', 3600, 1700, '오리온')
INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('양파링', 1250, 1800, '농심')
INSERT INTO `Product` (`prodName`, `stock`, `company`) VALUES ('죠리퐁', 2200, '크라운')
INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('마카렛트', 3500, 3500, '롯데')
INSERT INTO `Product` (`prodName`, `stock`, `price`, `company`) VALUES ('뿌셔뿌셔', 1650, 1200, '오뚜기')

INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 3, 2,   20220701131510)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimys', 4, 1,   20220701141611)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('leess', 1, 1,   20220701172318)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('songsh', 6, 5,  20220702104636)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 2, 1,   20220703091537)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimys', 7, 3,   20220703123512)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('jeongyy', 1, 2, 20220703165536)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kang', 2, 4,    20220704142323)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 1, 3,   20220704215434)
INSERT INTO `Order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('heoj', 6, 1,    20220705142103)

#실습 6-4
SELECT * FROM `Customer`;

#실습 6-5
SELECT `custId`, `name`, `hp` FROM `Customer`; 

#실습 6-6
SELECT * FROM `Product`;

#실습 6-7
SELECT `company` FROM `Product`;

#실습 6-8
SELECT `company` FROM `Product` GROUP BY `company`;

#실습 6-9
SELECT `prodName`, `price` FROM `Product`;

#실습 6-10
SELECT `prodName`, (`price` + 500) AS `조정단가` FROM `Product`;

#실습 6-11
SELECT `prodName`, `stock`, `price` FROM `product` WHERE `company`='오리온';

#실습 6-12
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `Order` WHERE `orderId`='kimcc';

#실습 6-13
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `Order` WHERE `orderId`='kimcc' AND `orderCount` >= 2;

#실습 6-14
SELECT * FROM `Product` WHERE `price` <= 2000 AND `price` >= 1000 ;

#실습 6-15
SELECT `custId`, `name`, `hp`, `addr` FROM `Customer` WHERE `name` LIKE '김%';

#실습 6-16
SELECT `custId`, `name`, `hp`, `addr` FROM `Customer` WHERE `custId` LIKE '____';

#실습 6-17
SELECT * FROM `Customer` WHERE `hp` IS NULL;

#실습 6-18
SELECT * FROM `Customer` WHERE `addr` IS NOT NULL;

#실습 6-19
SELECT * FROM `Customer` ORDER BY `rdate` DESC;

#실습 6-20
SELECT * FROM `Order` WHERE `orderCount` >= 3 ORDER BY `orderCount` DESC, `orderNo` DESC;

#실습 6-21
SELECT AVG(`price`) FROM `Product`;

#실습 6-22
SELECT SUM(`stock`) AS `재고량 합계` FROM `Product` WHERE `company`='농심';

#실습 6-23
SELECT COUNT(`custId`) AS `고객수` FROM `customer`;

#실습 6-24
SELECT COUNT(DISTINCT `company`) AS `제조업체 수` FROM `Product`;



