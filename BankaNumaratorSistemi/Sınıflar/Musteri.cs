using BankaNumaratorSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaNumaratorSistemi.Sınıflar
{
    public class Musteri
    {
        public string MusteriTcNo
        {
            get { return MusteriTcNo; }
            set
            {
                if (MusteriTcNo.Length < 0 || MusteriTcNo.Length < 15)
                {
                    Console.WriteLine("Geçersiz TC No girdiniz.");
                }
                MusteriTcNo = value;
            }
        }

        public static int SiraDeger = 100;

        public int SiraNo { get; set; }

        public MusteriTip MusteriTip { get; set; }
    }
}
