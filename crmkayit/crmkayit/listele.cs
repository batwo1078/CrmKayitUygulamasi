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

namespace crmkayit
{
    public partial class listele : Form
    {

        private BindingSource bindingSource;
        private DataTable dataTable;

        public listele()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'juniorDataSet.crmkayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.crmkayitTableAdapter.Fill(this.juniorDataSet.crmkayit);

            // DataGridView'e BindingSource'u bağlayın
            dataGridView1.DataSource = bindingSource;

            // BindingSource'u DataTable'a eşitleyin
            dataTable = this.juniorDataSet.crmkayit.CopyToDataTable();
            bindingSource.DataSource = dataTable;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text;

            // Filtre metni boşsa, filtrelemeyi kaldır
            if (string.IsNullOrEmpty(filterText))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                // Filtre metni boş değilse ve destekkod bir sayısal alan ise, "=" operatörü kullanarak filtrele
                if (int.TryParse(filterText, out int destekkod))
                {
                    bindingSource.Filter = $"destekkod = {destekkod}";
                }
                else
                {
                    bindingSource.Filter = $"ad LIKE '%{filterText}%' OR konu LIKE '%{filterText}%'  OR ticariunvan LIKE '%{filterText}%' OR kayittarih LIKE '%{filterText}%' OR kayitsaat LIKE '%{filterText}%'";
                }
            }
        }

       


    }
}

