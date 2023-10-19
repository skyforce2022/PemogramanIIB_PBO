using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Praktikum_714220017
{
    public class Program
    {
        public void maju(string a, int b)
        {
            Console.WriteLine("tes");
        }
 
        static void Main(string[] args)
        {
            Mobil suatuMobil = new Mobil();
            Mobil MobilSaya = new Mobil() 
            { 
                nama = "Tesla", 
                kecepatan = 15000, 
                bensin = 30000, 
                posisi = 0 
            };
            MobilSaya.maju();
            Console.WriteLine(suatuMobil.nama);
            Console.WriteLine(suatuMobil.bensin);

            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);


            Mobil MobilAnda = new Mobil("Tesla", 15000, 30000);
            Console.WriteLine(MobilAnda.nama);
            Console.WriteLine(MobilAnda.bensin);

            Property p = new Property();
            p.Materi = "Bahasa Pemograman C#";
            Console.WriteLine(p.Materi);

            Person o = new Person();
            o.Nilai = 70;
            Console.WriteLine(o.Nilai);

            Y6 no = new Y6();
            Console.WriteLine(no.Roda);
            no.Klakson();

            Y6 m = new Y6();
            m.Klakson();

            Bentuk u = new lingkaran();
            u.Gambar();

            Bentuk s = new persegi();
            s.Gambar();

        }

    }
}
