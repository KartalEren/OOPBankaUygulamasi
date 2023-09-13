using OOPProjeEtütUygulamasiBanka.Musteriler;
using OOPProjeEtütUygulamasiBanka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface INumarator
    {
        void FisNumarasiBelirle(Musteri musteri, Fis fis);
        Fis FisVer(Musteri musteri, int tcNo);

    }
}
