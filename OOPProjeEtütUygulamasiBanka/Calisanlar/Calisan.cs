using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka.Calisanlar
{
    public abstract class Calisan
    {
        public Gorev CalisanGorev { get; set; }

        public Calisan(Gorev gorev)
        {
                CalisanGorev = gorev;   
        }
        public abstract void MolayaCik(object value);
        public abstract Veznedar MoladanDon();
    }
}
