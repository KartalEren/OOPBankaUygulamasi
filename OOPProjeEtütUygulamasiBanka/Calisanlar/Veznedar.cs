using Banka.Interfaces;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka.Calisanlar
{
    public class Veznedar : Calisan, IVeznedar
    {
        public Musteri Musterim { get; set; }   //metot içinde çağırılıpı için  bu şekil prop u da olsun ki metot içinde parametreye eşitleriz.

        public IslemTipi MusteriIslemTipi { get; set; }

        public IslemSonucu Sonuc { get; set; }

        private bool molayaCikabilir;


        public Veznedar() : base(Gorev.Veznedar)
        {

        }


        public void IslemYap(Musteri musteri)//işlem bilgisi metodu oluşturduk
        {
            this.MusteriIslemTipi = musteri.IslemTipi;
        }

        public void MusteriyiSonucHakkindaBilgilendir(Musteri musteri)//müşteri tarafında olan işlem bilgisine burada yapılan işlemleri atadık.
        {
            musteri.IslemSonucu = this.Sonuc;
        }

        public override void MolayaCik(object value)
        {
            value = null;
        }

        public override Veznedar MoladanDon()
        {
            //Veznedar veznedar= new Veznedar();
            // return veznedar;
            return this;// bu klası döndürmüş olduk newlemek yerine

        }

        public void MusteriCagirVeIsleminiYap(Musteri musteri)//parametre olarak müsteri cağıracağı için müşteri tipinde müşteri yaparız.
        {
            Musterim = musteri;
            IslemYap(musteri);//buraki sağdaki işlem nesnesini al sola prop a ata dedik.
            IslemYap(musteri);
            MusteriyiSonucHakkindaBilgilendir(musteri);
            this.Musterim = null;//artık müşterim kalmadı demektir.
            if (molayaCikabilir)
            {
                MolayaCik(this);
                MoladanDon();
            }
        }
    }
}
