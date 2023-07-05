using BankaNumaratorSistemi.Enum;
using BankaNumaratorSistemi.Sýnýflar;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaUygulamasi
{
    public partial class Form1 : Form
    {
        Banka banka = new Banka();
        Musteri musteri = new Musteri();

        public Form1()
        {
            InitializeComponent();
            cmbTurler.DataSource = Enum.GetValues(typeof(MusteriTip));
            dgvMusteriBilgi.Columns.Add("Column1", "Müþteri Tipi");
            dgvMusteriBilgi.Columns.Add("Column2", "Sira No");

            banka.Musteriler = new List<Musteri>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MusteriTip secilenMusteri = (MusteriTip)cmbTurler.SelectedItem;

            if (secilenMusteri == MusteriTip.VIP)
            {
                VipMusteri vipMusteri = new VipMusteri();
                vipMusteri.MusteriTip = secilenMusteri;
                vipMusteri.SiraNo = VipMusteri.SiraDegeri++;
                banka.Musteriler.Add(vipMusteri);

                dgvMusteriBilgi.Rows.Add(secilenMusteri.ToString(), vipMusteri.SiraNo);
            }

            else if (secilenMusteri == MusteriTip.Musteri)
            {
                Musteri musteri = new Musteri();
                musteri.MusteriTip = secilenMusteri;
                musteri.SiraNo = Musteri.SiraDeger++;
                banka.Musteriler.Add(musteri);
                dgvMusteriBilgi.Rows.Add(secilenMusteri.ToString(), musteri.SiraNo);
            }
            else

                dgvMusteriBilgi.Rows.Add(secilenMusteri.ToString(), "");
        }

        private void btnSiraÝleGetir_Click(object sender, EventArgs e)
        {
            List<Musteri> siraliMusteriler = banka.Musteriler.OrderBy(m => m.SiraNo).ToList();

            //List<VipMusteri> siraliMusteriler2 = banka.VipMusteriler.OrderBy(m => m.SiraNo).ToList();

            if (siraliMusteriler.Count > 0)
            {
                bool musteriVarmi=false;
                Musteri siradakiMusteri = null;
                bool vipMusteriVarMi = false;

                foreach (var m in siraliMusteriler)
                {
                  musteriVarmi = false;
                    if (m is VipMusteri)
                    {
                        musteriVarmi = true;
                        vipMusteriVarMi = true;
                        banka.VipMusteriler.Add((VipMusteri)m);
                         
                        MessageBox.Show("Sýra " + m.MusteriTip.ToString() + " " + m.SiraNo.ToString() + " nolu müþteride.");
                        banka.Musteriler.Remove(m);

                    }        
                }

                foreach (var b in siraliMusteriler)
                {
                    if (b is Musteri)
                    {
                        musteriVarmi = true;
                        vipMusteriVarMi = false;
                        banka.Musteriler.Add(b);
                        MessageBox.Show("Sýra " + b.MusteriTip.ToString() + " " + b.SiraNo.ToString() + " nolu müþteride.");
                        banka.Musteriler.Remove(b);    
                    }                    
                  
                }

                if (banka.Musteriler.Count == 0)
                {
                    MessageBox.Show("Müþteri kalmamýþtýr.");
                }
            }
  
        }
    }
}
    


        

    














