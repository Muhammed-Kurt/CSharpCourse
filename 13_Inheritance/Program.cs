using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance - Kalıtım
            /*Inheritance, nesne yönelimli programlamada bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını miras aldığı bir konsepttir.
             * Süper Sınıf ve Alt Sınıf (Base Class ve Derived Class): Inheritance, bir temel sınıfın (süper sınıf veya base class) alt sınıflar (türetilmiş sınıf veya derived class) tarafından miras alınmasıyla gerçekleşir. 
             *  -Alt sınıf, temel sınıfın özelliklerini ve davranışlarını devralır.
             * 
             * "class" Anahtar Kelimesi: Inheritance işlemi başlatmak için class anahtar kelimesi kullanılır. Alt sınıf tanımlandığında, : operatörü ile süper sınıf belirtilir.
             * 
             * Override ve Virtual Anahtar Kelimeleri: Alt sınıf, temel sınıftan miras alınan metotları ve özellikleri, gerektiğinde override anahtar kelimesi kullanarak değiştirebilir. 
             *  -Temel sınıfın metotlarını değiştirmek için bu kullanılır.
             * 
             * Access Modifiers (Erişim Belirleyicileri): Inheritance işlemi sırasında, erişim belirleyicileri önemlidir. Private üyeler, alt sınıflar tarafından erişilemez. 
             *  -Diğer erişim belirleyicileri, alt sınıflar tarafından erişilebilir.
             * 
             * Constructor Mirası: Alt sınıfın kurucu metodu (constructor), varsayılan olarak temel sınıfın parametresiz kurucu metodunu çağırır. 
             *  -Ancak, alt sınıfın kurucu metodunda base anahtar kelimesi kullanarak farklı bir kurucu metot çağrılabilir.
             * 
             * !!!!Çoklu Miras: C# dilinde çoklu miras desteklenmez. Bir sınıf yalnızca bir başka sınıftan miras alabilir.!!!!
             */

            Person[] persons =
            {
                new Customer{FirstName = "Engin" },
                new Student {FirstName = "Derin" },
                new Person{FirstName = "Salih" },
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            #endregion

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
