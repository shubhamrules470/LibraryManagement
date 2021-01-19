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
    public class VisitorsController : ControllerBase
    {
        // url - /api/visitors/all
        [Route("all")]
        public IEnumerable<Visitor> GetAllVisitors()
        {
            var random = new Random();
            return Enumerable.Range(1, 10).Select(index => new Visitor 
            { 
                Id = index,
                DisplayName = "Name " + index,
                AccountStatus = AccountStatus.Active,
                Gender = (Gender)random.Next(0,1),
                DateJoined = new DateTime(2020,1,1)
            });
        }

        // url - /api/visitors/detail/5
        [Route("detail/{id}")]
        public Visitor GetVisitorById(int id)
        {
            var random = new Random();
            return new Visitor()
            {
                Id = id,
                DisplayName = "Name " + id,
                AccountStatus = AccountStatus.Active,
                Gender = (Gender)random.Next(0,1),
                DateJoined = new DateTime(2020, 1, 1)
            };
        }

        // url - /api/visitors/add
        [Route("add")]
        public int PostNewVisitor([FromBody] Visitor visitor)
        {
            var random = new Random();
            return random.Next(11, 1000);
        }

        // url - /api/visitors/update/4
        [Route("update/{id}")]
        public bool PutVisitorDetails(int id, [FromBody] Visitor visitor)
        {
            return true;
        }

        // url - /api/visitors/remove/4
        [Route("remove/{id}")]
        public bool DeleteVisitor(int id)
        {
            return true;
        }

        // url - /api/visitors/block/4
        [Route("block/{id}")]
        public bool PutBlockVisitor(int id)
        {
            // update account status of visitor to block
            return true;
        }

        // url - /api/visitors/unblock/4
        [Route("unblock/{id}")]
        public bool PutUnblockVisitor(int id)
        {
            // update account status of visitor to unblock
            return true;
        }
    }
}
