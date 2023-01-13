using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EPizzaStore.Models;
using BOL;
using BLL;

namespace EPizzaStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  

    public IActionResult Index(){
          List<Pizza> allpizza=(List<Pizza>)CatalogManager.GetAllPizza();
        ViewData["Pizza"]=allpizza;
        return View();
    }

    public IActionResult Details(int id){
      List<Pizza> allpizza=CatalogManager.GetAllPizza();
        Pizza pizza= allpizza.Find(obj=> obj.PizzaId==id);
        ViewData["Pizza"]=pizza;
        return View();
    }

}