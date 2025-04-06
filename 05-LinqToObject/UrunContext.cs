using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LinqToObject
{
    internal static class UrunContext
    {
        public static List<Kategori> Kategoriler => new List<Kategori>
        {
            new Kategori{kategoriID = 1, KategoriAdi = "Kırtasiye"},
            new Kategori{kategoriID = 2, KategoriAdi = "Hobi"},
            new Kategori{kategoriID = 3, KategoriAdi = "Hediyelik Eşya"},
            new Kategori{kategoriID = 4, KategoriAdi = "Elektronik"},
        };

        public static List<Urun> Urunler => new List<Urun>
        {
            new Urun{UrunID=111, UrunAdi = "Defter", Fiyat=50, KategoriID=1},
            new Urun{UrunID=117, UrunAdi = "Pergel", Fiyat=155, KategoriID=1},
            new Urun{UrunID=118, UrunAdi = "Maket Uçak", Fiyat=2500, KategoriID=2},
            new Urun{UrunID=110, UrunAdi = "Puzzle", Fiyat=500, KategoriID=2},
            new Urun{UrunID=120, UrunAdi = "Vazo", Fiyat=750, KategoriID=3},
            new Urun{UrunID=121, UrunAdi = "Magnet", Fiyat=30, KategoriID=3},
            new Urun{UrunID=131, UrunAdi = "Anahtarlık", Fiyat=30, KategoriID=3},
            new Urun{UrunID=141, UrunAdi = "Hesap Makinesi", Fiyat=1500, KategoriID=1},
        };

       
        

    }
}
