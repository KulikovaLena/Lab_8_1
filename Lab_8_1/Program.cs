using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Lena\\(4)";
            string root = "*.*";
            string[] folders = Directory.GetDirectories(path, root, SearchOption.AllDirectories);
                Console.WriteLine("folders");
                foreach (string n in folders)
                {
                    Console.WriteLine(n);
                }
                string[] files = Directory.GetFiles(path, root, SearchOption.AllDirectories);
                Console.WriteLine("files");
                foreach (string m in files)
                {
                    Console.WriteLine(m);
                }
            Console.ReadKey();

        }
    }
}
