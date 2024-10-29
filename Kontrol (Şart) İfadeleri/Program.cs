// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//HAFTA-2


//Girilen sayının çift - tek kontrolü (if)

Console.Write("Bir sayı giriniz: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("Girilen sayı çifttir.");
else
    Console.WriteLine("Girilen sayı tektir.");
Console.ReadKey();



//1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi(örn 1 girildiğinde ekrana BİR yazılsın - switch yapısı)

Console.Write("1 ile 10 arası sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

switch (sayi)
{
    case 1: Console.WriteLine("BİR"); break;
    case 2: Console.WriteLine("İKİ"); break;
    case 3: Console.WriteLine("ÜÇ"); break;
    case 4: Console.WriteLine("DÖRT"); break;
    case 5: Console.WriteLine("BEŞ"); break;
    case 6: Console.WriteLine("ALTI"); break;
    case 7: Console.WriteLine("YEDİ"); break;
    case 8: Console.WriteLine("SEKİZ"); break;
    case 9: Console.WriteLine("DOKUZ"); break;
    case 10: Console.WriteLine("ON"); break;
    default: Console.WriteLine("1 ile 10 arası sayı girmediniz!"); break;
}
Console.ReadKey();



//Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren c# kodu

Console.WriteLine("Kullanıcı adınızı giriniz: ");
string kullanıcı_adı = Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz: ");
string sifre = Console.ReadLine();

if (kullanıcı_adı == "admin")
{
    if (sifre == "Admin_32453@")
        Console.WriteLine("giriş başarılı");
    else
        Console.WriteLine("giriş başarısız");
}
else
    Console.WriteLine("giriş başarısız");
Console.ReadKey();



//10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana (normal - sıcak - çok sıcak) uyarısı veren c# kodu (if else if else if else yapısı)

Console.Write("Sıcaklık değerini giriniz: ");
int sıcaklık = int.Parse(Console.ReadLine());

if (sıcaklık >= 10 && sıcaklık < 20)
    Console.WriteLine("Normal");
else if (sıcaklık >= 20 && sıcaklık < 30)
    Console.WriteLine("Sıcak");
else if (sıcaklık >= 30 && sıcaklık < 40)
    Console.WriteLine("Çok sıcak");
else
    Console.WriteLine("Yanlış değer girdiniz.");
Console.ReadKey();

