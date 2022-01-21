using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Interface
{
    internal class FileInfo:IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("reading file");
        }
        public void WriteFile()
        {
            Console.WriteLine("writing file");
        }
    }
}
