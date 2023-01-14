using BOL;
using DAL;

IDbManager db=new DbManager();
List<Product> allproduct=db.GetAll();

foreach(var product in allproduct){
    Console.WriteLine(product.Name);
}



