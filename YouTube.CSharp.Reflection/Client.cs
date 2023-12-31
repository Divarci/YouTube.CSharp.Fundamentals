namespace YouTube.CSharp.Reflection
{
    public class Client
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public static class ClientSeed
    {
        public static List<Client> clients = new()
        {
            new(){Id=1,CompanyName="Sun Ltd", ContactName="Michael",PhoneNumber="07856 563 452"},
            new(){Id=1,CompanyName="Moon Ltd", ContactName="Booby",PhoneNumber="07565 223 965"},
            new(){Id=1,CompanyName="Venus Ltd", ContactName="George",PhoneNumber="04568 114 458"},

        };


    }
}
