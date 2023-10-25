using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation - Kapsülleme 
            /* Encapsulation: bir nesnenin belirli özellik ve metotlarının erişiminin kısıtlanması ve saklanmasıdır.
             *  -Bu kısıtlamalar kötü amaçlı kullanım ve istenmeyen veri girişlerini engeller.
             * 
             */

            #region AccessModifiers - Erişim Belirleyiciler
            /*!Access Modifiers (Erişim Belirleyiciler) : Yazdığımız sınıf üyelerine dışarıdan erişilip/erişilmeyeceğini belirttiğimiz alan adlarıdır. 
             *!Access Modifiers'ların Default'u : (Private)'dir.
             *!Access Modifiers türleri ;
             *!!Public : Public belirleyici tipinde hiçbir kısıtlama yoktur. Heryerden erişim sağlanabilir ve değiştirilebilir.
             *!!Private : Private belirleyici sadece tanımlandığı sınıf içerisinden erişilebilir.
             *!!Internal : Internal ile tanımladığımız bir sınıf ya da değişkene aynı Public’de olduğu gibi proje içerisinde ya da Namespace (isim alanı) içerisinde erişebiliyoruz. 
                          -Internal’ın Public’ten farkı ise tanımladığı yapıya diğer projelerden ulaşım iznini vermemesidir. 
                          -Internal aynı zamanda bir sınıfın varsayılan belirleyicisidir. 
                          -Bir sınıfı class SınıfAdı ile Internal Class SınıfAdı tanımlamak arasında herhangi bir fark yoktur.
             *!!Protected : Protected ile tanımlanan alanlara sadece tanımlandığı sınıf içerisinde ya da o sınıfı miras alan (inheritance) sınıf içerisinde ulaşılabilmektedir.
             *!!Protected Internal : Aynı solution içerisinde fakat farklı bir proje ya da Namespace (isim alanı) içerisinde olan bir sınıf başka bir sınıfı miras almış (inheritance) 
                                    -ve ilgili alan Protected Internal ile tanımlanmış ise bu alana ulaşabiliriz.
             */

            #endregion

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            Console.WriteLine(customer.FirstName);
            #endregion

            Console.ReadLine();
        }
    }
}
