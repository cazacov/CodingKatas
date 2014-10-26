using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = args[1];

            var numParser = new NumberParser();
            var numbers = numParser.ParseFile(fileName);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
