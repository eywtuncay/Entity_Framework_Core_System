
/*

Önce paketleri yükleyeceğim
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer

Ef'nin ilk kuralı primary key oluşturmak.


*/


using _02_Ef.Data;
using _02_Ef.Models;

Console.WriteLine("Ef-Core Code First --> Model First");


PersonelContext context = new PersonelContext();

//context.Database.EnsureDeleted();

//context.Database.EnsureCreated();


//Ekleme İşlemi.
//context.Bolumler.Add(new _02_Ef.Models.Bolum { BolumAdi = "Ik" });
//context.SaveChanges();


//Listeleme İşlemi.
//foreach (var bolum in context.Bolumler)
//{
//    Console.WriteLine(bolum.BolumID + " "+ bolum.BolumAdi);
//}


//Güncelleme işlemi. --> Ik'yı Insan Kaynaklarına çevirdim
//var ik = context.Bolumler.Find(3);    
//ik.BolumAdi = "Insan Kaynakları";

//context.Bolumler.Update(ik);  //Yeni Usül.
//context.SaveChanges();

//context.Entry<Bolum>(ik).State = Microsoft.EntityFrameworkCore.EntityState.Modified;  //Eski Usül
//context.SaveChanges();
//foreach (var bolum in context.Bolumler)
//{
//    Console.WriteLine(bolum.BolumID + " "+ bolum.BolumAdi);
//}



//Silme İşlemi.
context.Bolumler.Remove(context.Bolumler.Find(1));
context.SaveChanges();


foreach (var bolum in context.Bolumler)
{
    Console.WriteLine(bolum.BolumID + " "+ bolum.BolumAdi);
}




