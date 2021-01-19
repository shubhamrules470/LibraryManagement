using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        // url - /api/library/activetokens
        [Route("activetokens")]
        public IEnumerable<Token> GetActiveTokens()
        {
            return new List<Token>();
        }

        // url - /api/library/token/5
        [Route("token/{tokenId}")]
        public Token GetTokenById(int tokenId)
        {
            var random = new Random();
            return new Token()
            {
                Id = tokenId,
                BookId = random.Next(1,100),
                BookName = "Book",
                VisitorId = random.Next(1, 100),
                VisitorName = "Visitor",
                IssuedOn = DateTime.Now,
                DueDate = DateTime.UtcNow.AddDays(15),
                IsBookReturn = random.Next(0,1) == 1 ? true : false,
            }; 
        }

        // url - /api/library/issuebook?bookId=4&visitorId=10
        [Route("issuebook")]
        public Token PostIssueBook(int bookId, int visitorId)
        {
            var random = new Random();
            // get book using bookId
            // get visitor details using visitorId 
            // then create a token using book and visitor details
            return new Token() {
                Id = random.Next(100, 1000),
                BookId = bookId,
                BookName = "Book" + bookId,
                VisitorId = visitorId,
                VisitorName = "Visitor" + visitorId,
                IssuedOn = DateTime.Now,
                DueDate = DateTime.UtcNow.AddDays(15),
                IsBookReturn = false,
            };
        }

        [Route("returnbook/{tokenId}")]
        public bool PutReturnBook(int tokenId)
        {
            // change isReturn flag as true and update returnOn and return true.
            return true;
        }

        [Route("duetokens")]
        public IEnumerable<Token> GetDueTokens()
        {
            // return lists of tokens which crossed due date.
            return new List<Token>();
        }
    }
}
