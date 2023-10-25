using System;

namespace _8_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes - Sınıflar
            /*Class: Nesnelerin oluşturulmasını ve davranışlarını tanımlayan bir yapıdır.
             * Class'ın içerdiği öğeler;
             * Veri Üyeleri (Fields): Sınıf, nesnenin durumunu temsil eden veri üyelerini içerebilir. 
             *  +Örneğin, bir Araba sınıfı, aracın rengi, hızı gibi veri üyelerini içerebilir.
             *  
             * Metotlar (Methods): Sınıf, nesnenin davranışlarını tanımlayan metotları içerebilir. Metotlar, sınıfın işlevselliğini belirler. 
             *  -Araba sınıfı için bir metot, aracın hızını artırmak veya azaltmak gibi işlemleri gerçekleştirebilir.
             *  
             * Kurucu Metot (Constructor): Sınıf, nesnelerin başlatılması için kurucu metotları içerebilir. 
             *  -Kurucu metotlar, nesnenin başlangıç durumunu ayarlar.
             *  
             * Erişim Belirleyicileri (Access Modifiers): Sınıflar ve üyeleri için erişim düzenleyicileri (public, private, protected, internal vb.) belirlenebilir. 
             *  -Bu, sınıfların ve üyelerinin erişimini kontrol eder.
             *  
             * Özellikler (Properties): Sınıf, veri üyelerine erişim için özellikler kullanabilir. 
             *  -Properties, veri üyelerini okuma ve yazma işlemlerini kontrol eder.
             *  
             * Class kullanımı;
             * access_modifier class ClassName{}
             *  Ex: public class Car {}
             *  
             * Class'ların Default Access modifier'ları 'Internal' dir.
             * 
             * !!Internal : Internal ile tanımladığımız bir sınıf ya da değişkene aynı Public’de olduğu gibi proje içerisinde ya da Namespace (isim alanı) içerisinde erişebiliyoruz. 
             *  -Internal’ın Public’ten farkı ise tanımladığı yapıya diğer projelerden ulaşım iznini vermemesidir. 
             *  -Internal aynı zamanda bir sınıfın varsayılan belirleyicisidir. 
             *  -Bir sınıfı class ClassName ile Internal Class ClassName tanımlamak arasında herhangi bir fark yoktur.
             */



            CustomerManager customerManager = new CustomerManager();
            // Class çağırırken class ismi PascalCase(ilk harfleri büyük) yazılır.
            // Çağırılan sınıfın ismi atanırken camelCase(ilk harfi küçük diğerleri büyük) yazılır.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            
            //Classların kullanım yolu 1;
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            //Classların kullanım yolu 2;
            Customer customer2 = new Customer()
            {
                Id = 2, City="İstanbul", FirstName="Derin", LastName="Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);


            #endregion

            Console.ReadLine();
        }
    }




}
