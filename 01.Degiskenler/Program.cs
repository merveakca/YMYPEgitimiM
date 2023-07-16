Console.WriteLine("Hello World!");

//Bazı değişken tipleri aşağıdadır.
//string, int, decimal, double, float, bool, DateTime, Object

//değişkenlere ilk değer ataması yapılmadığında değerleri aşağıdaki gibidir. Değişkenlerin altının yeşil çizdiğinde, o değişken henüz bir yerde kullanılmamış demektir.
string name;     //null
int age;         //0
bool isActive;   //false

//float tipinde bir değişken tanımladığımızda ve ondalıklı bir değer verdiğimizde (sistem bunu double olarak kabul eder) sistem, implicit dönüşüm (bilinçsiz dönüşüm) yapılamadığı için hata verir. Bunu engellemek için explicit (bilinçli) olarak aşağıdaki gibi dönüşüm yapmamız gerekir.
float n1 = (float)198.7;
int n2 = 200;
float n3 = n1 + n2;
Console.WriteLine(n3);

string nameLastName = "Merve Akça";
name = "asdasd";
char karakter = 'A';

//Satırı aşağıya kaydırmak için; yukarıdaki araç çubuğundan şu sırayı takip edin: Tools/Options/Text Editor/All Languages/Word wrap(seçeneğini aktifleştirin)
string aciklama = "asdasdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd";

Console.WriteLine(nameLastName);




Console.ReadLine();