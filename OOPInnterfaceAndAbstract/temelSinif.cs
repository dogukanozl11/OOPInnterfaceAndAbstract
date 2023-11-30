using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnterfaceAndAbstract
{
    public  abstract class temelSinif
    {
        public DateTime kayitTarihi { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public temelSinif()
        {
            kayitTarihi = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("Temel Sınıf => test");
        }
        public abstract void testAbstract();//metot imzası
        //{
        //}
    }
}
