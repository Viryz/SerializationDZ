using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLib;

namespace DeserializConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();

            List<PC> list;

            using (FileStream fs = new FileStream(@"D:\listSerial.txt", FileMode.OpenOrCreate))
            {
                list = (List<PC>)bf.Deserialize(fs);
            }

            foreach (PC item in list)
            {
                Console.WriteLine("******************");
                Console.WriteLine("Mark: " + item.Mark);
                Console.WriteLine("Serial number: " + item.SerialNumber);
                Console.WriteLine("Cost: " + item.Cost);
                Console.WriteLine("Power: " + item.Power);
                Console.WriteLine("******************");
            }

            Console.ReadKey();
        }
    }
}
