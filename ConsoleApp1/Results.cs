
namespace ConsoleApp1
{
    internal class Results
    {
        public Results(string id, double sum)
        {
            ID = id;
            Sum = sum;
        }
        public string ID { get; set; }

        public double Sum { get; set; }
    }
}