using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Test
    {
        static void Main()
        {
            BitArray64 number1 = new BitArray64(242424224);
            BitArray64 number2 = new BitArray64(2478587878);

            Console.WriteLine("Number {0} in binary is: ", number1);
            foreach (var bit in number1)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
        }
    }
}
