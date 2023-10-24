using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loops - Döngüler
            /* Döngüler, belirli bir işlemi yinelememize, veri koleksiyonlarını gezmemize 
             * ve programlarımızı daha verimli hale getirmemize yardımcı olur.
             * 4 çeşit döngü yapısı vardır bunlar;
             *  For Loop, While Loop, Do-While Loop, Foreach Loop 
             */
            #region For Loop
            /* For Döngüsü
             * for yazıp 2 defa tab tuşuna basarak kolay bir şekilde döngüyü yazabiliriz.
             * Kullanımı ;
             * for(int i = 0 ; i < Koşul ; i++)
             * int i=0 ; Başlangıç değerini tanımlarız.
             * i < Koşul ; Döngünün kontrol edilecek koşulunu tanımlarız. 
             * Koşul tanımlarken karşılaştırma operatörlerini kullanırız.(=,<,>,<=,>=)
             * i++ ; Başlangıç değerini arttırır veya azaltırız. (i++,i--,i+=2(i yi çoklu arttırma),i-=2)
             */

            //ForLoop();

            #endregion

            #region While Loop
            /* While döngüsü kurarken döngümüzün tekrar sayıları genelde belli değildir. 
             * Döngüyü kurarken belirttiğimiz koşulumuz boolean türünde true yani sağlandığı sürece döngü devam eder, bu koşulumuzun değeri false olduğu takdirde döngü bitirilir. 
             * ve döngü sonrasında kodlar varsa onlar çalıştırılmaya devam eder. Teorik bilgi göz önüne alınırsa “iken” anlamına gelir. 
             * Bu kavramı “x sayısı y sayısından büyük iken aşağıdaki kodları çalıştır” şeklinde örneklendirebiliriz.
             * Kullanımı;
             * while (Şart_Bloğu)
                {

                }
             */

            //WhileLoop();

            #endregion

            #region Do-While Loop
            /*While döngüsüne benzer, ancak koşul döngü bloğunu tamamladıktan sonra değerlendirilir, bu nedenle şart sağlanmasa bile döngü en az bir kez çalışır.
             * Kullanımı;
             * do
                {

                } while (Şart Bloğu);
             */

            //DoWhileLoop();

            #endregion

            #region Foreach Loop
            /* Diziler ve koleksiyonlar gibi veri yapıları üzerinde dolaşmak için kullanılır.
             * Foreach ile döndüğümüz elemanları foreach içerisinde değiştiremeyiz.
             * Kullanımı;
             * foreach (var item in collection) //item : gezilen listedeki her bir değer - collection : listenin adı
                {

                }
             */

            ForeachLoop();

            #endregion

            #endregion

            Console.ReadLine();
        }

        private static void ForeachLoop()
        {
            string[] students = new string[] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                //student = "Ahmet"; // Foreach ile döndüğümüz elemanları foreach içerisinde değiştiremeyiz.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11); // şart sağlanmasada döngüyü 1 defa döndürecektir.
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--; // number'ı azaltmazsak döngü sonsuz döngüye girer. Burada şart a müdahale ediyoruz.

            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            //0'dan 100'e kadar olan sayıları yazdıracaktır.
            for (int i = 0; i < 100; i++) // değeri her dönüşte 1 arttırıyoruz.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //1'den 100'e kadar tek sayıları yazdıracaktır.
            for (int i = 1; i < 100; i += 2) // değeri her dönüşte 2'şer arttırıyoruz.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //0'dan 100'e kadar çift sayıları yazdıracaktır.
            for (int i = 0; i < 100; i += 2) // değeri her dönüşte 2'şer arttırıyoruz.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //100'den 0'a kadar çift sayıları yazdıracaktır.
            for (int i = 100; i >= 0; i -= 2) // değeri her dönüşte 1 arttırıyoruz.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
