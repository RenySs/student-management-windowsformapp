using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    
   class Ogrenci
    {
        private string ad;
        private string soyad;
        private string cinsiyet;
        private int ogrenciNo;
        private int yas;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

    }
   /* class BirinciSinif : Ogrenci
    {
        private string ders;
        public string Ders
        {
            get { return ders; }
            set { ders = value; }
        }
    }*/
}
