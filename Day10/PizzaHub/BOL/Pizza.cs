namespace BOL;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class Pizza
{
    public string Img{get;set;}
    public int PizzaId{get;set;}
    public string? PizzaName{get;set;}
    public string? Descp{get;set;}
    public int Quantity{get;set;}
    public double Price{get;set;}

    public Pizza(string img,int id,string name,string desc,int qty,double price){
        this.Img=img;
        PizzaId=id;
        PizzaName=name;
        Descp=desc;
        Quantity=qty;
        this.Price=price;
    }


}
