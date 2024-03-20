using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme
{
    internal class araba
    {//Sınıflar Daha Önce Yapmıştık araba adında sınıf actık
        string marka;
        string model;
        string hız;
        string motor;
        //4 Değişken verdik
        public string MARKA
        {
            get { return marka; }//markayı dondur
            set { marka = value; }//girilecek degeri al
        }
        public string MODEL
        {
            get { return model; }
            set { model = value; }
        }
        public string HIZ
        {
            get { return hız; }
            set { hız = value; }
        }
        public string MOTOR
        {
            get { return motor; }
            set { motor = value; }
        }
    }
}
