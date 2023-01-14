namespace DAL;
using BOL;



public interface IDbManager{

    List<Product> GetAll();
    Product GetById(int id);
    void Insert(Product product);
    void Delete(int id);
    void Update(Product product);
}