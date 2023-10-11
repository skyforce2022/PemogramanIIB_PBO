using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220017
{
    public class Program
    {

        public static void Main()
        {
            Console.Write("MENU PERSEGI PANJANG");
            Console.Write("\n1. Hitung Luas");
            Console.Write("\n2. Hitung Keliling");

            Console.Write("\nMenu Pilihan: ");

            int menu = Convert.ToInt16(Console.ReadLine());

            Boolean ulang = true;

            while (ulang)
            {
                if (menu == 1)
                {
                    Console.Write("MENGHITUNG LUAS PERSEGI PANJANG");
                    Console.Write("\nMasukkan Panjang: ");
                    int panjang = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nMasukkan Lebar: ");
                    int lebar = Convert.ToInt16(Console.ReadLine());

                    int luas = panjang * lebar;
                    Console.WriteLine("Luas persegi panjang {0}", luas);
                    Console.Write("Ingin mengulang kembali (Y/T)?");

                    String pengulangan = Console.ReadLine();
                    if (pengulangan == "T")
                    {
                        ulang = false;
                    }
                }
                else if (menu == 2)
                {
                    Console.Write("MENGHITUNG KELILING PERSEGI PANJANG");
                    Console.Write("\nMasukkan Panjang: ");
                    int panjang = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\nMasukkan Lebar: ");
                    int lebar = Convert.ToInt16(Console.ReadLine());

                    int keliling = 2 * (panjang + lebar);
                    Console.WriteLine("Keliling persegi panjang {0}", keliling);

                    Console.Write("Ingin mengulang kembali (Y/T)?");
                    String pengulangan =
                        Console.ReadLine();

                    if (pengulangan == "T")
                    {
                        ulang = false;
                    }
                }
                else
                {
                    Console.Write("Menu Tidak Tersedia");
                    ulang = false;
                }
            }
        }
    }
}
