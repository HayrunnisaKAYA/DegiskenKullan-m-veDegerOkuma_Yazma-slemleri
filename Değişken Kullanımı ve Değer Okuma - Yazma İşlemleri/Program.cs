// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//İki sayının farkını bulan c# kodu
Console.Write("Sayı 1: ");
int sayı1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2: ");
int sayı2 = Convert.ToInt32(Console.ReadLine());
int fark = sayı1 - sayı2;
Console.Write("İki sayının farkı: " + fark);
Console.ReadKey();


//5 sayısının karesini bulan c# kodu
int sayı, karesi;
sayı = 5;
karesi = sayı * sayı;
Console.WriteLine(karesi);
Console.ReadKey();

//10 sayısının 3'e bölümünden kalanı bulan c# kodu
double Sayı, bölüm;
Sayı = 10;
bölüm = Sayı / 3;
Console.WriteLine(bölüm);
Console.ReadKey();

//Klavyeden girilen 4 sayının toplamını ve çarpımını bulan c# kodu
Console.Write("Sayı 1: ");
int sayı_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2: ");
int sayı_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 3: ");
int sayı_3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 4: ");
int sayı_4 = Convert.ToInt32(Console.ReadLine());
int toplam = sayı_1 + sayı_2 + sayı_3 + sayı_4;
Console.WriteLine("Toplam Değeriniz: " + toplam);
int çarpım = sayı_1 * sayı_2 * sayı_3 * sayı_4;
Console.WriteLine("Çarpım Değeriniz: " + çarpım);
Console.ReadKey();

//Klavyeden girilen 2 sayının bölümünü bulan c# kodu
Console.Write("Sayı 1: ");
double Sayı1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2: ");
double Sayı2 = Convert.ToInt32(Console.ReadLine());
double Bölüm = Sayı1 / Sayı2;
Console.Write("İki sayının bölümü: " + Bölüm);
Console.ReadKey();

//Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan c# kodu
Console.Write("Dikdörtgenin eni: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Dikdörtgenin boyu: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Dikdörtgenin yüksekliği: ");
double c = Convert.ToDouble(Console.ReadLine());
double taban_alanı = a * b;
double hacim = taban_alanı * c;
Console.Write("Dikdörtgenler prizmasının hacmi: " + hacim);
Console.ReadKey();


