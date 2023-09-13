using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface IGunSonu
    {
        int GunlukVIPMusteriSayisiniBul(Musteri musteri);
        int GunlukBireyselMusteriSayisiniBul(Musteri musteri);
        int GunlukGiseMusteriSayisiniBul(Musteri musteri);
    }
}
