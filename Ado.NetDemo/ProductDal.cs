using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Ado.NetDemo
{
   public class ProductDal
    {
        public List<Product> GetAll()//Ürünleri döndüren method (List(Array) tipinde)
        {
            SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            //structured querry language ( SQL)        
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id=Convert.ToInt32(reader["Id"]),
                    Name=Convert.ToString (reader["Name"]),//ToString() de olur.
                    StockAmount=Convert.ToInt32( reader["StockAmount"]),
                    UnitPrice=Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            reader.Close();
            connection.Close();
            return products;
        }

        //public DataTable GetAll2() //Ürünleri döndüren method (DataTable tipinde)
        //DataTable pahalı bir nesnedir.Hemde serileştirme özelliği yoktur bu yüzden pek kullanılmaz.
        //{
        //    SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //    //structured querry language ( SQL)        
        //    SqlCommand command = new SqlCommand("Select * from Products", connection);
        //    SqlDataReader reader = command.ExecuteReader();
        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    reader.Close();
        //    connection.Close();
        //    return dataTable;
        //}
    
    }
}
