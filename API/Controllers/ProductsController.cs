using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        
       [HttpGet]
       public string GetProducts(){
        
        return "This will return products";

       }


       [HttpGet("{id}")]
       public string GetProduct(int id){
        
        return "This will return product";

       }



    }
}