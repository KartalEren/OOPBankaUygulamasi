using OOPProjeEtütUygulamasiBanka.Interfaces;
using OOPProjeEtütUygulamasiBanka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOPProjeEtütUygulamasiBanka.MusteriKayitIslemleri
{
    public class MusteriKayitListesi: IMusteriKayitListesi
    {
        private List<GunSonuRaporu> vipIslemKaydi;
        private List<GunSonuRaporu> bireyselIslemKaydi;
        private List<GunSonuRaporu> giseIslemKaydi;




        public MusteriKayitListesi(GunSonuRaporu gunSonuRaporu)
        {
            vipIslemKaydi = gunSonuRaporu.VIPGunSonuListesi;
            bireyselIslemKaydi = gunSonuRaporu.BireyselIslemListesi;
            giseIslemKaydi = gunSonuRaporu.GiseIslemListesi;
            IslemListdenOku();
        }

        ~MusteriKayitListesi()
        {
            VIPIsleminiListeyeKaydet();
            BireyselIslemiListeyeKaydet();
            GiseIsleminiListeyeKaydet();
        }

        public void VIPIsleminiListeyeKaydet()
        {
            StreamWriter writer = new StreamWriter("VIPIslemKayıtListesi.json");
            writer.Write(JsonSerializer.Serialize(vipIslemKaydi));
            writer.Flush();
            writer.Close(); 
        }

        public void BireyselIslemiListeyeKaydet()
        {
            StreamWriter writer = new StreamWriter("BireyselIslemKayıtListesi.json");
            writer.Write(JsonSerializer.Serialize(bireyselIslemKaydi));
            writer.Flush();
            writer.Close();
        }

        public void GiseIsleminiListeyeKaydet()
        {
            StreamWriter writer = new StreamWriter("GiseIsleKayıtListesi.json");
            writer.Write(JsonSerializer.Serialize(giseIslemKaydi));
            writer.Flush();
            writer.Close();
        }




        public void IslemListdenOku()
        {
            StreamReader readerVIP = new StreamReader("VIPIslemKayıtListesi.json");
            string json1 = readerVIP.ReadToEnd();
            readerVIP.Close();
            this.vipIslemKaydi = JsonSerializer.Deserialize<List<GunSonuRaporu>>(json1);




            StreamReader readerBireysel = new StreamReader("BireyselIslemKayıtListesi.json");
            string json2 = readerBireysel.ReadToEnd();
            readerBireysel.Close();
            this.bireyselIslemKaydi = JsonSerializer.Deserialize<List<GunSonuRaporu>>(json2);




            StreamReader readerGise = new StreamReader("GiseIsleKayıtListesi.json");
            string json3 = readerGise.ReadToEnd();
            readerGise.Close();
            this.giseIslemKaydi = JsonSerializer.Deserialize<List<GunSonuRaporu>>(json3);
        }


    }
}
