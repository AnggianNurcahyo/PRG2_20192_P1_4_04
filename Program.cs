using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG2_20192_P1_4_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar\n");
            Console.Write("Menu Pilihan : ");
            char input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {
                case 'a':
                    Console.Write("Masukan alas : ");
                    int alas = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan tinggi : ");
                    int tinggi = Convert.ToInt16(Console.ReadLine());
                    int Luas = alas * tinggi / 2;
                    Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, Luas);
                    break;
                case 'b':
                    Console.Write("Masukan alas : ");
                    int a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan tinggi : ");
                    int t = Convert.ToInt16(Console.ReadLine());
                    int Miring = Convert.ToInt16(Math.Sqrt((a * a) + (t * t)));
                    Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", a, t,Miring);
                    break;
                case 'c':
                    Console.Write("Masukan alas : ");
                    int x = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan tinggi : ");
                    int y = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Sisi Miring : ");
                    int z = Convert.ToInt16(Math.Sqrt((x * x) + (y * y)));
                    Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", x, y, z);
                    //Masukkan nilai miring
                    int Keliling = x + y + z;
                    Console.WriteLine("Keliling segitiga dengan alas {0} dan tinggi {1} serta sisi miring {2} adalah {3} satuan",x,y,z,Keliling);
                    break;
                case 'd':
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
