using System;
using System.Collections.Generic;

namespace BookWebApi23112022.Models
{
    public partial class TblBook
    {
        public int BookId { get; set; }
        public string Publisher { get; set; }
        public string TitleOfContainer { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? PublishDate { get; set; }
        public string PageNumbers { get; set; }
        public string JournalTitle { get; set; }
        public string IssueNo { get; set; }
        public string PageRange { get; set; }
        public string UrlDoi { get; set; }
        public string VolumeNo { get; set; }
    }
}
