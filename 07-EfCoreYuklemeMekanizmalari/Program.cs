using _07_ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");



NorthwindContext northwind = new NorthwindContext();

var urunler = northwind.Products.ToList();
foreach (var product in urunler)
{
    Console.WriteLine(product.ProductId + " " + product.ProductName);
}



//Tüm ürünleri karegori adlarıyla listele

//Like Sql
var urunler2 = from product in northwind.Products
              join category in northwind.Categories
              on product.CategoryId equals category.CategoryId
              select new { product.ProductId, product.ProductName, CategoryName = category.CategoryName};

foreach (var item in urunler2)
{
    Console.WriteLine($"{item.ProductId} - {item.ProductName} - {item.CategoryName}");
}



//EF Core Yükleme Mekanizmaları
//1-Lazy Loading
//2-Eagrer Loading --> Include()
//3-Explicit Loading


//Özel ve En Basit Durum
var listele = northwind.Products.Include(x => x);

foreach (var item in listele)
{
    Console.WriteLine(item.ProductName +  " " + item.Category.CategoryName);
}






