using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers;
using DAL;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<Product> Get(){
        List<Product> all=DbManager.GetAllProduct();
        
        return all;
    }
    [HttpPost]
     public IActionResult Insert(Product product)
    {
        DbManager.Insert(product);
        
        return Ok();
    }



    //  public IActionResult Index(){

    //     List<Product> allproduct=CatalogManager.GetAllProducts();

    //     this.ViewBag.products=allproduct;
    //     return View();       
    // }


    // public IActionResult Delete(int id){
    //     CatalogManager.DeleteProduct(id);

    //     return RedirectToAction("Index");
    // }
    // public IActionResult Insert()
    // {
    //     Product prod=new Product();
    //     return View(prod);
    // }

    // [HttpPost]
    // public IActionResult Insert(Product createProduct){

    //     CatalogManager.InsertProduct(createProduct);
    //     return RedirectToAction("Index");
    // }

    // public IActionResult Details(int id){
    //   Console.WriteLine(id);
    // List<Product> allproduct=CatalogManager.GetAllProducts();
    //     Product p=allproduct.Find((prod)=>prod.Id==id);

    //     Console.WriteLine(p.Id+" "+p.Name+" "+p.Quantity+" "+p.Price);

    //     this.ViewBag.prod=p;


    //     return View();
    // }
}