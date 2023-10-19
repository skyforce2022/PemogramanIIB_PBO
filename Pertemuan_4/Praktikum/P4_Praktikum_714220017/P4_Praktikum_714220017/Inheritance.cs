using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Praktikum_714220017
{
    internal class Inheritance
    {
    }
    public class Car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }

    public void Klakson2()
    {
        Console.WriteLine("Biiiiiiim");
    }
    }

    class Y6 : Car
    {
        public Y6()
        {
            Roda = 4;
        }
        public void Klakson(){
            Console.Write("Biiim..!!!");
        }
    }
}
