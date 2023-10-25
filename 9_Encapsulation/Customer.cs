namespace _9_Encapsulation
{
    internal class Customer
    {
        //field
        //public string FirstName;

        public int Id { get; set; }


        //Property
        string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }

        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
