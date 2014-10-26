using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OcrKata
{
    public class NumberParser
    {
        public IEnumerable<Int32> ParseFile(string fileName)
        {
            var content = File.ReadAllLines(fileName);

            var lines = this.SplitByEmptyStrings(content);
            foreach (var VARIABLE in COLLECTION)
            {
                
            }

        }

        private List<List<string>> SplitByEmptyStrings(IEnumerable<string> content)
        {
            var result = new List<List<string>>();
            
            var inputLines = content.ToList();
            inputLines.Add(String.Empty);

            var lineBuffer = new List<string>();
            foreach (var line in inputLines)
            {
                if (String.IsNullOrWhiteSpace(line) && lineBuffer.Any())
                {
                    result.Add(lineBuffer);
                    lineBuffer = new List<string>();
                }
                else
                {
                    lineBuffer.Add(line);
                }
            }
            if (lineBuffer.Any())
            {
                result.Add(lineBuffer);
            }
            return result;
        }
    }
}