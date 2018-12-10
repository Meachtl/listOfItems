using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Controller
    {
        List<File1> _sourceList;
        Dictionary<string, string> _items;
        List<Results> _restults;

        public Controller()
        {
            _sourceList = new List<File1>();
            _items = new Dictionary<string, string>();
            _restults = new List<Results>();

        }
        /// <summary>
        /// add new 
        /// </summary>
        /// <param name="file"></param>
        public void Add(File1 file)
        {
            _sourceList.Add(file);
        }
        /// <summary>
        /// create dictionary
        /// </summary>
        public void CreateDictionary()
        {            

            foreach (File1 row in _sourceList)
            {
                if (!_items.ContainsKey(row.ID))
                {
                    if (row.Attribute == "Dichte")
                    {
                        _items.Add(row.ID, row.Attribute);
                    }                    
                }
            }
        }
        /// <summary>
        /// get sum of each item
        /// </summary>
        public void GetSum()
        {
            double sum;
            foreach (KeyValuePair<string, string> entry in _items)
            {
                sum = 0.0;
                foreach (File1 file in _sourceList)
                {
                    if (file.ID == entry.Key && file.Attribute == entry.Value)
                    {
                        sum += double.Parse(file.Value);
                    }
                }
                _restults.Add(new Results(entry.Key, sum));
            }
        }
        /// <summary>
        /// print results
        /// </summary>
        public void PrintResult()
        {
            string id = "ID";
            string sum = "Summe";
            Console.WriteLine();
            Console.WriteLine("----Results----");
            Console.WriteLine($"{id,3}{sum,12}");
            foreach (Results results in _restults)
            {
                Console.WriteLine($"{results.ID,3}{results.Sum,12}");
            }
            Console.WriteLine();
        }
    }
}
