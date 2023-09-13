using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka.Exceptions
{
    internal class MusteriYokException:Exception
    {
        public MusteriYokException():base("VIP Musteri Bulunmamaktadır.")
        {
                
        }

        public MusteriYokException(string msg) : base(msg)
        {

        }
    }
}
