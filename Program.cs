using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (while)bir sayı gir girilen sayıdaki çift sayıları ve tek sayıları ayrı ayrı toplayıp yazdır
            //int sayi;
            //int i = 1;
            //int cifttoplam = 0;
            //int tektoplam = 0;

            //Console.WriteLine("Sayı girin:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //while (i <= sayi)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam += i;
            //    }
            //    else
            //    {
            //        tektoplam += i;
            //    }
            //    i++;
            //}


            #endregion

            #region (while)sayı kadar geri versiyon
            //Console.WriteLine("Sayı girin: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int i = 1;

            //while (i <= sayi)
            //{
            //    for (int j = sayi; j >= i; j--)
            //    {
            //        Console.Write(i);
            //    }
            //    i++;

            //}
            #endregion

            #region (while)ayı kadar düz versiyon
            //Console.WriteLine("Sayı girin: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int i = 1;

            //while (i <= sayi)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    i++;

            //}

            #endregion

            #region (while)4 satır yıldız
            //int i = 0;
            //while (i < 4)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    i++;
            //}
            #endregion

            #region (while)ağa yatık yıldız

            //int i = 0;

            //while (i <= 5)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            #endregion

            #region (while)Fibonacci

            //int a = 1;
            //int b = 1;
            //int i = 0;
            //Console.Write("sayi girin: ");
            //int sayi = int.Parse(Console.ReadLine());
            //while (i < sayi)
            //{
            //    Console.Write(a + " ");
            //    int adim = a + b;
            //    a = b;
            //    b = adim;
            //    i++;
            //}
            #endregion

            #region (while)baklava desen
            //int i = 0;

            //while (i < 4)//0 1
            //{
            //    Console.WriteLine();
            //    for (int j = 3 - i; j > 0; j--)//3 2 1 0
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2 * i + 1; k++)//0 1
            //    {
            //        Console.Write("*");
            //    }
            //    i++;
            //}

            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine();
            //    int j = 0;
            //    while (j < i + 1)
            //    {
            //        Console.Write(" ");
            //        j++;
            //    }

            //    int k = 5 - (i * 2);

            //    while (k > 0)
            //    {
            //        Console.Write("*");
            //        k--;
            //    }
            //}

            #endregion

            #region (while)çam ağacı
            /*
             * 
            ***
           *****
          *******
            ***
            ***
            ***
             */
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine();
            //    for (int j = 4 - i; j > 0; j--)//boşluk sayısı ilk satırde 4 boşluk, ikinci satırda 3 boşluk...
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2 * i + 1; k++)//yıldız sayısı hesaplanıyor i 1 ken yıldız 1 * 2 + 1 yani 3 olacak....
            //    {
            //        Console.Write("*");
            //    }
            //    i++;
            //}
            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine();

            //    int j = 0;
            //    while (j < 3)
            //    {
            //        Console.Write(" ");
            //        j++;
            //    }

            //    int m = 0;
            //    while (m < 3)
            //    {
            //        Console.Write("*");
            //        m++;
            //    }
            //}
            #endregion

            #region (while)asal sayılar

            //kullanıcının girdiği sayıya kadar olan asal sayıları yazdır

            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //string metin = "";
            //int i = 2;

            //while (i <= sayi)
            //{
            //    bool durum = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        while (i % j == 0)
            //        {
            //            durum = false;
            //            break;
            //        }
            //    }

            //    if (durum == true)
            //    {
            //        metin = metin + i + " ";
            //    }

            //    i++;
            //}
            //Console.WriteLine(metin);

            #endregion

            #region (while)1000 sayısının bölenleri

            //int i = 1;

            //while (i <= 1000)
            //{
            //    if (1000 % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            #endregion

            #region (while)para çekme, para gönderme, bakiye kontrolü, çıkış, 3 kere giriş hakkı

            int bakiye = 500;
            int secim = 0;
            int hak = 3;
            int sifre = 0000;

        y:
            Console.WriteLine("Lütfen şifrenizi giriniz: ");
            int password = int.Parse(Console.ReadLine());

            while (hak > 0)
            {

                if (password == sifre)
                {
                x:
                    Console.WriteLine("1) Para Çekme \n2) Para Gönderme \n3) Bakiye Kontrolü \n4) Çıkış");
                    secim = int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Çekmek istediğiniz miktarı girin: ");
                            int miktar = int.Parse(Console.ReadLine());

                            if (miktar <= bakiye)
                            {
                                Console.WriteLine("Çekmek istediğiniz miktar: " + miktar + " Bakiyeniz: " + bakiye + " Kalan bakiye: " + (bakiye - miktar));
                                bakiye -= miktar;
                                goto x;
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye, ana menüye gönderiliyorsunuz...");
                                goto x;
                            }

                        case 2:
                            Console.WriteLine("Göndermek istediğiniz miktarı girin: ");
                            int para = int.Parse(Console.ReadLine());

                            Console.WriteLine("Göndermek istediğiniz miktar: " + para + " Bakiyeniz: " + bakiye + " Kalan bakiye: " + (bakiye + para));
                            bakiye += para;
                            goto x;


                        case 3:
                            Console.WriteLine("Bakiye kontrolünüzü yapmak istediniz, bakiyeniz: " + bakiye);
                            goto x;

                        case 4:
                            Console.WriteLine("Çıkış yapmak istediniz, iyi günler.");
                            break;
                    }
                    break;
                }

                while (password != sifre)
                {
                    Console.WriteLine("Yanlış şifre, lütfen tekrar deneyin. Kalan hakkınız: " + (hak - 1));
                    hak--;

                    if (hak == 0)
                    {
                        Console.WriteLine("3 ten fazla yanlış şifre girdiğiniz için hakkınız bitti -_-");
                        break;
                    }
                    else if (hak != 0)
                    {
                        goto y;
                    }
                }

            }
            #endregion

        }
    }
}
