/*

------- EF CORE -------

Data != Object


Database de Data tutuluyor. C# da ise Object.
ORM toolları Database'deki Data'yı Object'e çevirerek bize getirir.


Code First
Database First
Model First

Connection
Bağlantılı Yöntemde bağlantıyı açıp kapatmak yazılımcının kontrolündedir.


*/


//ADO.NET


using _01_EF.Models;
using Microsoft.Data.SqlClient;

//Connection String
string connStr = "Data source=.;initial catalog=Northwind;integrated security=true;trust server certificate=true;";


//Yeni kategori ekle...
KategoriEkle(new Category { CategoryID = 111, CategoryName = "YAZILIM2"});




SqlConnection conn = new SqlConnection(connStr);
conn.Open();

SqlCommand cmd = new SqlCommand(" select * from Categories ", conn);

SqlDataReader dr = cmd.ExecuteReader();
List<Category> categories = new List<Category>();


while (dr.Read())
{
    Category category = new Category();
    {
        category.CategoryID = dr.GetInt32(0); 
        category.CategoryName = dr.GetString(1); 
    }

    categories.Add(category);
    Console.WriteLine(dr[0].ToString() + dr[1]);
}



conn.Close();



void KategoriEkle(Category category)
{
    SqlConnection conn = new SqlConnection(connStr);

    conn.Open();

    SqlCommand cmd = new SqlCommand("insert into Categories(CategoryName) values(@ad)", conn);

    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@ad", category.CategoryName);
    cmd.ExecuteNonQuery();

    conn.Close();

}

