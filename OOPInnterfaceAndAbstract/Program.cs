using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnterfaceAndAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMusteri SP1 = new SuperMusteri();
            SP1.testAbstract();
            //temelSinif T1 = new temelSinif();
            Musteri M1 = new Musteri();
            M1.test();
            M1.testAbstract();
        }
    }
}
