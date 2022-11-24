using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi23112022.Dto
{
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
        public string? URL_DOI { get; set; }
    }
    public class BookInsert
    {
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
        public string? URL_DOI { get; set; }
    }
    public class MLABook
    {
        public int BookId { get; set; }
        public string Publisher { get; set; }
        public string TitleOfContainer { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Price { get; set; }
        public string PublishDate { get; set; }
        public string PageNumbers { get; set; }
    }
    public class MLABookChicago
    {
        public int BookId { get; set; }
        public string Card { get; set; }
      
    }

}
