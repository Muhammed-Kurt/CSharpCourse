using System;

namespace _11_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface - Arayüz
            /* Interface: diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, 
             *  -kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
             *  
             * Soyut bir şablondur: Interface, soyut bir sınıf gibi düşünülebilir. 
             *  -Ancak, bir Interface'in içinde uygulanması gereken metotlar veya özellikler tanımlanır, ancak bunların içerikleri (kodları) belirtilmez.
             * Metotlar ve özellikler içerir: Interface, çeşitli sınıfların uygulayabileceği metotları ve özellikleri tanımlar. 
             *  -Bu, bir sınıfın bir Interface'i uyguladığında, bu metotların ve özelliklerin sınıf içinde tanımlanması gerektiği anlamına gelir.
             * Birden fazla Interface uygulanabilir: C# sınıfları birden fazla Interface'i aynı anda uygulayabilir, bu da çoklu miras (multiple inheritance) sağlar. 
             *  -Sınıf, bu Interfacelerin tüm metotlarını ve özelliklerini uygulamak zorundadır.
             * Kod tekrarını önler: Interface, kod tekrarını önlemeye yardımcı olur. Aynı metotları veya özellikleri birçok sınıf için yeniden yazmak yerine, bu sınıfların aynı Interface'i uygulaması sağlanır.
             * 
             * Interface'ler, özellikle farklı sınıflar arasında benzer davranışların paylaşılmasını gerektiren durumlarda kullanışlıdır. 
             * Interface'ler new'leyerek çağırılamazlar.
             * Interfaceler isim ataması yapılırken başına "I" harfi getirilir ve PascalCase olarak isimlendirilir.
             * Kullanımı;
             * interface IInterfaceName {}
             */

            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals =
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            #endregion

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
            customerManager.Delete(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Science"
            };

            manager.Add(customer);
            manager.Add(student);
        }
    }

    //Soyut nesne
    //Soyut nesneler tek başlarına hiçbir anlam ifade etmezler.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    //Somut nesne
    //IPerson içerisindeki tanımlanmış herşeyi implement edilen nesneler içerisinde de görebiliriz.
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
