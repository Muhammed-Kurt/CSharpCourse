using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods - Metotlar
            /* 1-Metotlar belirli işlemleri yerine getiren kod bloklarıdır ve sadece class elemanlarının içerisinde tanımlanabilirler.
             * 2-Aynı kodların tekrar tekrar kullanılması gereken durumlarda büyük kolaylık sağlamaktadır. 
             *  -Yani bir işlem birden fazla yerde kullanılıyorsa bunu metot olarak yazıp daha kolay ve kod karmaşası olmadan kullanabiliriz.
             * 3-Oluşturulan metot, ismiyle çağırılarak içerisinde bulunan kod bloklarının çalıştırılması sağlanır.
             * 4-Metot Kullanımı(Metodun İmzası): <Erişim Biçimi> <Geri Dönüş Tipi> Metot_İsmi(Parametre(ler)) {Metodun Gövdesi}
             * 5-Metotların Erişim belirtecinin Default değeri Private'dir.
             * 6-Static Metotlar; *new* anahtar kelimesine ihtiyaç duymazlar bu sayede metodumuzun ismini yazarak çalıştırabiliriz.
             * 7-Metotların isimlendirmesi CamelCase yani kelimelerin baş harfleri büyük yazılır.
             * 8-Metodumuzda geri dönüş değeri mevcutsa geriye *return* anahtar kelimesiyle döndürmemiz gerekir aksi halde hata verecektir.
             * 9-Metodumuz geriye değer döndürmeyecekse erişim belirteçlerinden sonra *void* anahtar kelimesini kullanmalıyız.
                -Bu metotlarda return anahtar kelimesini kullanmamız yasaktır. Kullanırsak hata verecektir.
             * 10-Metodumuz parametreli ise aldığı parametre tipi ve sayısınca parametre gönderilmelidir.
             *  -parametre gönderilmediği takdirde hata verecektir.
             *  -Örnekle; int Sum(int x,int y) metodumuz iki parametre almaktadır. Bu parametrelere int değer, x ve y olmak üzere 2 ayrı değer girilmesi gerekir.
             *   -Sum(2,5); gibi değerler girilmeli Sum("m","j") ya da Sum(5) gibi değerler atarsak hata verecektir.
             * 11-Metodun içinde tanımladığımız yazdığımız değişkenler metot içinde kalır ve metot dışında çalışmaz.
             * Metotlar 2'ye ayrılırlar;
             * Geriye değer döndürmeyen ve Geriye değer döndüren metotlar
             * -Geriye Değer Döndürmeyen Metotlarda 2'ye ayrılırlar;
             *  +Geriye Değer Döndürmeyen ve Parametre Almayan Metotlar
             *  +Geriye Değer Döndürmeyen ve Parametre Alan Metotlar
             * 
             * -Geriye Değer Döndüren Metotlarda 2'ye ayrılırlar;
             *  +Geriye Değer Döndüren ve Parametre Almayan Metotlar
             *  +Geriye Değer Döndüren ve Parametre Almayan Metotlar
             * 
             */

            /* Notlar
             * Değer Tipleri referans tip olarak metoda geçmek için ref ve out keyword'leri kullanılır.
             * ref Keyword'ünde değişkenin bir değeri olması gerekiyor.
             * out Keyword'ünde değişkenin bir değeri olmasada işlem yapılır.
             * 
             * Params Keyword'ü metodumuza istediğimiz sayıda değer göndermemize olanak sağlıyor.
             *  -Parametre sayısı belli olmayan metotlar için params keyword'ü kullanılabilir.
             * Kullanımı:
             * int Sum(params int[] numbers) 
             * {
             *   return;
             * }
            */

            Add();
            Add();
            Add();
            Add();

            var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);

            Console.WriteLine(Multiply(4, 3));
            Console.WriteLine(Multiply2(4, 3, 5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            #endregion
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //Default değerler her zaman metodun en sonunda olması gerekiyor.
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Methods Overload = Metotların aşırı yüklenmesi
        //---------------------------------------------
        static int Multiply(int number1, int number2)//--> Metodun imzası
        {
            return number1 * number2;
        }

        static int Multiply2(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //---------------------------------------------

        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }

        
        static int Add4(int number, params int[] numbers)
        {
            //Params Keyword'ü parametrelerde son parametre olmak zorunda.
            return numbers.Sum();
        }
    }
}
