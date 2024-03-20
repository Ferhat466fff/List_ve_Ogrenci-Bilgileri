using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme
{
    internal class kisiler
    {
        //Sınıflar Daha Önce Yapmıştık kisiler adında sınıf actık

        string ad;
            string soyad;
            string meslek;
        //3 Değişken verdik
        public string isim
        {
            get { return ad; }//ad döndür
            set { ad = value; }//girilecek degeri al
        }

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string MESLEKI
        {
            get { return meslek; }
            set { meslek = value; }
        }

    }
}
