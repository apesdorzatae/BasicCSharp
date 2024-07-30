using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Selamat datang di kelas 10 GAME");
             string nama = "Mr Uyun";
             Console.WriteLine("Halo " + nama + ", ini percobaanku membuat variable tipe string di C#");
             Console.WriteLine("Sekarang masukkan nama di bawah ini");
             string input = Console.ReadLine();
             Console.WriteLine("Selamat datang kembali " + input + "!"); */

            string nama,asal,umur;
            Console.WriteLine("Masukan Nama: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan Asal: ");
            asal = Console.ReadLine();
            Console.WriteLine("Masukan Umur: ");
            umur = Console.ReadLine();
            Console.WriteLine("\nNama: {0}\nAsal: {1}\nUmur: {2}", nama,asal,umur);

            //adding this

        }
    }
}
