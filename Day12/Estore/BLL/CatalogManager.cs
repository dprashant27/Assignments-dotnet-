namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{

    public static List<Product> GetAllProducts(){
        List<Product> allproduct=DbManager.GetAllProducts();

        return allproduct;
    }

    public static void InsertProduct(Product product){
        DbManager.InsertProduct(product);
    }

    public static void DeleteProduct(int id){
        DbManager.DeleteProduct(id);
    }
}
