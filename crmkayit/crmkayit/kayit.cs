using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crmkayit
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void kayit_Load(object sender, EventArgs e)
        {
           
        }

        void verikaydet()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=YAZILIMDESTEK;Initial Catalog=Junior;Integrated Security=True"))
                {
                    baglanti.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = baglanti;
                        cmd.CommandText = "INSERT INTO crmkayit( ticariunvan, ad, soyad, il, ilce, telno, email, durum, destektipi, kayittarih, kayitsaat, sorumlu, konu, aciklama, desteksuresi) VALUES( @ticariunvan, @ad, @soyad, @il, @ilce, @telno, @email, @durum, @destektipi, @kayittarih, @kayitsaat, @sorumlu, @konu, @aciklama, @desteksuresi)";
                        cmd.Parameters.AddWithValue("@ticariunvan", txttcr.Text);
                        cmd.Parameters.AddWithValue("@ad", txtad.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                        cmd.Parameters.AddWithValue("@il", txtil.Text);
                        cmd.Parameters.AddWithValue("@ilce", txtilce.Text);
                        cmd.Parameters.AddWithValue("@telno", txttel.Text);
                        cmd.Parameters.AddWithValue("@email", txtmail.Text);
                        cmd.Parameters.AddWithValue("@durum", txtdurum.Text);
                        cmd.Parameters.AddWithValue("@destektipi", txttip.Text);
                        cmd.Parameters.AddWithValue("@kayittarih", txttarih.Text);
                        cmd.Parameters.AddWithValue("@kayitsaat", txtsaat.Text);
                        cmd.Parameters.AddWithValue("@sorumlu", txtsorumlu.Text);
                        cmd.Parameters.AddWithValue("@konu", txtkonu.Text);
                        cmd.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
                        cmd.Parameters.AddWithValue("@desteksuresi", txtsure.Text);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Veriler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Veri kaydı sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            verikaydet();
        }

        private void txttarih_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txttarih_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
