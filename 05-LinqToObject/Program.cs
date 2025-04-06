using _05_LinqToObject;

////LINQ to Object

// Linq sorguları 2 şekilde yazılır.
// 1) Like Sql

//Sorgular
//1-Tüm ürünler?



void Yazdir(IEnumerable<Urun> urunler)
{
	foreach (var item in urunler)
	{
        Console.WriteLine(item);
	}
}


//
var result = from u in UrunContext.Urunler
             select u;


//
var result2 = from u in UrunContext.Urunler
			 where u.KategoriID == 3
			 select u;

//
var result3 = from u in UrunContext.Urunler
			  orderby u.Fiyat descending
			  select u;

//
var result4 = from u in UrunContext.Urunler
			  join k in UrunContext.Kategoriler
			  on u.KategoriID equals k.kategoriID
			  select new { u.UrunID, u.UrunAdi, u.Fiyat, k.KategoriAdi };

foreach (var item in result4)
{
    //Console.WriteLine(item);
}


//Yazdir(result.ToList());
//Yazdir(result2.ToList());
//Yazdir(result3.ToList());




// Linq sorguları 2 şekilde yazılır.
//2) Expression Tree

var sonuc = UrunContext.Urunler.Select(x => x);
//Yazdir(sonuc.ToList());

var sonuc2 = UrunContext.Urunler.Where(x => x.KategoriID == 3);
//Yazdir(sonuc2.ToList());

var sonuc3 = UrunContext.Urunler.OrderByDescending(x => x.Fiyat);
//Yazdir(sonuc3);

var sonuc4 = UrunContext.Urunler.Join(UrunContext.Kategoriler, x => x.KategoriID, y => y.kategoriID, (x, y) => new { x.UrunID, x.UrunAdi, x.Fiyat, y.KategoriAdi });
foreach (var item in sonuc4)
{
    //Console.WriteLine(item);
}





//--------------------------------------------------------------------------------
//--------------------------------------------------------------------------------


//Linq sorguları gecikmeli modda çalışır. (Deffered Mode)
//Yani sorgu yazıldığı yerde değil çağrıldığında derlenir.
//ToList(), ToArray() vb. gibi metodlar Immediate Model olarak çalıştırır.

var id = 111;

var sorgu = from u in UrunContext.Urunler
			where u.UrunID == id
			select u;
id = 141;
Yazdir(sorgu.ToList());		//id'si 141 olanı getirir.




var id2 = 111;

var sorgu2 = (from u in UrunContext.Urunler
            where u.UrunID == id2
            select u).ToString();
id2 = 141;
//Yazdir(sorgu2);		//id'si 111 olanı getirir.


