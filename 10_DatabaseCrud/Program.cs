using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PMH598B\SQLEXPRESS01;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)",sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@p1", categoryName);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.Write("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PMH598B\SQLEXPRESS01;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı.");

            #endregion

            #region Ürün Listeleme İşlemi   

            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PMH598B\SQLEXPRESS01;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //connection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PMH598B\SQLEXPRESS01;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PMH598B\SQLEXPRESS01;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı.");

            #endregion

            Console.Read();
        }
    }
}
