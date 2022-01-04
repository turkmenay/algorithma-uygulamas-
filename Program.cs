using System;

namespace algorithma_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pozitif bir sayı giriniz: ");
            int indis = Int32.Parse(Console.ReadLine());
            int[] ciftDizi = new int[indis];
            for (int i = 0; i < indis; i++)
            {
                Console.WriteLine("{0}. sayıyı girin :",i+1);
                ciftDizi[i] = Int32.Parse(Console.ReadLine());               
            }
            islemler.cift(ciftDizi);

            Console.WriteLine("iki adet sayı giriniz :");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] sayi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.sayıyı girin :",i+1);
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in sayi)
            {
                if (item%m == 0)
                Console.WriteLine(item);
            }
            Console.Write("pzitif bir sayı girin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[a];
            for (int i = 0; i < a ; i++)
            {
                Console.WriteLine("{0}.kelimeyi girin: ",i+1);
                kelimeler[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            string alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz"
                           + "0123456789";
            string[] kelime = cumle.Split(" ");
                int sayac =0;
                for (int i = 0; i < cumle.Length; i++)
            {
                if (alfabe.Contains(cumle[i]))
                sayac++;
            }
            Console.WriteLine("Cümlede {0} tane kelime ve {1} tane harf vardır",kelime.Length,sayac);

        }
    }
    public class islemler
    {
        public static void cift(int[] param)
        {
            foreach (var item in param)
            {
                if (item%2 == 0)
                    Console.WriteLine(item);
            }
        }

    }
}
