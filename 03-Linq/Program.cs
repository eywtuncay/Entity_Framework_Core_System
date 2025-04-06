

/*

--- C# 3.0 ile gelen yenilikler ---

1) var kullanımı --> Gelen tipin ne olduğunu bilmediğim durumlarda kullanılır.
2) Auto Property --> Sınıflarda ve struct'larda, backing field (arka alan) tanımlamadan, get ve set metodlarının otomatik olarak oluşturulmasını sağlar
3) Object initializer --> Constructor kullanmadan sınıfa değer ataması yapmamızı sağlar. { }
4) Collection initializer --> Herhangi bir koleksiyonun ilk değerinin vermek istediğimizde kullanırız. { }
5) Anonymous Object (Type) --> 


*/


//1) var kullanımı
using _03_CSarpGelenYenilikler;

var d1 = 123;
var d2 = "Merhaba";
var d3 = 'a';
var d4 = 12.23;
var d5 = 33.55M;
var d6 = 44L;
var d7 = true;
var d8 = new List<string>();
var d9 = new int[10];

//d1 = "merhaba"    //hata veriri çünkü üstte d1' e int ataması yaptı


//C# 4.0'da gelen yenilik

//dynamic    --> Object olarak tutar
dynamic d10 = "Merhaba";
d10 = 123;              //hata vermez. yeniden atama yapar.


//dynamic ve object
object obj = new object();
obj = 12;
int sayi = (int)obj;    //Tür dönüşümü yapılması gerekir.

dynamic d11 = 12;
int sayi2 = d11;        //Tür dönüşümü yapılması gerekmez.



//3) Object initializer
Personel personel = new Personel() { ID = 1, Ad = "Tuncay", Soyad = "Albayrak" };


//4) Collection initializer
List<Personel> liste = new List<Personel> { new Personel { ID = 2, Ad = "Tuncay2", Soyad = "Albayrak2" } };


//5)Anonymous Object (Type)
var d13 = new { Id = 12, Ad = "Kemal", Adres = "Kadıköy" };


