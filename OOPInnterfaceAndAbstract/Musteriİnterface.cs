﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnterfaceAndAbstract
{
    public class Musteriİnterface : Imusteri
    {
        int _id;
        string _isim, _soyisim;
         
        public int Id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; }  set { _soyisim = value; }  }

        public int kayıtDüzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("Kayıt Dzüenlendi....");
            return 1;
        }

        public int kayıtSil(int id)
        {
            Console.WriteLine("Kayıt Silindi ....");
            return 1; 
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayıt Eklendi..");
            return 1;
        }
    }
}
