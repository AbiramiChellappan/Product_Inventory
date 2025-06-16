using Microsoft.AspNetCore.Mvc;
using ProductsInventory.api.Models;

namespace ProductsInventory.api.Controllers;

[ApiController]
[Route("[api/controller]")]
public class ProductsController : ControllerBase
{
    // public int getCount()
    // {
    //     throw new NotImplementedException("Not yet implemented");
    // }

    [HttpPost]
    public ActionResult CreateProduct([FromBody] Product product)
    {
        return Ok(product);
    }

    [HttpGet]
    public ActionResult GetProduct()
    {
        return Ok();
    }
}
