using BookWebApi23112022.Dto;
using BookWebApi23112022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi23112022.Repository
{
    public class ADORepo : IADORepo, IDisposable
    {
        private readonly BookDbContext _bookDbContext;
        private readonly IConfiguration _configuration;

        public ADORepo(BookDbContext bookDbContext, IConfiguration configuration)
        {
            _bookDbContext = bookDbContext;
            _configuration = configuration;
        }

        public async Task<List<Book>> GetBooksSortedByPublisherAuthorTitle()
        {

            try
            {
                string query = @"SP_GET_BOOKS_SORTEDBY_PUBLISHER_AUTHOR_TITLE";
                List<Book> root = new List<Book>();
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DbConnection")))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Decimal.TryParse(reader["Price"].ToString(), out decimal value);
                            root.Add(new Book
                            {

                                AuthorFirstName = reader["AuthorFirstName"].ToString(),
                                AuthorLastName = reader["AuthorLastName"].ToString(),
                                BookId = Convert.ToInt32(reader["BookId"]),
                                PageNumbers = reader["PageNumbers"].ToString(),
                                Price = value,
                                PublishDate = Convert.ToDateTime(reader["PublishDate"]),
                                Publisher = reader["Publisher"].ToString(),
                                Title = reader["Title"].ToString(),
                                TitleOfContainer = reader["TitleOfContainer"].ToString(),
                                JournalTitle = reader["JournalTitle"].ToString(),
                                VolumeNo = reader["VolumeNo"].ToString(),
                                IssueNo = reader["IssueNo"].ToString(),
                                PageRange = reader["PageRange"].ToString(),
                                URL_DOI = reader["URL_DOI"].ToString()
                            });
                        }
                        return root;
                    }
                    else
                        return root;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<List<Book>> GetBooksSortedByAuthorTitle()
        {
            try
            {
                string query = @"SP_GET_BOOKS_SORTEDBY_AUTHOR_TITLE";
                List<Book> root = new List<Book>();
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DbConnection")))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Decimal.TryParse(reader["Price"].ToString(), out decimal value);
                            root.Add(new Book
                            {

                                AuthorFirstName = reader["AuthorFirstName"].ToString(),
                                AuthorLastName = reader["AuthorLastName"].ToString(),
                                BookId = Convert.ToInt32(reader["BookId"]),
                                PageNumbers = reader["PageNumbers"].ToString(),
                                Price = value,
                                PublishDate = Convert.ToDateTime(reader["PublishDate"]),
                                Publisher = reader["Publisher"].ToString(),
                                Title = reader["Title"].ToString(),
                                TitleOfContainer = reader["TitleOfContainer"].ToString(),
                                JournalTitle = reader["JournalTitle"].ToString(),
                                VolumeNo = reader["VolumeNo"].ToString(),
                                IssueNo = reader["IssueNo"].ToString(),
                                PageRange = reader["PageRange"].ToString(),
                                URL_DOI = reader["URL_DOI"].ToString()
                            });
                        }
                        return root;
                    }
                    else
                        return root;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
        }
    }
}
