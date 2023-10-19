using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220017
{
    public class Product_714220017
    {
        private string myType;
        private string myTitle;

        public Product_714220017()
        {

        }

        public Product_714220017(string Type, string title)
        {
            this.myType = Type;
            this.myTitle = title;
        }

        public string MyType
        {            
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }
    }
}
