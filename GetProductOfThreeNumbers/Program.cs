using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProductOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] iInput = {1,10,2,5,6,10};

            ProductCalculator pc = new ProductCalculator();
            Console.WriteLine(pc.CalculateProduct(iInput));
        }

    }
}
