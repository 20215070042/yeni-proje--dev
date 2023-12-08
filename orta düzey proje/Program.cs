using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "your_connection_string_here";

    static void Main()
    {
        // Kategori bilgilerini combobox'a yükleme
        LoadCategories();

        // Kullanıcı adı ve parola ile oturum açma
        Login();

        // CRUD işlemleri
        InsertProduct("Product1", 1, 19.99m);
        UpdateProduct(1, "UpdatedProduct", 2, 29.99m);
        DeleteProduct(2);
        DisplayProducts();

        // Arama işlemi
        SearchProduct("Product1");
    }

    static void LoadCategories()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Kategorileri combobox'a ekleyin
                // Örneğin: comboBoxCategories.Items.Add(reader["CategoryName"]);
            }
        }
    }

    static void Login()
    {
        // Kullanıcı adı ve parola ile oturum açma işlemleri
        // Örneğin: kullanıcı adı ve parolayı kullanarak bir SQL sorgusu yapabilir ve doğrulama yapabilirsiniz.
    }

    static void InsertProduct(string productName, int categoryID, decimal price)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("InsertProduct", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametreleri ekleyin
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@CategoryID", categoryID);
            cmd.Parameters.AddWithValue("@Price", price);

            // Execute the command
            cmd.ExecuteNonQuery();
        }
    }

    static void UpdateProduct(int productID, string productName, int categoryID, decimal price)
    {
        // Update işlemleri
    }

    static void DeleteProduct(int productID)
    {
        // Delete işlemleri
    }

    static void DisplayProducts()
    {
        // Ürünleri ekrana yazdırma işlemleri
    }

    static void SearchProduct(string productName)
    {
        // Ürün arama işlemleri
    }
}
