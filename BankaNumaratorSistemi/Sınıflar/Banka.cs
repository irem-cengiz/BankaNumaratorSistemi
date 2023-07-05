using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaNumaratorSistemi.Enum;
using BankaNumaratorSistemi.Interface;

namespace BankaNumaratorSistemi.Sınıflar
{
    public class Banka : IMusteriIslemleri, INumarator
    {
        public List<VipMusteri> VipMusteriler = new List<VipMusteri>();
        public List<Musteri> Musteriler;

        private int vipMusteriSayisi = 0;
        private int musteriSayisi = 0;


        public Banka()
        {

        }

        public void musteriEkle(Musteri musteri)
        {
            if ((musteri.MusteriTip) == (MusteriTip.VIP))
            {
                VipMusteriler.Add((VipMusteri)musteri);
                vipMusteriSayisi++;
            }

            else if (musteri.MusteriTip == MusteriTip.Musteri)
            {
                Musteriler.Add(musteri);
                musteriSayisi++;
            }

        }

        public void NumaraVer(Musteri musteri)
        {

        }


        public void musteriIslemiYap(Musteri musteri)
        {
            if (musteri.MusteriTip == MusteriTip.VIP)
            {
                VipMusteriler.Add((VipMusteri)musteri);
                vipMusteriSayisi++;
            }
            else if (musteri.MusteriTip == MusteriTip.Musteri)
            {
                Musteriler.Add(musteri);
                musteriSayisi++;
            }
        }

    }
}