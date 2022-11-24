# <h1 style = "color:blue;">ASP.Net Core MVC Web Api -v 3.1<h1/>
> ## APP Name : BookWebApi
> ## Url : [Book Web Api](https://localhost:44302/swagger/index.html)  

## 1. Sorted List Function Using ADO.Net
> ### sorted by  **Publisher** | **Author (last, first)** | **Title**

>	### Url	: [Get ADO PAT](https://localhost:44302/Book/get-ado-pat)

## 2. Sorted List Function Using ADO.Net
> ### sorted by  **Publisher** | **Author (last, first)** | **Title**

>	### Url	: [Get EF PAT](https://localhost:44302/Book/get-ef-pat)

## 3. Sorted List Function Using Entity Framework Core
> ### sorted by  **Publisher** | **Author (last, first)** | **Title**

>	### Url	: [Get EF AT](https://localhost:44302/Book/get-ef-at)

## 4. Total price of all books in the database

>   ### Url : [Get Total Price](https://localhost:44302/Book/get-total-price)

## 5. Large list of datas sava to the database Using EF Core only one call to the DB server

>   ### Url : [Save](https://localhost:44302/Book/save)

>	### Json Format (list of object) to pass a value from the Body : 
```
[
    {
        "publisher": "ABC",
        "titleOfContainer": "ATitleOfContainer",
        "title": "ATitle",
        "authorFirstName": "Af",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "basBC",
        "titleOfContainer": "BTitleOfContainer",
        "title": "BTitle",
        "authorFirstName": "Bf",
        "authorLastName": "BL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "CBC",
        "titleOfContainer": "CTitleOfContainer",
        "title": "CTitle",
        "authorFirstName": "Cf",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "ABC",
        "titleOfContainer": "DTitleOfContainer",
        "title": "ZTitle",
        "authorFirstName": "Ef",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "OBC",
        "titleOfContainer": "RTitleOfContainer",
        "title": "PTitle",
        "authorFirstName": "Af",
        "authorLastName": "UL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "UYBC",
        "titleOfContainer": "ITitleOfContainer",
        "title": "TRTitle",
        "authorFirstName": "Af",
        "authorLastName": "POL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "TYRBC",
        "titleOfContainer": "IYTTitleOfContainer",
        "title": "UITitle",
        "authorFirstName": "Af",
        "authorLastName": "IUL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "UYTBC",
        "titleOfContainer": "KitleOfContainer",
        "title": "FTitle",
        "authorFirstName": "Kf",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "UYFBC",
        "titleOfContainer": "FTitleOfContainer",
        "title": "STitle",
        "authorFirstName": "Qf",
        "authorLastName": "PL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "ABC",
        "titleOfContainer": "WETitleOfContainer",
        "title": "RTitle",
        "authorFirstName": "Wf",
        "authorLastName": "EL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "ABC",
        "titleOfContainer": "ATitleOfContainer",
        "title": "ATitle",
        "authorFirstName": "Af",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "DDEDC",
        "titleOfContainer": "DSJKHD",
        "title": "SADSD",
        "authorFirstName": "DED",
        "authorLastName": "FEFWE",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "WEWEDCDD",
        "titleOfContainer": "HJJG",
        "title": "ATiFGHFtleGHHD",
        "authorFirstName": "GFHDAf",
        "authorLastName": "HFG",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "ABC",
        "titleOfContainer": "ERTRETRTitleOfContainer",
        "title": "HGHGTitle",
        "authorFirstName": "HTHGf",
        "authorLastName": "GHL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    },
    {
        "publisher": "GFHGFBC",
        "titleOfContainer": "AGHGFTitleOfContainer",
        "title": "AFGHGFTitle",
        "authorFirstName": "GHAf",
        "authorLastName": "AL",
        "price": 100,
        "publishDate": "2022-11-23T00:00:00",
        "pageNumbers": "123",
        "journalTitle": "hjklk",
        "volumeNo": "1",
        "issueNo": "3",
        "pageRange": "0-456",
        "urL_DOI": "https://demo.com"
    }
]
```

## 6. Modify a return value to the MLA (Modern Language Association)
### Image

>  <img src="https://cms.bibliography.com/wp-content/uploads/2020/02/Citation_Diagram_ex2.png" alt="Ref Image" style="width:600px;height:300px;">

>	### Url	: [Get MLA Formatted](https://localhost:44302/Book/get-mla-formatted)

## 7. Modify a return value to Chicago style citation (Chicago Manual of Style)
### Image

>   <img src="https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg" alt="Ref Image" style="width:600px;height:400px;">

>	### Url	: [Get Chicago Style](https://localhost:44302/Book/get-Chicagostyle)

## 9. Database Outline
> ###  **Query**  <br/>
> * Create Database : `CREATE DATABASE BookDB` <br/>
> * Create TAble : <br/>
        ``` CREATE TABLE [dbo].[TblBook](
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
	    GO ```<br/>

## 10. Class And Feilds
            public class Book 
            {
                public int BookId { get; set; }
                public string Publisher { get; set; }
                public string TitleOfContainer { get; set; }
                public string Title { get; set; }
                public string AuthorFirstName { get; set; }
                public string AuthorLastName { get; set; }
                public decimal Price { get; set; }
                public DateTime? PublishDate { get; set; }
                public string PageNumbers { get; set; }
                public string JournalTitle { get; set; }
                public string VolumeNo { get; set; }
                public string IssueNo { get; set; }
                public string PageRange { get; set; }
                public string URL_DOI { get; set; }
            }

## 11. Entity Framework Core
> * Scoffold : ```Scaffold-DbContext "Server=HANIFA;Database=BookDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models ```

