namespace DesignPatterns.Template
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ProcessData();

        public abstract void ReadData();

        private void SaveData()
        {
            Console.WriteLine("Save data to DB");
        }
    }
}
