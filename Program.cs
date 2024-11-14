// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

/* Soru 1 - Foreach Döngüsü ile Liste Elemanlarını Yazdırma */
//ArrayList tamsayılar = new ArrayList();
//tamsayılar.Add(29);
//tamsayılar.Add(34);
//tamsayılar.Add(12);
//tamsayılar.Add(94);

//int toplam = 0;

//foreach (int s in tamsayılar)
//{
//    toplam += s;
//    Console.WriteLine(s);
//}
//Console.Write("Sayıların toplamı: " + toplam);




/* Soru 2 - Hazır Metod Kullanımı */
//Console.Write("Bir cümle giriniz: ");
//string cumle = Console.ReadLine();

//string[] yenicumle = cumle.Split(" ");

//int kelimesayisi = yenicumle.Count();
//Console.WriteLine("Cümlenizdeki kelime sayısı: " + kelimesayisi);




/* Soru 3 - ArrayList ile Alfabetik Sıralama */
//ArrayList isimler = new ArrayList();
//Console.WriteLine("5 adet isim giriniz: ");

//for (int i = 0; i < 5; i++)
//{
//    string z = Console.ReadLine();
//    isimler.Add(z);
//}

//isimler.Sort();
//Console.WriteLine("İsimlerin alfabetik sıralanmış hali: ");
//foreach (string isim in isimler)
//{
//    Console.WriteLine(isim);
//}




/* Soru 4 - For Döngüsü ile Fibonacci Serisi */
//Console.Write("Kaç fibonacci sayısı hesaplanacak: ");
//int sayi = int.Parse(Console.ReadLine());

//int sayi1 = 0;
//int sayi2 = 1;

//for (int i = 0; i < sayi; i++)
//{
//    Console.Write(sayi1 + " ");
//    int next = sayi1 + sayi2;
//    sayi1 = sayi2;
//    sayi2 = next;
//}




/* Soru 5 - While Döngüsü ile Tahmin Oyunu */
//Random random = new Random();
//int sayi = random.Next(0, 10);

//Console.Write("Tahmininizi giriniz: ");
//int tahmin = int.Parse(Console.ReadLine());

//while (sayi != tahmin)
//{
//    Console.WriteLine("Tahmininiz yanlış yeni bir sayı giriniz!");
//    tahmin = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");




/* Soru 6 - Do While Döngüsü ile Basit Hesap Makinesi */
//double sayi1, sayi2, islem;
//string sonuc;
//Console.WriteLine("Toplama : 1 ");
//Console.WriteLine("Çıkarma : 2 ");
//Console.WriteLine("Çarpma : 3 ");
//Console.WriteLine("Bölme : 4 ");

//do
//{
//    Console.Write("1.sayıyı giriniz: ");
//    sayi1 = double.Parse(Console.ReadLine());
//    Console.Write("2.sayıyı giriniz: ");
//    sayi2 = double.Parse(Console.ReadLine());

//    Console.Write("Yapmak istediğiniz işlemin numarasını giriniz: ");
//    islem = double.Parse(Console.ReadLine());
//    if (islem == 1)
//    {
//        islem = sayi1 + sayi2;
//        Console.WriteLine("Toplama işleminin sonucu: " + islem);
//    }
//    else if (islem == 2)
//    {
//        islem = sayi1 - sayi2;
//        Console.WriteLine("Çıkarma işleminin sonucu: " + islem);
//    }
//    else if (islem == 3)
//    {
//        islem = sayi1 * sayi2;
//        Console.WriteLine("Çarpma işleminin sonucu: " + islem);
//    }
//    else if (islem == 4)
//    {
//        if (sayi2 != 0)
//        {
//            islem = sayi1 / sayi2;
//            Console.WriteLine("Bölme işleminin sonucu: " + islem);
//        }
//        else
//            Console.WriteLine("HATA!Sayıyı sıfıra bölersek tanımsız olur.");
//    }
//    else
//        Console.WriteLine("Seçtiğiniz işlem 1 ile 4 arasında olmalı!");
//    Console.Write("Çıkmak istiyorsanız çıkış yazınız: ");
//    sonuc = Console.ReadLine();
//}
//while (sonuc != "çıkış");




/* Soru 7 - For ve While Döngüsü ile Sayı Toplama Oyunu */
//List<int> sayilar = new List<int>();
//int toplam = 0;
//int sayi;
//int i = 0;

//do
//{
//    Console.Write("Bir sayı giriniz: ");
//    sayi = Convert.ToInt32(Console.ReadLine());

//    if (sayi > 0)
//    {
//        sayilar.Add(sayi);
//    }
//    else if (sayi < 0)
//    {
//        Console.WriteLine("Girdiğiniz sayı pozitif değil. Lütfen pozitif bir sayı giriniz.");
//    }
//    Console.WriteLine("Pozitif tam sayılar giriniz. Çıkmak için '0' tuşlayınız.");
//}
//while (sayi != 0);
//int uzunluk = sayilar.Count;

//while (i < uzunluk)
//{
//    toplam = toplam + sayilar[i];
//    i++;
//}

//for (i = 0; i < uzunluk; i++)
//{
//    Console.WriteLine(" " + sayilar[i]);
//}
//Console.WriteLine("Sayıların toplamı: " + toplam);



Console.ReadKey();