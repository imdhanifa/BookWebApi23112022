using BookWebApi23112022.Dto;
using BookWebApi23112022.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi23112022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IEFRepo _eFRepo;
        private readonly IADORepo _aDORepo;

        public BookController(ILogger<BookController> logger, IEFRepo eFRepo,IADORepo aDORepo)
        {
            _logger = logger;
            _eFRepo = eFRepo;
            _aDORepo = aDORepo;
        }

        [HttpGet("get-ado-pat")]
        public async Task<IActionResult> GetADOBooksSortedByPublisherAuthorTitle()
        {
            try
            {
                var result = await _aDORepo.GetBooksSortedByPublisherAuthorTitle();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        [HttpGet("get-ado-at")]
        public async Task<IActionResult> GetADOBooksSortedByAuthorTitle()
        {
            try
            {
                var result=await _aDORepo.GetBooksSortedByAuthorTitle();
                return Ok(result);

            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }


        }

        [HttpGet("get-ef-pat")]
        public async Task<IActionResult> GetBooksSortedByPublisherAuthorTitle()
        {
            try
            {
                var result =await _eFRepo.GetBooksSortedByPublisherAuthorTitle();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        [HttpGet("get-ef-at")]
        public async Task<IActionResult> GetBooksSortedByAuthorTitle()
        {
            try
            {
                var result= await _eFRepo.GetBooksSortedByAuthorTitle();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        [HttpGet("get-total-price")]
        public async Task<IActionResult> GetAllBookTotalPrice()
        {
            try
            {
                var result=await _eFRepo.GetAllBookTotalPrice();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        [HttpGet("get-mla-formatted")]
        public async Task<IActionResult> GetMlaFormatted()
        {
            try
            {
                var result=await _eFRepo.GetMlaFormatted();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        [HttpGet("get-Chicagostyle")]
        public async Task<IActionResult> GetChicagostyleFormatted()
        {
            try
            {
                var result = await _eFRepo.GetMlaFormattedChicagostyle();
                return Ok(result);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
            

        }

        [HttpPost("Save")]
        public async Task<IActionResult> SaveBookData([FromBody] List<BookInsert> books)
        {
            try
            {
                var result =await _eFRepo.SaveBookData(books);
                var Message = result ? "save" : "Not Save";
                return Ok(Message);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

    }
}
