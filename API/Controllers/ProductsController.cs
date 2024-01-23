using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    //get all products
    [HttpGet]
    public string GetProducts()
    {
      return "This will be a list of products";
    }

    //get products/by id
    [HttpGet("{id}")]
    public string GetProducts(int id)
    {
      return "This will be a product";
    }
  }
}
