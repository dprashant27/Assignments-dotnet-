namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DbManager
{
    public static List<Product> GetAllProducts()
    {
        List<Product> allproduct = new List<Product>();
        //step1 write connection string
        string conString = @"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        //step2 create object of Mysqlconnection
        MySqlConnection con = new MySqlConnection();
        //step3 give string to conncection
        con.ConnectionString = conString;

        try
        {
            con.Open();
            string query = "select * from Product";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string name = reader["Name"].ToString();
                int qty = int.Parse(reader["Quantity"].ToString());
                double price = double.Parse(reader["Price"].ToString());
                string img = reader["Image"].ToString();

                Product prod = new Product(id, name, qty, price, img);
                allproduct.Add(prod);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            con.Close();
        }

        return allproduct;
    }

    public static void InsertProduct(Product product)
    {

        string conString = @"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;

        try
        {
            con.Open();
            Console.WriteLine(product.Id + ",'" + product.Name + "'," + product.Quantity + "," + product.Price + ",'" + product.Image);
            string query = "insert into Product values (" + product.Id + ",'" + product.Name + "'," + product.Quantity + "," + product.Price + ",'" + product.Image + "');";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Console.WriteLine(product.Name);
            Console.WriteLine("added succesfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            con.Close();
        }
    }

    public static void DeleteProduct(int id)
    {
        string conString = @"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string query = "Delete from product where id=" + id;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted Succesfully");



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }

    }


}
