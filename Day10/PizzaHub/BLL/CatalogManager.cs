namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{
    public static List<Pizza> GetAllPizza(){
        List<Pizza>allpizza=(List<Pizza>)DbManager.GetPizzasByDatabase();

        return allpizza;
    }


}
