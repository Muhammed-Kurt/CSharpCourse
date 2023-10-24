using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditionals - Şart Blokları
            /* Şart blokları, programlamada belli bir şarta göre uygulamanın akışını değiştirecek bloklardır. Koşulların kontrolünde kullanılan komutlardır. 
             * Koşulların doğru olup olmamasına göre yani şartın sağlanıp sağlanmamasına göre işlem akışı yönlendirilir.
             * 2 tür şart bloğu vardır bunlar;
             * If-Else ve Switch-Case
             */

            /*Notlar
             *CTRL + K + CTRL + D Tuşlarına basarak kodların düzenini sağlar
             */

            #region 2) If Bloklarıyla Çalışmak
            /* If-Else şart bloklarında karşılaştırma ve mantıksal operatörler kullanılır 
             * (karşılaştırma operatörleri; eşittir(==), büyük veya eşittir(>=), küçük veya eşittir(<=), küçüktür(<), büyüktür(>), eşitdeğildir(!=) )
             * (mantıksal operatörler; 
             * &&(ve) ; &&(ve) operatörü iki değerin ikisi de doğru ise doğru, en az birisi yanlış ise yanlış değerini döndürür.
             * ||(veya) ; ||(veya) operatörü iki değerden birisi doğru ise doğru, ikisi de yanlış ise yanlış değerini döndürür ayrıca önceliği en az olan mantıksal operatördür.
             * !(değil) ; !(değil) operatörü aritmetik operatörlerden (++)arttırma ve (--)eksiltme operatörleri ile eşit önceliklidir. )
             * Kullanımı;
             * if(şart)
             * {
             *   Şarta uyuyorsa yapılacak işlemler.
             * {
             * else
             * {
             *   Hiçbir şarta uymazsa yapılacak işlemler.
             * }
             */
            var number = 20;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }


            if (number >= 0 && number <= 100) // &&(VE) = iki şart birden doğru ise true döndürür.
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0) // ||(Veya) = iki şarttan birisi doğru olduğu sürece true döndürür. 
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            #region Single Line If Bloklarıyla Çalışmak
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            #endregion

            #region İç İçe If Bloklarıyla Çalışmak
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
                else
                {

                }
            }
            #endregion
            #endregion

            #region Switch-Case Bloğuyla Çalışmak
            /* switch-case ifadesi If-Else ifadesi ile aynı işlemi yapmaktadır.
             * Not : If-Else komutu ile yapılan işlemlerin hepsi switch-case komutu ile yapılamamaktadır.
             * switch :  switch ifadesine koşul için gerekli olan değişken girilir.
             *case : Case ifadesi durumları kontrol etmek için kullanılır ve karşılaşılacak durumlar girilir
             *break : Break komutu döngüyü kırmak için yani döngüden çıkmak için kullanılır.
             *default : Default ifadesi durumlardan herhangi biri yok ise yapılacak işlemler
             */
            switch (number)
            {
                case 10: // number = 10 ise yapılacak işlemler
                    Console.WriteLine("Number is 10");
                    break; // İşlem yapıldıysa bitir.
                case 20: // number = 20 ise yapılacak işlemler
                    Console.WriteLine("Number is 20");
                    break;

                default: // number 10 ve 20 değilse yapılacak işlemler
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
