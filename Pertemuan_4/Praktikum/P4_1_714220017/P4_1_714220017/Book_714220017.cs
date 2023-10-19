using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220017
{
    public class Book_714220017: Product_714220017
    {
        protected string pageCount;
            public Book_714220017(string type, string title, string pagecount) : base(type, title)
        {
            this.PageCount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return PageCount;
            }
            set
            { 
                PageCount = value;
            }
        }
    }
}
