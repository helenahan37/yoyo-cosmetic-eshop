using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly IGenericRepository<Product> _productsRepo;
    private readonly IGenericRepository<ProductBrand> _ProductBrandRepo;
    private readonly IGenericRepository<ProductType> _ProductTypeRepo;


    public ProductsController(IGenericRepository<Product> productsRepo, IGenericRepository<ProductBrand> productBrandRepo, IGenericRepository<ProductType> productTypeRepo)
    {
      this._ProductTypeRepo = productTypeRepo;
      this._ProductBrandRepo = productBrandRepo;
      this._productsRepo = productsRepo;

    }


    //get all products
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
      var products = await _productsRepo.ListAllAsync();
      return Ok(products);
    }


    //get products/by id
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProducts(int id)
    {
      return await _productsRepo.GetByIdAsync(id);
    }

    //get product brands
    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
    {
      return Ok(await _ProductBrandRepo.ListAllAsync());
    }

    //get product types
    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
    {
      return Ok(await _ProductTypeRepo.ListAllAsync());
    }
  }
}
