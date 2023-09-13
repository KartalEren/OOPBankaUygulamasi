using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka
{
    public class Fis
    {
        public Musteri Musteri { get; set; }
        public int SiraNo { get; set; }


        public Fis(Musteri musteri, int tcNo)
        {
            musteri.TCNo = tcNo;
            this.Musteri = musteri;
            this.Musteri.MusteriFisi = this;

            
        }



    }
}
