using OOPProjeEtütUygulamasiBanka.Musteriler;
using OOPProjeEtütUygulamasiBanka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface ISira
    {
        Fis MusteriSirasiBelirle(Musteri musteri);
        void MusteriOncelikDurumuBelirle(Musteri musteri);
        void BireyselIslemSirasiOlustur(Musteri musteri);
        void BireyselIslemYap(Musteri musteri);

    }
}
