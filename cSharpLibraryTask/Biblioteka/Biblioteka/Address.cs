namespace Biblioteka
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public static Address GetCentrineBiblioteka()
        {
            return new Address()
            {
                City = "Kaunas",
                Country = "Lietuva",
                Street = "Laisves aleja",
                PostCode = 5664
            };
        }
    }
}