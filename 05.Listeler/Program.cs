Console.WriteLine("Hello, World!");

//[ ] => listeleri temsil eder => array işareyi

//string[] names = { "asdas", "asdasd" };
//index numarası desem => 0'dan başlar
//string[] names = new string[3];
//names[0] = "Merve";
//names[1] = "Merve";
//names[2] = "Merve";

//List<string> names = new List<string>() { "sadasd", "asdasd" };

List<string> names = new(); //örneğe dönüştürmek için new kelimesini kullanıyoruz. Örneğe dönüştürme işleminde yazılımda "instance" üretme deniyor

names.Add("Merve"); //0
names.Add("Merve"); //1
names.Add("Merve"); //2
names.Add("Merve"); //3
names.Add("Merve"); //4
names.Add("Merve"); //5
names.Add("Merve"); //6
names.Add("Merve"); //7
names.Add("Merve"); //8
names.Add("Merve"); //9
names.Add("Merve"); //10
names.Add("Merve"); //11
names.Add("Merve"); //12
names.Add("Merve"); //13

names[12] = "Mevlüt";

Console.WriteLine(names.GetType());

//class User
//{
//    public string Name;
//}

//var user1 = new User();
//var user2 = new User();
//var user3 = new User();

////List<User> users = new List<User>();
//List<User> users = new();