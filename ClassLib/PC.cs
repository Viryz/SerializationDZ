using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        private string mark;
        private int serialNumber;
        private float cost;
        private float power;

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public int SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public float Power
        {
            get { return power; }
            set { power = value; }
        }

        public PC()
        {

        }
        public PC(string mark, int serialNumber, float cost, float power)
        {
            this.mark = mark;
            this.serialNumber = serialNumber;
            this.cost = cost;
            this.power = power;
        }

        public void On()
        {
            Console.WriteLine("PC is on");
        }
        public void Off()
        {
            Console.WriteLine("PC is off");
        }
        public void Reboot()
        {
            Console.WriteLine("Rebooting...");
            Thread.Sleep(2000);
            Console.WriteLine("Done.");
        }

    }
}
