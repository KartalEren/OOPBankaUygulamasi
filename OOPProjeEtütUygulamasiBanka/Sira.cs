using Banka.Interfaces;
using OOPProjeEtütUygulamasiBanka.Exceptions;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka
{
    public class Sira: ISira
    {
        List<Fis> siraListesi;

        public Sira(Numerator numerator)
        {
            siraListesi = numerator.MusteriFisListesi;
        }


       

        public void BireyselIslemYap(Musteri musteri)
        {
            foreach (var item in siraListesi)
            {
                if (item.Musteri.IslemTipi == IslemTipi.BireyselIslem && item.Musteri.MusteriTipi == MusteriTipi.VIPMusteri)
                {
                    siraListesi[0] = item;
                }
                else if (item.Musteri.IslemTipi == IslemTipi.BireyselIslem)
                {
                    siraListesi[0] = item;

                }
            }
        }
        public void BireyselIslemSirasiOlustur(Musteri musteri)
        {
            if (siraListesi.Count % 4 == 0)
            {
                BireyselIslemYap(musteri);
            }
        }


        public void MusteriOncelikDurumuBelirle(Musteri musteri)
        {
            if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
            {
                siraListesi[0] = musteri.MusteriFisi;
            }
            else
            {
                throw new MusteriYokException("VIP Musteri Bulunmamaktadır.");
            }
        }



        public Fis MusteriSirasiBelirle(Musteri musteri)
        {
            if (siraListesi.Count == 0)
            {
                throw new MusteriYokException();
            }
            else
            {
                MusteriOncelikDurumuBelirle(musteri);
                BireyselIslemYap(musteri);
                Fis fis = siraListesi[0];
                siraListesi.Remove(fis);
                return fis;
            }

        }


       









    }
}
