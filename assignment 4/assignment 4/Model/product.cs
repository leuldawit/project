using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4.Model
{
    internal class product
    {
        static List<product> products = new List<product>();
       
            public string number { get; set; }
            public DateTime date { get; set; }
            public string inventoryNumber { get; set; }
            public string objectname { get; set; }
            public string count { get; set; }
            public string price { get; set; }

            public void save()
            {
                 products.Add(this);    
                 
               
            
             }
        public static List<product> getallproducts() 
        { 
            return products;    
        }
    }
}
