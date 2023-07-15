Console.WriteLine("Hello, World!");

//Operatörler
//= eşittir operatöri => değer ataması yapar
//== kontrol  operatörü => a ve b değerini kontrol eder

int a = 0;
int b = 1;

var c = (a == b);

// + - * / Matematiksel operatörler

int r = ((5 * 2) + 5) - 0;

// += eşittirden sonraki değeri + işaretinden önceki değere ekler
// -= eşittirden sonraki değeri - işaretinden önceki değerden çıkartır

int z = 1;

z += 5; //===> z = z + 5;

//++; kullanılan değişkenin rakamını 1 artırır
//--; kullanılan değişkenin rakamını 1 azaltır
int x = 1;
x++;
x--;


//+ operatörü string değerlerde birleştirme işlemi yapar;

string name = "Merve" + " " + "Akça"; //Merve Akça
string name2 = $"{name} 35 yaşında bir yazılımcı"; // ==> Merve Akça 35 yaşında bir yazılımcı
//@ operatör  ters bölü işaretini kullanmamızı sağlıyor;
string url = @"http:\"; //==> http:\ 

var result = name + 2; //Rakam + string birleştirme işlemi yapar ==> Merve Akça2

//% => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder 0 ya da küsürat dönüyor

var r2 = (x % 2);