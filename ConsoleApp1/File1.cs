
namespace ConsoleApp1
{
    class File1
    {
        public string ID { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }

        public File1(string id,  string attribute, string value)
        {
            ID = id;
            Attribute = attribute;
            Value = value;
        }
    }
}
