using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }
        
        [HttpGet("not found")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);
            if(thing == null){
                return NotFound();
            }
            return Ok();

        }

         [HttpGet("servererror")]
         public ActionResult GetServerError(){

            var thing = _context.Products.Find(42);

            var thingToReturn = thing.ToString();

            return Ok();

        }


        [HttpGet("badrequest")]
          public ActionResult GetBadRequest()
          {

            return BadRequest();
            
         }

          [HttpGet("badrequest/{id}")]
          public ActionResult GetBadRequest(int id)
          {
            
            return BadRequest();
            
         }
    }
}