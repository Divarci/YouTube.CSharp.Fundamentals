namespace YouTube.CSharp.Reflection
{
    public class CustomFileAttribute : Attribute
    {
        public string Header { get; set; }
        public string Format { get; set; }
        public string Currency { get; set; }
    }
}
