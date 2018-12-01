using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLib;

namespace LabSerializationConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> list = new List<PC>
            {
                new PC("mark1", 1, 2.5f, 3.7f),
                new PC("mark2", 2, 2.45f, 3.73f),
                new PC("mark3", 3, 0.45f, 3.72f),
                new PC("mark4", 4, 2.45f, 3.7f),
                new PC("mark5", 5, 2.4f, 3.773f)
            };

            string dirName = @"D:\";
            string[] files = Directory.GetFiles(dirName);
            foreach (string item in files)
            {
                if (item == dirName + "listSerial.txt")
                {
                    Console.WriteLine("File: listSerial.txt already exist.");
                    break;
                }
            }

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"D:\listSerial.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, list);
            }

            Console.WriteLine("Object serialize is done.");

            Console.ReadKey();
        }
    }
}
