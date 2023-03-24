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
}
