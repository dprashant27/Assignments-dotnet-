namespace Practice;

public class Product{
    public int Id{get;set;}
    public string Name{get;set;}
    public int Quantity{get;set;}
    public double Price{get;set;}
    public string Image{get;set;}

    public Product(int id,string name,int quantity,double price,string image){
        this.Id=id;
        this.Name=name;
        this.Quantity=quantity;
        this.Price=price;
        this.Image=image;

    }
}