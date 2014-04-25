using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Shirts
    {
        public List<Shirts> ShirtList = new List<Shirts>();

        public string Size { get; set; }
        public string Color { get; set; }



        Shirts(string color, string size)
        {
            this.Size = size;
            this.Color = color;
        }
           
            
    
    }
}
