

/*

---- Extension Methods ----

Bir sınıfın ya da tipin mevcut kaynak kodunu değiştirmeden, o sınıf veya tipe yeni metodlar eklememizi sağlar.

Static bir sınıf içerisine yazılmalıdır. Bu sebeple metotun da static olması gerekir.

Hangi yapıya bağlamak istiyorsak metodun ilk parametresinde this keywordü ile bağlamak istediğimiz yapı belirtilir.


*/


using _04_ExtensionMethods;

int sayi = 2;

Console.WriteLine(sayi.KareAl());

Console.WriteLine(sayi.SayiIleCarp(3));


List<int> list1 = new List<int>();

Dictionary<int, int> list2 = new Dictionary<int, int>();



//C#'a gelen yeilikler
//7) Expression Tree    --> Yan yana yazma

Console.WriteLine(sayi.KupAl().IkiyeBol().KareAl().SayiIleCarp(5));


//8) Lambda Expression --> x => x






