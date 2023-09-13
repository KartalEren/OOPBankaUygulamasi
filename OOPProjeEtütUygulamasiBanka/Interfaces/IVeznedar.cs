using OOPProjeEtütUygulamasiBanka.Calisanlar;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    internal interface IVeznedar
    {
        void MusteriCagirVeIsleminiYap(Musteri musteri);
        void MolayaCik(object value);
        void IslemYap(Musteri musteri);
        void MusteriyiSonucHakkindaBilgilendir(Musteri musteri);
        Veznedar MoladanDon();

    }
}
