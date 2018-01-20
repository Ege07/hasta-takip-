using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Hasta_Takip
    {
        public string Adi;
        public int Ucret;
        public int DogumYili;
        public string Cinsiyet;

        public int yas;
        public int indirimliÜcret;

        public void YasHesapla()
        {
            yas = DateTime.Now.Year - DogumYili;
        }
        public void İndirimliUcretHesapla()
        {
            if (yas > 65)
            {
                indirimliÜcret = 0;

            }
            else if (Cinsiyet == "Kadın")
            {
                indirimliÜcret = Ucret * 80 / 100;
            }
            else if (yas < 15)
            {
                indirimliÜcret = Ucret * 50 / 100;
            }
            else
            {
                indirimliÜcret = Ucret;
            }
        }



    }
}
