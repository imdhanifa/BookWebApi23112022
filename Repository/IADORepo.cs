using BookWebApi23112022.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi23112022.Repository
{
    public interface IADORepo
    {
        Task<List<Book>> GetBooksSortedByPublisherAuthorTitle();
        Task<List<Book>> GetBooksSortedByAuthorTitle();
    }
}
