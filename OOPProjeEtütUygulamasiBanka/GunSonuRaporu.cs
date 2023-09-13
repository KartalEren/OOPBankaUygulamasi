using Banka.Interfaces;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka
{
    public class GunSonuRaporu : IGunSonu
    {
        
        private List<Fis> _musteriFisListesi;
        private List<Musteri> _musteriler;
        private List<GunSonuRaporu> vipGunSonuListesi;
        private List<GunSonuRaporu> bireyselIslemListesi;
        private List<GunSonuRaporu> giseIslemListesi;


        public List<GunSonuRaporu> VIPGunSonuListesi
        {
            get { return vipGunSonuListesi; }
            set { vipGunSonuListesi = value; }
        }

        public List<GunSonuRaporu> BireyselIslemListesi
        {
            get { return bireyselIslemListesi; }
            set { bireyselIslemListesi = value; }
        }

        public List<GunSonuRaporu> GiseIslemListesi
        {
            get { return giseIslemListesi; }
            set { giseIslemListesi = value; }
        }


        public GunSonuRaporu(Numerator numerator)
        {
            _musteriFisListesi = numerator.MusteriFisListesi;
            _musteriler = numerator.Musteriler;
        }



        public int GunlukVIPMusteriSayisiniBul(Musteri musteri)
        {
            int vipMusteriSayisi = 0;

            for (int i = 0; i < _musteriler.Count; i++)
            {
                if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
                {
                    vipMusteriSayisi++;
                    
                }
                 
            }
            return vipMusteriSayisi;
        }



        public int GunlukBireyselMusteriSayisiniBul(Musteri musteri)
        {
            int bireyselIslemSayisi = 0;

            for (int i = 0; i < _musteriFisListesi.Count; i++)
            {

                if (musteri.IslemTipi == IslemTipi.BireyselIslem)
                {
                    bireyselIslemSayisi++;
                }
            }
            return bireyselIslemSayisi;
        }

        public int GunlukGiseMusteriSayisiniBul(Musteri musteri)
        {
            int giseIslemSayisi = 0;

            for (int i = 0; i < _musteriFisListesi.Count; i++)
            {

                if (musteri.IslemTipi == IslemTipi.Giseİslemi)
                {
                    giseIslemSayisi++;
                }
            }
            return giseIslemSayisi;
        }


    }
}

