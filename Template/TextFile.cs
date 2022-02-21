using System;

namespace DesignPatterns.Template
{
    public class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reads data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }
    }
}
