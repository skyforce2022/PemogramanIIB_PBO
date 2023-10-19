using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220017
{
    using System;
        public class Transportasi
        { // Parent Class
            public string type = "Garuda Indonesia"; //fields
            public string airline = "Garuda Indonesia"; //fields
            public string color = "biru"; //fields
            public string company = "Boeing"; // fields
            public string Warna
            { // properties
                get { return color; }
                set { color = value; }
            }
            public void bunyi()
            { //method (polymorphism)
                Console.WriteLine("Neeee, emmmmm");
            }

            public Transportasi()
            { // ini constructor dari class transportasi 
                type = "Garuda Indonesia";
            }

        }

        class Pesawat : Transportasi
        { //Child Class (inheritence)
            public string company = "Boeing";
            public string type = "Garuda Indonesia";
            public string airline = "Garuda Indonesia";
          public void bunyi()
            { //polymorphism
                Console.WriteLine("Neeeoooom");
            }
            public Boolean bisaTerbang = false;
        }

        class pesawat : Transportasi
        {
            public Boolean bisaTerbang = true;

        }

        class company : Transportasi
        { // Child Class
            public string perusahaan = "Boeing";
            public void suara()
            { //polymorphism
                Console.WriteLine("Neeoooom");
            }
        }

        public class Program
        {

            public static void Main()
            {
                Pesawat pesawatSaya = new Pesawat(); //Object dari class pesawat, nama object yaitu pesawatSaya
                Pesawat pesawatSiapa = new Pesawat();

                pesawatSiapa.Warna = "biru"; // ini set properties
                Console.WriteLine(pesawatSiapa.Warna); // ini get properties

                Console.WriteLine(pesawatSaya.type);

            if (pesawatSaya.bisaTerbang = true)
            {
                Console.WriteLine("itu adalah pesawat");
            }
            else
                {
                    Console.WriteLine("bukan pesawat");
                }

                Console.WriteLine(pesawatSaya.company + " " + pesawatSaya.company);
                pesawatSaya.bunyi();
            }
     }    
}
