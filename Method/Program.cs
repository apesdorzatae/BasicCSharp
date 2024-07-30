using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Memanggil method");
             hadapKanan();
             Console.WriteLine("Dan");
             hadapKiri();    

         }
         static void hadapKanan()
         {
             Console.WriteLine("Menghadap ke kanan");
         }
         static void hadapKiri()
         {
             Console.WriteLine("Menghadap ke kiri");*/

            Console.WriteLine("Masukkan jumlah langkah :");

            Melangkah(int.Parse(Console.ReadLine()));
        }
        static void Melangkah( int jumlahLangkah)
        {
            Console.WriteLine("Telah melangkah sebanyak {0} kali",jumlahLangkah);
        }
        //#Mantap
        //#Bar-Bar dulu gak sih
    }
}
