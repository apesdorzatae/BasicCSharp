using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan angka pertama");
            int angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua");
            int angka2 = int.Parse(Console.ReadLine());
            int hasilkali = angka1 * angka2;
            int hasilbagi = angka1 / angka2;
            int hasiltambah = angka1 + angka2;
            int hasilkurang = angka1 - angka2;

            Console.WriteLine("\nPenjumlahan:{0}\nPengurangan:{1}\nPerkalian:{2}\nPembagian:{3}", hasiltambah, hasilkurang, hasilkali, hasilbagi);
        }
    }
}

