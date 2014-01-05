using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.UnitTests
{
    public class ResultPrinterMock : IResultPrinter
    {
        private readonly List<string> printedMessages;

        public ResultPrinterMock()
        {
            this.printedMessages = new List<string>();
        }

        public void Print(string message)
        {
            this.printedMessages.Add(message);
        }

        /// <summary>
        /// Index is 1-based
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public String GetMessageWithIndex(int index)
        {
            return printedMessages[index - 1];
        }

        public List<String> AllPrintedMessages()
        {
            return this.printedMessages;
        }
    }
}
