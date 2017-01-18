using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_msftTutortial
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Customer("d");
            s.MyProperty.Add("s");
            s.MyOrder = new Order_msftTutortial.Order();
            s.MyProperty = new List<string>();
        }
    }
}
