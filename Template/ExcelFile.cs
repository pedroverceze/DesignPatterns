namespace DesignPatterns.Template
{
    public class ExcelFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reads data from excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from excel file");
        }
    }
}
