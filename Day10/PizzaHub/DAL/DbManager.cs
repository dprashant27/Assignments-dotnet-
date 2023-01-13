namespace DAL;
using BOL;
using System.Text.Json;
using System.Text.Json.Serialization;
using MySql.Data.MySqlClient;
public class DbManager
{
    public static List<Pizza> GetAllPizza()
    {
        List<Pizza> allPizza = new List<Pizza>();
        allPizza.Add(new Pizza("/images/CheesePizza.jpg", 1, "Cheese Pizza", "It should be no shocker that a classic is the statistical favorite. Cheese pizza is one of the most popular choices. It will always be a simple, unadorned masterpiece on its own.", 50, 299));
        allPizza.Add(new Pizza("/images/VeggiePizza.jpg", 2, "Veggie Pizza", "When you want to jazz up your cheese pizza with color and texture, veggies are the perfect topping. And you're only limited by your imagination. Everything from peppers and mushrooms, to eggplant and onions make for an exciting and tasty veggie pizza.", 60, 399));
        allPizza.Add(new Pizza("/images/PepperoniPizza.jpg", 3, "Pepperoni Pizza", "There's a reason this is one of the most popular types of pizza. Who doesn't love biting into a crispy, salty round of pepperoni?", 40, 245));
        allPizza.Add(new Pizza("/images/MeatPizza.jpg", 4, "Meat Pizza", "If pepperoni just isn't enough, and you're looking for a pie with a bit more heft, a meat pizza is a perfect and popular choice. Pile on ground beef and sausage for a hearty meal.", 35, 450));
        allPizza.Add(new Pizza("/images/MargheritaPizza.jpg", 5, "Margherita Pizza", "Deceptively simple, the Margherita pizza is made with basil, fresh mozzarella, and tomatoes. There's a reason it's an Italian staple and one of the most popular types of pizza in the country.", 50, 385));
        allPizza.Add(new Pizza("/images/BBQ_ChickenPizza.jpg", 6, "BBQ Chicken Pizza", "If you love BBQ chicken and you love pizza, why not put them together? This has long been a cult favorite of sports fans and college kids. The chicken slathered over the top of a pie gives it a tangy, sweet flavor that can't be beaten", 40, 500));
        allPizza.Add(new Pizza("/images/hawaiian-pizza.jpg", 7, "Hawaiian Pizza", "Pineapple might not be the first thing that comes to mind when you think pizza. But add in some ham and it creates an unexpectedly solid sweet and salty combination for this type of pizza", 50, 455));
        allPizza.Add(new Pizza("/images/SupremePizza.jpg", 8, "Supreme Pizza", "When you can't decide which toppings to get, it's time for the supreme pizza. The “supreme” refers to the litany of toppings that come scattered on these pies, from sausage to vegetables to pepperoni. And it's the combination of the flavors that really makes it sing.", 35, 325));

        return allPizza;
    }
public static string conString=@"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
    public static List<Pizza> GetPizzasByDatabase(){
        List<Pizza> allpizza=new List<Pizza>();
        
        Console.WriteLine("in connection");
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;


        try{
            Console.WriteLine("in try catch");
            con.Open();
            Console.WriteLine("conncection opened");
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            string query="select * from Pizza";
            cmd.CommandText=query;
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                var img=reader["img"].ToString();
                var id=int.Parse(reader["PizzaId"].ToString());
                var name=reader["PizzaName"].ToString();
                var desc=reader["Descp"].ToString();
                var qty=int.Parse(reader["Quantity"].ToString());
                var price=double.Parse(reader["Price"].ToString());

                Pizza p=new Pizza(img,id,name,desc,qty,price);

                allpizza.Add(p);

            }

        }catch(Exception e){
           Console.WriteLine( e.StackTrace);
        }finally{

            con.Close();

        }
        return allpizza;
    }







    

/*
    public static void Serialize()
    {
        List<Pizza> allpizza = DbManager.GetAllPizza();
        var options = new JsonSerializerOptions { IncludeFields = true };
        string json = JsonSerializer.Serialize<List<Pizza>>(allpizza, options);
        string filename = @"D:\Cdac Notes\.NET\Assignment\Day10\PizzaHub\EPizzaStore\Pizza.json";

        File.WriteAllText(filename, json);
        Console.WriteLine("file stored succesfully");
    }

    public static List<Pizza> GetAllPizzaByFiles()
    {
        string filename = @"D:\Cdac Notes\.NET\Assignment\Day10\PizzaHub\EPizzaStore\Pizza.json";

            string pizzaJson = File.ReadAllText(filename);
            Console.WriteLine("converted in string");
            List<Pizza> allpizza = JsonSerializer.Deserialize<List<Pizza>>(pizzaJson);
            Console.WriteLine("restored sucesfully");
            return allpizza;       
    }

    */



}
