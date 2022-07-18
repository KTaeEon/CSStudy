#날짜 : 2022/07/18
#이름 : 김태언
#내용 : 교재 2장 테이블에서 데이터 검색

#--------------------------------
#4강 Hello World 실행하기-
#--------------------------------
# 테이블 생성-
CREATE TABLE `sample21` (
   `no`         INT,
   `name`     VARCHAR(10),
   `birthday` CHAR(10),
   `address`  VARCHAR(100)
);

# 데이터 저장
INSERT INTO `sample21` VALUES (1, '박준용', '1976-10-18', '대구광역시 수성구');
INSERT INTO `sample21` (`no`, `name`, `address`) VALUES (2, '김재진', '대구광역시 동구');
INSERT INTO `sample21` SET `no`=3, `name`='홍길동', `address`='서울특별시 마포구';

#p53
SELECT * FROM `sample21`;
#---------------------------------
#5강 테이블 구조 참조하기
#---------------------------------
#p62
DESC `sample21`;

#---------------------------------
#6강 검색조건 지정하기
#---------------------------------
#p66
SELECT * FROM `sample21`;
SELECT `no`, `name` FROM `sample21`;

#p68
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE `no`=2;

#p70
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE `no`<>2;

#p71
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE `name`='박준용';

#p72
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE `birthday`= NULL; # 잘못된 NULL값 검색예시

#p73
SELECT * FROM `sample21` WHERE `birthday`IS NULL; # NULL값 검색시 = 연산자를 쓰지않고 IS NULL 을 이용한다.


#---------------------------------
#7강 조건 조합하기
#---------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample24` (
   `no` INT,
   `a` INT,
   `b` INT,
   `c` INT
);


INSERT INTO `sample24` VALUES (1, 1, 0, 0);
INSERT INTO `sample24` VALUES (2, 0, 1, 0);
INSERT INTO `sample24` VALUES (3, 0, 0, 1);
INSERT INTO `sample24` VALUES (4, 2, 2, 0);
INSERT INTO `sample24` VALUES (5, 0, 2, 2);

#p76
SELECT * FROM `sample24`;

#p77
SELECT * FROM `sample24` WHERE `a` <> 0 AND `b` <> 0;  # 조건이 전부 참일때

#p78
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE `a` <> 0 OR `b` <> 0;   # 하나의 조건이라도 참일때

#p80
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE `a`=1 OR `a`=2 AND `b`=1 OR `b`=2; # 조건식의 우선순위는 AND가 높기때문에 계산이 a=1 OR (a=2 AND B=1) OR b=2 로 계산됨
# 위의 계산식이면 a=1 , a=2 AND b=1, b=2 인 객체가 출력됨
SELECT * FROM `sample24` WHERE (`a`=1 OR `a`=2) AND (`b`=1 OR `b`=2); # a<>0 AND b<>0 라는 조건식과 동일하게 작용 OR 조건식을 쓸땐 ()로 묶어두는 것이 좋음

#p82
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE NOT (`a` <> 0 OR `b` <> 0); # NOT은 오른쪽에만 항목을 지정하는 '단항 연산자' 오른쪽에 지정된 조건식의 반대의 값을 출력합니다.

#------------------------------
#8강 패턴 매칭에 의한 검색
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample25` (
	`no` INT,
	`text` VARCHAR(255)
);

INSERT INTO `sample25` SET `text` = 'SQL은 RDBMS를 조작하는 언어이다', `no`=1;
INSERT INTO `sample25` SET `text` = 'LIKE에서는 메타문자%와_를 사용할 수 있다', `no`=2;
INSERT INTO `sample25` SET `text` = 'LIKE는 SQL에서 사용할 수 있는 술어 중 하나이다', `no`=3;

#p85
SELECT * FROM `sample25`
SELECT * FROM `sample25` WHERE `text` LIKE 'SQL%' # %는 임의의 문자열을 나타내는 메타문자 SQL~

#p86
SELECT * FROM `sample25` WHERE `text` LIKE '%SQL%' # %SQL%로 검색시 SQL를 포함하는 행을 검색
# %SQL 후방 일치
# %SQL% 중간 일치
# SQL% 전방 일치

#p88
SELECT * FROM `sample25`
SELECT * FROM `sample25` WHERE `text` LIKE '%\%%' # LIKE로 %문자를 검색하고 싶을때 앞에 \를 붙여주면 된다.