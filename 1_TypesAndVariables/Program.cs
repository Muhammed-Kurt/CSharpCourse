using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1) Types And Variables - Tipler ve Değişkenler
            /* Tam Sayı Veri Tipleri
             * byte < short < int < long
             * byte: Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.
             * short: Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.
             * int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.
             * long : Uzunluğu 8 byte’tır, -1020 ile 1020 arasında değer alır.
             * 
             * Ondalık Sayı Veri Tipleri
             * float < decimal
             * float : Uzunluğu 4 byte’tır, 1.5 x 10-45 ile 3.4 x 1038 arasında değer alır. Değer atarken sonuna f harfi getirilir.
             * double : Uzunluğu 8 byte’tır, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır.
             * decimal : Uzunluğu 12 byte’tır, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır.
             * 
             * Diğer Primitive Veri Tipleri
             * char : Uzunluğu 2 byte’tır, Tek karakter türünde değerler alır. Tanımlamaları oluştururken yalnızca bir rakam, işaret veya harf kullanabiliriz. 
             *  -Yapılan tanımlamalar diğer veri tiplerinin aksine tek tırnak arasında yapılmalıdır.
             * Kullanımı : char char_degisken_ismi = 'degisken_degeri'; 
             * boolean : True – false değer tutan tiptir. Mantıksal veri tipidir.
             * Kullanımı : bool bool_degisken_ismi = degisken_degeri; // Default değeri false'dur. Sadece true ve false değerlerini döndürür.
             *
             * Var Keyword : Değişken tanımı yaparken tür(int,float,decimal,char vb.) belirtmeksizin tanım yapmamızı sağlamaktadır.
             *  +Var tipine değişken tanımlarsanız eğer değişkenin tipini siz değil derleyici tanımlayacaktır.
             * Kullanımı; var var_degisken_ismi = degisken_degeri;
             * Örnek: var number = 25; // derleyici burda var değişkenine bizim yerimize int veri tipini tanımlayacaktır.
             * Örnek: var character = 'B'; // derleyici burda var değişkenine bizim yerimize char veri tipini tanımlayacaktır.
             * 
             * Enum : Belirlediğiniz sayıları belirlediğiniz string ifadelerle kullanabilmemizi sağlar.
             *  +Örneğin : Pazartesi için 1, salı için 2 gibi...
             * Kullanımı:
             * enum enum_degisken_ismi {deger1,deger2,deger3} // Burada değerlere otomatik numaralandırma yapılır.
             * enum enum_degisken_ismi {deger1=10,deger2=20,deger3=30} // Şeklinde kendimizde numaralandırabiliriz.
             */
            //Console.WriteLine("Hello World");
            int number1 = 2147483647;
            byte number4 = 255;
            short number3 = 32767;
            long number2 = 9223372036854775807;
            bool condition = false;
            char character = 'A';
            float number5 = 64.231321f;
            double number6 = 10.4;
            decimal number7 = 10M;
            //var Keyword
            var number8 = 10; // Sonradan farklı bir tipte değer atamaya çalışırsak hata verecektir.

            //number8 = 'A';
            //number = "A";

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine((int)Days.Friday); // Bize enum Days -> Friday elamanının karşılık geldiği sayıyı verecektir.
            Console.ReadLine();
            #endregion


        }
    }
    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday = 30, Thursday, Friday, Saturday, Sunday
    }
}
