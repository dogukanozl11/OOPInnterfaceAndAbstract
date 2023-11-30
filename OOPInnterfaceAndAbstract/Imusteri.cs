using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnterfaceAndAbstract
{
    public interface Imusteri
    {
        //public ımusteri()
        //{
        // İnterFace içerisinde ctor kulanılmaz..
        //}


        //field
        int Id { get; set; }
        string isim {  get; set; }
        string soyisim { get; set; }
        //metot

        int yeniKayit(string isim,string soyisim);
        int kayıtDüzenle(int id,string isim,string soyisim);
        int kayıtSil(int id);
        //delegate
        //vb..
    }
}
