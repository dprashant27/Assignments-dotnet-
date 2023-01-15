namespace DAL;
using Practice;
using MySql.Data.MySqlClient;

public class DbManager{

    public static List<Product> GetAllProduct(){
        List<Product> allproduct=new List<Product>();
        string conString=@"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="select * from Product";
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText=query;
            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read()){
                var id=int.Parse(reader["Id"].ToString());
                var name=reader["Name"].ToString();
                var quantity=int.Parse(reader["Quantity"].ToString());
                var price=double.Parse(reader["Price"].ToString());
                var image=reader["Image"].ToString();

                Product prod=new Product(id,name,quantity,price,image);
                allproduct.Add(prod);
            }

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
        return allproduct;      
    }

    public static void Delete(int id){
        MySqlConnection con=new MySqlConnection();
        string conString=@"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        con.ConnectionString=conString;

        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            string query="delete from Product where id="+id;
            cmd.CommandText=query;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted Succesfully");
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
    }

    public static void Insert(Product product){

        MySqlConnection con=new MySqlConnection();
        string conString=@"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        con.ConnectionString=conString;
        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            string query="insert into Product values ("+product.Id+",'"+product.Name+"',"+product.Quantity+","+product.Price+",'"+product.Image+"');";
            cmd.CommandText=query;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Added Succesfully");
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }

    }
}