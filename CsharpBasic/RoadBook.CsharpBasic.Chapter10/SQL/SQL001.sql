-- RoadbookDB 데이터베이스 만들기
CREATE DATABASE RoadbookDB
GO

-- RoadbookDB 사용하기
USE RoadbookDB
GO

-- TB_CATEGORY 테이블 만들기
CREATE TABLE TB_CATEGORY
(
	IDX INT IDENTITY(1,1),
	TITLE VARCHAR(20),
	SUMMARY VARCHAR(100)
)
GO

-- TB_CATEGORY 테이블에 데이터 집어넣기
INSERT INTO TB_CATEGORY( TITLE, SUMMARY ) VALUES ( '공지사항', '회원들에게 꼭 전달해야 할 내용입니다.' )
INSERT INTO TB_CATEGORY( TITLE, SUMMARY ) VALUES ( '자유게시판', '하고싶은 말을 마음껏 하세요.' )
GO