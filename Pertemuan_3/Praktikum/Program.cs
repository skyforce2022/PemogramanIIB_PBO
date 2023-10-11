using System;

namespace P3_2_714220017
{
    public class Program
    {

        public static void Main()
        {
            Console.Write("PROGRAM SYAIR LAGU ANAK AYAM\n------------------------------");
            Console.Write("\nMasukkan jumlah anak ayam: ");

            int jumlah = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ANAK AYAM TURUN {0}", jumlah);

            if (jumlah < 1 || jumlah > 10)
            {
                Console.Write("Nilai tidak boleh dibawah 0 atau diatas 10");
            }
            else
            {
                for (int i = jumlah; i >= 1; i--)
                {
                    if (i - 1 == 0)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i);
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah {1}", i, i - 1);

                    }
                }
            }
        }
    }
}
