using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaNumaratorSistemi.Sınıflar;

namespace BankaNumaratorSistemi.Interface
{
    public interface IMusteriIslemleri
    {
        public void musteriEkle(Musteri musteri);
        public void musteriIslemiYap(Musteri musteri);
        
    }
}
