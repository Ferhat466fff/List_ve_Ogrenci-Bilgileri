using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Listele1_Click(object sender, EventArgs e)
        {   //Manuel olarak listboxa değer ekleme

            List<string> karakterler = new List<string>();//karakter adında liste oluşturduk
            karakterler.Add("Ferhat");
            karakterler.Add("şafi");
            karakterler.Add("kadir");
            karakterler.Add("burak");
            karakterler.Add("ufuk");
            karakterler.Add("levent");
            foreach(string k in karakterler)
            {
                listBox1.Items.Add(k);//listbox1 ekle
            }

        }
       
        private void btn_Listele2_Click_1(object sender, EventArgs e)
        {   //üsttekiyle aynı

            List<int> sayilar = new List<int>();
            sayilar.Add(70);
            sayilar.Add(15);
            sayilar.Add(7);
            sayilar.Add(5);
            sayilar.Add(4);
            sayilar.Add(1);
            foreach (int m in sayilar)
            {
                listBox2.Items.Add(m);
            }
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {   //Listbox2 sayilar ile Bizim gireceğimiz(textbox1) sayıyı kontol etme işlemi


            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            List<int> sayilar = new List<int>();//sayılar adında list olusturduk
            sayilar.Add(70);
            sayilar.Add(15);
            sayilar.Add(7);
            sayilar.Add(5);
            sayilar.Add(4);
            sayilar.Add(1);

            if (sayilar.Contains(sayi))//sayilar.contains(kontrol etme işlemi)
            {
                MessageBox.Show(sayi +" sayısı var ");
            }
            else
            {
                MessageBox.Show(sayi + "Sayısı yok ");
            }
        }

        private void btn_Listele3_Click(object sender, EventArgs e)
        {   
            //Sınıf Oluşturarak oradaki veriyi alma(kisiler sınıfı)


            List<kisiler> name = new List<kisiler>();//kişiler sınıfımızın ismi name adında nesne türettik

            name.Add(new kisiler()
            {
                isim = "Miraç",
                SOYADI="Akyüzlü",
                MESLEKI="Öğretmen"//verileri girdik
               
            });
            foreach(kisiler k in name)//kişiler sınıfı içerisinden name(yukarda yaptık) verileri al
            {
                listBox3.Items.Add(k.isim + " " + k.SOYADI + " " + k.MESLEKI);//ve listbox ekle
            }


            //Sınıf Oluşturarak oradaki veriyi alma(araba sınıfı)

            List<araba> detay = new List<araba>();

            detay.Add(new araba()
            {
                MARKA = "volkswagen",
                MODEL = "Sedan",
                HIZ = "220",
                MOTOR = "1,6",//verileri girdik

            }) ; 
            foreach (araba m in detay)//araba sınıfı içerisinden detay(yukarda yaptık) verileri al
            {
                listBox3.Items.Add(m.MARKA + " " + m.MODEL + " " + m.HIZ+" "+m.MOTOR);//ve listbox ekle
            }
        }
    }
}
