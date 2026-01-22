using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfElems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input a count of elements");
            Int32.TryParse(Console.ReadLine(), out var nElems);
            var iArray = new short[nElems];
            var oRnd = new Random();
            for (int i = 0; i < nElems; i++)
            {
                var nItem = (short)oRnd.Next(1, 10);
                iArray[i] = nItem;
            }
            var nProduct = 1;
            for (int i = 0; i < nElems; i++)
            {
                nProduct *= iArray[i];
                Console.Write(iArray[i] + " ");
            }
            Console.WriteLine($"\r\nThe Product of {nElems} elements of the array is:{nProduct}");
            Console.Read();
        }
    }
}
