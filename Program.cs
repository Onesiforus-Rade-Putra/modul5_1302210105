// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
namespace modul5_1302210105
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputan1 = 13;
            double inputan2 = 02;
            double inputan3 = 05;
            Penjumlahan<double> penjumlahan = new Penjumlahan<double>();
            penjumlahan.tigaangka(inputan1, inputan2, inputan3);
            SimpelDataBase<int> data = new SimpelDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(05);
            data.PrintAllData();
        }
    }
    class Penjumlahan<T>
    {
        public T data;

        public void tigaangka (T inputan1, T inputan2, T inputan3)
        {
            this.data = data;
            data = (dynamic)inputan1 + (dynamic)inputan2 + (dynamic)inputan3;
            Console.WriteLine("hasil [penjumlahan 3 angka : " + data);
            
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
