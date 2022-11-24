	USE [BookDb];
	GO

	CREATE TABLE [dbo].[TblBook](
	[BookId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Publisher] [nvarchar](100) NULL,
	[TitleOfContainer] [nvarchar](100) NULL,
	[Title] [nvarchar](100) NULL,
	[AuthorFirstName] [nvarchar](100) NULL,
	[AuthorLastName] [nvarchar](100) NULL,
	[Price] [decimal](10, 3) NULL,
	[PublishDate] [date] NULL,
	[PageNumbers] [nvarchar](20) NULL,
	[JournalTitle] [nvarchar](100) NULL,
	[IssueNo] [nvarchar](10) NULL,
	[PageRange] [nvarchar](10) NULL,
	[URL_DOI] [nvarchar](200) NULL,
	[VolumeNo] [nvarchar](10) NULL);
	GO

	CREATE PROCEDURE SP_GET_BOOKS_SORTEDBY_PUBLISHER_AUTHOR_TITLE
	AS
	BEGIN
    SELECT * FROM TblBook ORDER BY [Publisher],[AuthorFirstName],[AuthorLastName],[Title]
    END

    CREATE PROCEDURE SP_GET_BOOKS_SORTEDBY_AUTHOR_TITLE
	AS
	BEGIN
    SELECT * FROM TblBook ORDER BY [AuthorFirstName],[AuthorLastName],[Title]
    END

	EXEC SP_GET_BOOKS_SORTEDBY_PUBLISHER_AUTHOR_TITLE;

	EXEC SP_GET_BOOKS_SORTEDBY_AUTHOR_TITLE;


	DECLARE @oderkey INT;
	SET @oderkey=2
	SELECT * FROM TblBook ORDER BY(
	CASE
      WHEN @oderkey = 1 THEN [Publisher]
	  WHEN @oderkey = 2 THEN [AuthorFirstName]
	  WHEN @oderkey = 3 THEN [AuthorLastName]
	  WHEN @oderkey = 4 THEN [Title]
	  ELSE [Publisher]
    END
	);

	SELECT COUNT(*) FROM TblBook;

	TRUNCATE TABLE TblBook;