using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Praktikum_714220017
{
    internal class Field_Property
    {
    }

    public class Property
    {
        private string materi;

        public string Materi
        {
            get { return materi; }
            set { materi = value; }
        }
    }
    public class Person
    {
        private int nilai = 0;
        public int Nilai
        {
            get { return Nilai; }
            set
            {
                if (value > 50)
                    nilai = value;
            }
        }
    }
}



