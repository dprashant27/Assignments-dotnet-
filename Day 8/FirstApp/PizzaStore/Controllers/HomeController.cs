using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace PizzaStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        string filename=@"D:\Cdac Notes\.NET\Assignment\Day 8\FirstApp\PizzaStore\object.json";
        string jsonString=System.IO.File.ReadAllText(filename);
        abc=JsonSerializer.Deserialize<List<User>>(jsonString);
        return View();
    }
    static List<User>abc=new List<User>();

    public IActionResult Validate(string email,string password){
        
        string filename=@"D:\Cdac Notes\.NET\Assignment\Day 8\FirstApp\PizzaStore\object.json";
        string jsonString=System.IO.File.ReadAllText(filename);
        abc=JsonSerializer.Deserialize<List<User>>(jsonString);

      User person=abc.Find(obj=>obj.Email==email);
        
        if(email==person.Email && password==person.Password){
            return Redirect("/home/welcome");
        }

        return View();
    }

    public IActionResult Welcome(){
        return View();
    }

    public IActionResult Store(string nm,string email,string pass){
         
        abc.Add(new User(){Username=nm,Email=email,Password=pass});
        var options=new JsonSerializerOptions{IncludeFields=true};
        var userJson=JsonSerializer.Serialize(abc,options);
        var filename=@"D:\Cdac Notes\.NET\Assignment\Day 8\FirstApp\PizzaStore\object.json";

        System.IO.File.WriteAllText(filename,userJson);
        
        return Redirect("index");
  
    }
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
