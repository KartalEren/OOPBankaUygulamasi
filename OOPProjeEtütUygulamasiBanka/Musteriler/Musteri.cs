using Banka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka.Musteriler
{
    public abstract class Musteri: IMusteri
    {
        public int TCNo { get; set; }
        public MusteriTipi MusteriTipi { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public Fis MusteriFisi { get; set; }
        public IslemSonucu IslemSonucu { get; set; }
        public Musteri(MusteriTipi musteriTipi)
        {
            MusteriTipi = musteriTipi;
        }
        public void FişAl(Fis fis)
        {
            this.MusteriFisi = fis;
        }
    }
}
