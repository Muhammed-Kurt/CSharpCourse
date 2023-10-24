using System;

namespace _4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays - Diziler
            /*Aynı türde birden çok değişkeni bir dizi veri yapısında saklayabilirsiniz.
             *Dizi Kullanımı
             *Dizi_tipi[] Dizi_ismi=new Dizi_tipi[Eleman_sayısı];
             *ÖNEMLİ BİLGİ: Dizilere değer atama işlemi 0 (sıfır) dan başlamaktadır.İndeks numarası 0,1,2,3 şeklinde devam eder.
             *Dizilerde belirtilen eleman sayısı kadar ekleme yapabilirsiniz.
             *Dizilerde değer atamak için 2 yol vardır ;
             *Yol 1;
             *Dizi_ismi[0]="…";
              Dizi_ismi[1]="…";
              Dizi_ismi[2]="…";
              .
              .
              .
              Dizi_ismi[n]="…";

             *Yol 2;
             *Dizi_tipi[] Dizi_ismi={"...","...","..."};
             *
             *Diziyi Ekrana yazdırma;
             *Console.WriteLine(Dizi_ismi[Sırası]);

             * Dizilerde sıklıkla kullanılan hazır metodlar;
             * Length, Clear, Reverse, Sort, İndexOf, Copy
            */

            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            //string[] students2 = { "Engin", "Derin", "Salih" };
            //students2[3] = "Ahmet";

            //foreach (string student in students2)
            //{
            //    Console.WriteLine(students);
            //}

            #region Multidimensional Arrays - Çok Boyutlu Diziler
            /*Çok boyutlu diziler, bir dizinin birden fazla boyuta sahip olmasıdır.
             *Çok boyutlu diziler, satırlara ve sütunlara ayrılmış veri kümeleridir.
             *2 boyutlu dizilerin kullanımı ;
             *string[,] Dizi= new string[Satır_sayısı,Sütun_sayısı] 
             *string[,] Dizi= new string[0.Dimesion,1.Dimension] 
             *3 boyutlu dizilerin kullanımı ;
             *int[,,] Dizi2 = new int[Satır_sayısı,Sütun_sayısı,Verilen_Değer]
             */
            string[,] regions = new string[5, 3]
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*************");
            }
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
