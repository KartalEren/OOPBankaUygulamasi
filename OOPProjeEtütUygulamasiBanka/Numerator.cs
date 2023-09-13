using Banka.Interfaces;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka
{
    public class Numerator: INumarator
    {

        private List<Fis> musteriFisListesi;

        private List<Musteri> musteriler;

        public List<Fis> MusteriFisListesi
        {
            get { return musteriFisListesi; }
            set { musteriFisListesi = value; }
        }

        public List<Musteri> Musteriler
        {
            get { return Musteriler; }
            set { Musteriler = value; }
        }

        public Numerator()
        {
            musteriler = new List<Musteri>();
            musteriFisListesi = new List<Fis>();
        }


        public void FisNumarasiBelirle(Musteri musteri, Fis fis)
        {
            if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
            {
                fis.SiraNo = (musteriler.Count + 1) + 500;
            }
            else
            {
                fis.SiraNo = (musteriler.Count + 1);
            }
            musteriler.Add(musteri);
        }


        public Fis FisVer(Musteri musteri, int tcNo)
        {
            Fis fis = new Fis(musteri, tcNo);
            FisNumarasiBelirle(musteri, fis);
            MusteriFisListesi.Add(fis);

            return fis;
        }

























    }
}
