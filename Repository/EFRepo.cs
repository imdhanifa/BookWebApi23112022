using BookWebApi23112022.Dto;
using BookWebApi23112022.Models;
using BookWebApi23112022.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi23112022.Repository
{
    public class EFRepo : IEFRepo, IDisposable
    {
        private readonly BookDbContext _bookDbContext;

        public EFRepo(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }

        public async Task<List<Book>> GetBooksSortedByPublisherAuthorTitle()
        {
            try
            {
                return await _bookDbContext.TblBook.Select(X => new Book
                {
                    AuthorFirstName = X.AuthorFirstName,
                    AuthorLastName = X.AuthorLastName,
                    BookId = X.BookId,
                    PageNumbers = X.PageNumbers,
                    Price = (decimal)X.Price,
                    PublishDate = X.PublishDate,
                    Publisher = X.Publisher,
                    Title = X.Title,
                    TitleOfContainer = X.TitleOfContainer,
                    JournalTitle=X.JournalTitle,
                    VolumeNo=X.VolumeNo,
                    IssueNo=X.IssueNo,
                    PageRange=X.PageRange,
                    URL_DOI=X.UrlDoi
                }).OrderBy(X => X.Publisher).ThenBy(X => X.AuthorFirstName).ThenBy(X => X.AuthorLastName).ThenBy(X => X.Title).ToListAsync();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }

        public async Task<List<Book>> GetBooksSortedByAuthorTitle()
        {
            try
            {
                return await _bookDbContext.TblBook.Select(X => new Book
                {
                    AuthorFirstName = X.AuthorFirstName,
                    AuthorLastName = X.AuthorLastName,
                    BookId = X.BookId,
                    PageNumbers = X.PageNumbers,
                    Price =(decimal)X.Price,
                    PublishDate = X.PublishDate,
                    Publisher = X.Publisher,
                    Title = X.Title,
                    TitleOfContainer = X.TitleOfContainer,
                    JournalTitle = X.JournalTitle,
                    VolumeNo = X.VolumeNo,
                    IssueNo = X.IssueNo,
                    PageRange = X.PageRange,
                    URL_DOI = X.UrlDoi
                }).OrderBy(X => X.AuthorFirstName).ThenBy(X => X.AuthorLastName).ThenBy(X => X.Title).ToListAsync();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }

        public async Task<List<MLABook>> GetMlaFormatted()
        {
            try
            {
                var data = await _bookDbContext.TblBook.AsNoTracking().ToListAsync();
                List<MLABook> books = new List<MLABook>();
                foreach (var X in data)
                {


                    books.Add(new MLABook()
                    {

                        BookId = X.BookId,
                        AuthorName = MlaFormatter.Author(X.AuthorFirstName, X.AuthorLastName),
                        Title = MlaFormatter.TitleOfSource(X.Title),
                        TitleOfContainer = MlaFormatter.TitleOfContainer(X.TitleOfContainer),
                        Publisher = MlaFormatter.Publisher(X.Publisher),
                        PublishDate = MlaFormatter.PublisherDate(X.PublishDate == null ? "" : Convert.ToDateTime(X.PublishDate).ToString("yyyy")),
                        PageNumbers = MlaFormatter.PageNumbers(X.PageNumbers),
                        Price = MlaFormatter.PageNumbers(X.Price.ToString())
                    });
                }

                return books;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
      
        public async Task<List<MLABookChicago>> GetMlaFormattedChicagostyle()
        {
            try
            {
                var data = await _bookDbContext.TblBook.AsNoTracking().ToListAsync();
                List<MLABookChicago> books = new List<MLABookChicago>();
                foreach (var X in data)
                {


                    books.Add(new MLABookChicago()
                    {

                        BookId = X.BookId,
                        Card = MlaFormatter.Chicagostyle(X.JournalTitle, X.VolumeNo,X.IssueNo,X.PageRange,X.UrlDoi)
                        
                    });
                }

                return books;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
        public async Task<bool> SaveBookData(List<BookInsert> books)
        {
            try
            {
                _ = _bookDbContext.TblBook.AddRangeAsync(books.Select(X => new TblBook
                {
                    AuthorFirstName = X.AuthorFirstName,
                    AuthorLastName = X.AuthorLastName,
                    PageNumbers = X.PageNumbers,
                    Price = X.Price,
                    PublishDate = X.PublishDate,
                    Publisher = X.Publisher,
                    Title = X.Title,
                    TitleOfContainer = X.TitleOfContainer,
                    JournalTitle = X.JournalTitle,
                    VolumeNo =X.VolumeNo,
                    IssueNo =X.IssueNo,
                    PageRange =X.PageRange,
                    UrlDoi =X.URL_DOI
                }).ToList());
                return await _bookDbContext.SaveChangesAsync() == -1 ? false : true;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }

        public async Task<decimal> GetAllBookTotalPrice()
        {
            try
            {
               var val= await _bookDbContext.TblBook.SumAsync(X => X.Price);
                return val == null ? 0 : (decimal)val;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public void Dispose()
        {
        }
    }
}
