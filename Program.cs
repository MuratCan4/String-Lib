using System;

namespace str
{
    class Program
    {
        static void Main (string[] args)
        {
            string cumle = "Merhaba Benim Murat";
            string cumle_iki = "Bugün Hava Güzel";

            //karakter uzunluğu Lengt
            Console.WriteLine("Cümledeki Karakter Sayısı = "+cumle.Length);

            //topupper-tolower
            Console.WriteLine(cumle.ToLower());
            Console.WriteLine(cumle.ToUpper());

            //concat
            Console.WriteLine(string.Concat(cumle," Soy Adım CAN"));

            //compare-compareto
            Console.WriteLine(cumle.CompareTo(cumle_iki));
            Console.WriteLine(string.Compare(cumle,cumle_iki,true));
            Console.WriteLine(string.Compare(cumle,cumle_iki,false));

            //contains (değişkenin içinde aynı değişken varsa true döner)
            Console.WriteLine(cumle.Contains(cumle_iki));

            //endswith-starstwith
            Console.WriteLine(cumle.StartsWith("Merhaba"));
            Console.WriteLine(cumle.EndsWith("Merhaba"));

            //indexof-index numarasını verir//lastindexof en son nerede gördüyse oranın index numarasını verir
            Console.WriteLine(cumle.IndexOf("Be"));
            Console.WriteLine(cumle.LastIndexOf("a"));

            //
            Console.WriteLine(cumle,cumle_iki.PadLeft(35));
            Console.WriteLine(cumle,cumle_iki.PadLeft(35),'-');

            Console.WriteLine(cumle.Remove(2,3));

            //replace karakterleri değiştirir
            Console.WriteLine(cumle.Replace("Benim","Ben"));

            Console.WriteLine(cumle.Substring(3,6));

            




        }
    }
}