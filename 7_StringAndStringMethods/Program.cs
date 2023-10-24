using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_StringAndStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String And Strings Methods - String ve String Metotlar
            /* C# String sınıfı, bir dizi metin (char) karakteri bir araya toplayarak metinsel değerleri tutan veri tipidir.
             * Stringler birer char arraydir. yani charların dizi şeklinde birleşmesinden meydana gelirler.
             * String sınıfının sahip olduğu metotlar immutable olarak adlandırılır. Yani bu sınıf içerisinde yer alan metotlar değiştirilemez.
             * String değişkenlerine atanan değerler (metinler) çift tırnak  (" ")  içine yazılırlar. 
             */

            //Intro();

            #region String Methods - String Metotlar
            string sentence = "My name is Engin Demiroğ";

            #region Lenght Method
            //Stringin uzunluğunu (kaç karakter içerdiğini) döndürür.
            //Sayısal değer döndürür.
            Heading("Lenght");
            var result = sentence.Length; // 24 Karakterden oluşuyor sentence değişkeni.
            Console.WriteLine(result);
            #endregion

            #region Clone Method
            //String değerimizin birebir kopyasını oluşturur.
            Heading("Clone");
            var result2 = sentence.Clone(); // result2 ye My name is Engin Demiroğ' u klonladık
            sentence = "My name is Derin Demiroğ";
            Console.WriteLine(result2);
            #endregion

            #region EndsWith Method
            //Belirtilen parametre içerisinde bulunan değer ile karşılaştırma yaptığımız metinin bitip bitmediğini kontrol eder.
            //Sonuç Bool değeriyle döndürülür.
            Heading("EndsWith");
            bool result3 = sentence.EndsWith("ğ");// sentence ğ ile bitiyorsa true bitmiyorsa false döndürür.
            Console.WriteLine(result3);
            #endregion

            #region StartsWith Method
            //Belirtilen parametre içerisinde bulunan değer ile karşılaştırma yaptığımız metinin başlayıp başlamadığını kontrol eder.
            //Sonuç Bool değeriyle döndürülür.
            Heading("StartsWith");
            bool result4 = sentence.StartsWith("My name"); // sentence My name ile başlıyorsa true başlamıyorsa false döndürür.
            Console.WriteLine(result4);
            #endregion

            #region IndexOf Method
            //String değişkeni içerisinde Method ile birlikte verilen kelimeyi arar.
            //Bulduğu ilk kelimeyi arar gerisine devam etmez.
            //Kelimeyi bulursa başladığı index numarasını yazdırır. Bulamazsa -1 değerini döndürür.
            Heading("IndexOf");
            var result5 = sentence.IndexOf("namee"); 
            Console.WriteLine(result5);
            var result6 = sentence.IndexOf(" "); // Boşluğu aratıyoruz. Bulduğu ilk boşluğu sayar ve aramaya devam etmez.
            Console.WriteLine(result6);
            #endregion

            #region LastIndexOf Method
            //String değişkeni içerisinde Method ile birlikte verilen kelimeyi cümlenin sonundan aramaya başlar.
            //Bulduğu ilk kelimeyi arar gerisine devam etmez.
            //Kelimeyi bulursa başladığı index numarasını yazdırır. Bulamazsa -1 değerini döndürür.
            Heading("LastIndexOf");
            var result7 = sentence.LastIndexOf(" "); // Boşluğu sondan aramaya başlayacak.
            Console.WriteLine(result7);
            #endregion

            #region Insert Method
            //String değişkeni içinde ki metnin belirli bir alanına ekleme yapar.
            //Insert(eklenecek alanın indexi , eklenecek değer );
            Heading("Insert");
            var result8 = sentence.Insert(0,"Hello, "); // 0.indexten itibaren Hello,  yaz.
            Console.WriteLine(result8);
            #endregion

            #region Substring Method
            //String değişkeni içerisinde ki metinden belirli bir bölümü alıp daha sonra kullanmak üzere saklar.
            //Verdiğiniz başlangıç indeksinden yine verdiğiniz karakter sayısı kadarlık alanı alıp geri döndürür.
            //Substring(indexten itibaren, verilen değer kadar karakter al);
            Heading("Substring");
            var result9 = sentence.Substring(3,4); // 3.indexten itibaren 4 karakter al.
            Console.WriteLine(result9);
            #endregion

            #region ToLower Method
            //String değişkeni içinde ki metnin tüm karakterlerini küçük harf yapar.
            Heading("ToLower");
            var result10 = sentence.ToLower();
            Console.WriteLine(result10);
            #endregion

            #region ToUpper Method
            //String değişkeni içinde ki metnin tüm karakterlerini büyük harf yapar.
            Heading("ToUpper");
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);
            #endregion

            #region Replace Method
            //String içerisinde ki bir metni veya karakteri bir başka metin veya karakter ile değiştirmek için kullanılır.
            //Replace(Buraya girilen karakteri , buradaki karakter ile değiştir);
            Heading("Replace");
            var result13 = sentence.Replace(" ","-"); // Burada " " boşlukları, "-" işaretiyle değiştirdik.
            Console.WriteLine(result13);
            #endregion

            #region Remove Method
            /*String değişkeni içinde ki metin üzerinde silme işlemleri uygular. İki adet kullanımı vardır.
             *1) Başlangıç indexini belirtirsiniz. Başlangıç indexinden sonra ki kısmı siler.
             *Remove(indexten itibaren silecek);
             *2) Başlangıç indeksi ve ne kadar devam edeceğini belirtirsiniz. Başlangıç indexinden belirttiğiniz değer kadar olan karakteri siler.
             *Remove(hangi indexten başlayıp , hangi indexe kadar silecek);
             */
            Heading("Remove");
            var result14 = sentence.Remove(2); //2.indexten sonra hepsini
            Console.WriteLine(result14);
            var result15 = sentence.Remove(2,5); //2.indexten sonra 5 karakter silecek
            Console.WriteLine(result15);
            #endregion

            #endregion

            #endregion

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0] + "\n"); // city nin 0.elemanı A'dır.

            foreach (var item in city) //city dizisini foreach ile dönüyoruz.
            {
                Console.WriteLine(item);//city deki charları tek tek gösterecektir.
            }

            string city2 = "İstanbul";
            string result = city + city2; // stringlerde + işareti stringleri yanyana getirir.
            Console.WriteLine(result + "\n");

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //String.Format: Bir nesnenin, değişkenin veya ifadenin değerini başka bir dizeye eklemeniz gerekiyorsa kullanılır.
        }

        static void Heading(string head)
        {
            Console.WriteLine("-------" + head + " Method-------");
        }
    }
}
