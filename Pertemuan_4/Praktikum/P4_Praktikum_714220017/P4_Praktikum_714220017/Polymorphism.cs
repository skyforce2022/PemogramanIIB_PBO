using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Praktikum_714220017
{
    internal class Polymorphism
    {
    }

    class Bentuk
    {
        public virtual void Gambar()
        {
            Console.Write("Ini adalah Base Class Bentuk");
        }
    }

    class lingkaran : Bentuk
        {
            public override void Gambar()
            {
                //menggambar Lingkaran....
                Console.WriteLine("menggambar Lingkaran....");
            }
        }

        class persegi : Bentuk
        {
            public override void Gambar()
            {
                //Menggambar Persegi....
                Console.WriteLine("Menggambar Persegi....");
            }

        }
   
}
