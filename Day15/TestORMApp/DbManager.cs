namespace DAL;
using BOL;
public class DbManager:IDbManager{

    public List<Product> GetAll()
    {
        using(var context=new CollectionContext())
        {
            var allproducts=from prod in context.Product select prod;
             return allproducts.ToList<Product>();
        }      
    }

    public Product GetById(int id)
    {
        using(var context=new CollectionContext())
        {
            var product=context.Product.Find(id);
            return product;
        }
   
    }

    public void Insert(Product product)
    {
        using(var context=new CollectionContext())
        {
            context.Product.Add(product);
            context.SaveChanges();
        }

    }

    public void Delete(int id)
    {
        using(var context=new CollectionContext())
        {
            context.Product.Remove(context.Product.Find(id));
            context.SaveChanges();
        }
    }

    public void Update(Product product)
    {
        using(var context=new CollectionContext())
        {
            Product prod=context.Product.Find(product.Id);
            prod.Name=product.Name;
            prod.Quantity=product.Quantity;
            prod.Price=product.Price;
            prod.Image=product.Image;
            context.SaveChanges();

        }
    }




}