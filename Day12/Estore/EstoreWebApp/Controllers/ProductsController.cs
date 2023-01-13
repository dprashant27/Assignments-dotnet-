using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstoreWebApp.Models;

namespace EstoreWebApp.Controllers;
using BOL;
using BLL;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index(){

        List<Product> allproduct=CatalogManager.GetAllProducts();

        this.ViewBag.products=allproduct;
        return View();       
    }


    public IActionResult Delete(int id){
        CatalogManager.DeleteProduct(id);

        return RedirectToAction("Index");
    }
    public IActionResult Insert()
    {
        Product prod=new Product();
        return View(prod);
    }

    [HttpPost]
    public IActionResult Insert(Product createProduct){

        CatalogManager.InsertProduct(createProduct);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id){
      Console.WriteLine(id);
    List<Product> allproduct=CatalogManager.GetAllProducts();
        Product p=allproduct.Find((prod)=>prod.Id==id);

        Console.WriteLine(p.Id+" "+p.Name+" "+p.Quantity+" "+p.Price);

        this.ViewBag.prod=p;


        return View();
    }


}
