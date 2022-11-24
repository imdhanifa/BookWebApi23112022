using BookWebApi23112022.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi23112022.Repository
{
    public interface IEFRepo
    {
        Task<List<Book>> GetBooksSortedByPublisherAuthorTitle();
        Task<List<Book>> GetBooksSortedByAuthorTitle();
        Task<bool> SaveBookData(List<BookInsert> books);
        Task<decimal> GetAllBookTotalPrice();
        Task<List<MLABook>> GetMlaFormatted();
        Task<List<MLABookChicago>> GetMlaFormattedChicagostyle();
    }
}
