using BOL;
namespace DAL;

public class DbManager{

    public static List<Product> GetProducts(){
       using(var context=new CollectionContext())
        {
            var allproducts=from prod in context.Product select prod;
             return allproducts.ToList<Product>();
        }  
    }
}