// See https://aka.ms/new-console-template for more information
namespace modul5_1302210105
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpelDataBase<int> data = new SimpelDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(05);
            data.PrintAllData();
        }
    }

    class SimpelDataBase<T>
    {
        private List<T> storadData;
        private List<DateTime> inputdate; 

        public void SimpleDataBase()
        {
            this.storadData = new List<T>();
        }
        public void AddNewData(T data)
        {
            this.storadData.Add(data);
            inputdate.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < storadData.Count; i++)
            {
                Console.WriteLine("data " + (i + 1) + "berisi : " + Convert.ToString(storadData.ElementAt(i) + ", yang disimpan pada waktu UTC: " + inputdate.ElementAt(i)));
            }
        }
    }
}
