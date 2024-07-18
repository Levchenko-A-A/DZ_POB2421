using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28_4
{
    internal class IOFile
    {
        public string[] ReadFile(string path)
        {
            string[] textFile;
            textFile = File.ReadAllLines(path);
            return textFile;
        }
    }
}
