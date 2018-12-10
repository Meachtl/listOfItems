

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create controller
            Controller controller = new Controller();

            // add values to controller
            controller.Add(new File1("1", "Dichte", "0,5"));
            controller.Add(new File1("1", "Dichte", "0,2"));
            controller.Add(new File1("1", "Info", "Hallo"));
            controller.Add(new File1("2", "Info", "Zeas"));
            controller.Add(new File1("2", "Dichte", "0,4"));
            controller.Add(new File1("2", "Dichte", "0,8"));
            controller.Add(new File1("1", "Dichte", "0,3"));
            controller.Add(new File1("2", "Dichte", "0,8"));
            controller.Add(new File1("3", "Dichte", "0,8"));
            controller.Add(new File1("2", "Dichte", "0,8"));
            controller.Add(new File1("4", "Dichte", "0,8"));
            controller.Add(new File1("2", "Dichte", "0,8"));
            controller.Add(new File1("5", "Info", "Hallo"));
            controller.Add(new File1("5", "Info", "Max"));
            controller.Add(new File1("5", "Info", "Wie"));
            controller.Add(new File1("5", "Info", "Geht"));
            controller.Add(new File1("5", "Info", "Es"));
            controller.Add(new File1("5", "Info", "Dir?"));
            controller.Add(new File1("4", "Dichte", "0,65"));

            // create dictionary
            controller.CreateDictionary();

            // create sum
            controller.GetSum();

            // print result
            controller.PrintResult();
        }
    }
}
