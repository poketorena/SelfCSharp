using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Publisher { get; set; }
        public DateTime Published { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Publisher}) {Price}円 {Published:d}刊行";
        }
    }
}
