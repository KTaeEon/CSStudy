#날짜 : 2022/07/19
#이름 : 김태언
#내용 : SQL 확인문제

# 테이블 생성
CREATE TABLE `tbl_member` (
   `memberID`   VARCHAR(10) PRIMARY KEY NOT NULL,
   `memberName` VARCHAR(10) NOT NULL,
   `memberHp`   CHAR(13) UNIQUE,
   `memberAge`  TINYINT,
   `memberAddr` VARCHAR(20)
);

CREATE TABLE `tbl_product` (
   `productCode` INT PRIMARY KEY AUTO_INCREMENT,
   `productName` VARCHAR(10) NOT NULL,
   `price`       INT NOT NULL,
   `amount`      INT DEFAULT 0,
   `company`     VARCHAR(10),
   `makeDate`    DATE
);

# 데이터 입력하기

INSERT INTO `tbl_member` VALUES ('p101', '김유신', '010-1234-1001', 25, '신라');
INSERT INTO `tbl_member` VALUES ('p102', '김춘추', '010-1234-1002', 23, '신라');
INSERT INTO `tbl_member` (`memberID`, `memberName`, `memberAge`, `memberAddr`) VALUES ('p103', '장보고', 31, '통일신라');
INSERT INTO `tbl_member` SET `memberID`='p104', `memberName`='강감찬', `memberAddr`='고려';
INSERT INTO `tbl_member` (`memberID`, `memberName`, `memberHp`, `memberAge`) VALUES ('p105', '이순신', '010-1234-1005', 50);

INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('냉장고', 800, 10, 'LG', 20220106);
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('노트북', 1200, 20, '삼성', 20220106);
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('TV', 1400, 6, 'LG', 20220106);
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('세탁기', 1000, 8, 'LG', 20220106);
INSERT INTO `tbl_product` (`productName`, `price`) VALUES ('컴퓨터', 1100);
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('휴대폰', 900, 102, '삼성', 20220106);

# 데이터 검색 및 값 변경하기

SELECT `memberName` FROM `tbl_member`;
SELECT `memberName`, `memberHp` FROM `tbl_member`;
SELECT * FROM `tbl_member` WHERE `memberID`='p102';
SELECT * FROM `tbl_member` WHERE `memberID`='p104' OR `memberID`='p105';
SELECT * FROM `tbl_member` WHERE `memberAddr`='신라';
SELECT * FROM `tbl_member` WHERE `memberAge` > 30;
SELECT * FROM `tbl_member` WHERE `memberHp` IS NULL;

UPDATE `tbl_member` SET `memberAge`=42 WHERE `memberID`='p104';
UPDATE `tbl_member` SET `memberAddr`='조선' WHERE `memberID`='p105';
DELETE FROM `tbl_member` WHERE `memberID`='p103';
SELECT * FROM `tbl_member`;

SELECT `productName` FROM `tbl_product`;
SELECT `productName`, `price` FROM `tbl_product`;
SELECT * FROM `tbl_product` WHERE `company`='LG';
SELECT * FROM `tbl_product` WHERE `company`='삼성';
UPDATE `tbl_product` SET 
                      `company`='삼성', 
                      `makeDate`=20210101 
                     WHERE
                      `productCode`=5;
SELECT * FROM `tbl_product`;





