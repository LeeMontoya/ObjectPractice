using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Pants
    {
        public List<Pants> PantsList = new List<Pants>();

        
        public string Color { get; set; }
        public string Size { get; set; }

        public Pants (string color, string size)
        {
           this.Size = size;
           this.Color = color;
        }
    
    }
}
