using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Posilca : ICloneable
    {
        string fioOt;
        string fioPo;
        string address;
        int index;
        int weight;

        public Posilca(string fioOt, string fioPo, string address, int index, int weight)
        {
            this.FioOt = fioOt;
            this.FioPo = fioPo;
            this.Address = address;
            this.Index = index;
            this.Weight = weight;
        }

        public string FioOt { get => fioOt; set => fioOt = value; }
        public string FioPo { get => fioPo; set => fioPo = value; }
        public string Address { get => address; set => address = value; }
        public int Index { get => index; set => index = value; }
        public int Weight { get => weight; set => weight = value; }

        public object Clone()
        {
            return new Posilca(fioOt, fioPo, address, index, weight);
        }

        public static Posilca operator +(Posilca first, Posilca two)
        {
            Posilca sum = (Posilca)first.Clone();
            sum.Weight += two.Weight;
            return sum;
        }

        public static bool operator >(Posilca first, Posilca two)
        {
            if(first.Weight > two.Weight)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Posilca first, Posilca two)
        {
            if (first.Weight < two.Weight)
            {
                return true;
            }
            return false;
        }
    }
}
