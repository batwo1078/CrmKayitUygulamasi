namespace crmkayit
{
    partial class listele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.destekkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticariunvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destektipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitsaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorumluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desteksuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crmkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juniorDataSet = new crmkayit.JuniorDataSet();
            this.crmkayitTableAdapter = new crmkayit.JuniorDataSetTableAdapters.crmkayitTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmkayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juniorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destekkodDataGridViewTextBoxColumn,
            this.ticariunvanDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.destektipiDataGridViewTextBoxColumn,
            this.kayittarihDataGridViewTextBoxColumn,
            this.kayitsaatDataGridViewTextBoxColumn,
            this.sorumluDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.desteksuresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crmkayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // destekkodDataGridViewTextBoxColumn
            // 
            this.destekkodDataGridViewTextBoxColumn.DataPropertyName = "destekkod";
            this.destekkodDataGridViewTextBoxColumn.HeaderText = "destekkod";
            this.destekkodDataGridViewTextBoxColumn.Name = "destekkodDataGridViewTextBoxColumn";
            this.destekkodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticariunvanDataGridViewTextBoxColumn
            // 
            this.ticariunvanDataGridViewTextBoxColumn.DataPropertyName = "ticariunvan";
            this.ticariunvanDataGridViewTextBoxColumn.HeaderText = "ticariunvan";
            this.ticariunvanDataGridViewTextBoxColumn.Name = "ticariunvanDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            // 
            // ilceDataGridViewTextBoxColumn
            // 
            this.ilceDataGridViewTextBoxColumn.DataPropertyName = "ilce";
            this.ilceDataGridViewTextBoxColumn.HeaderText = "ilce";
            this.ilceDataGridViewTextBoxColumn.Name = "ilceDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "telno";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // destektipiDataGridViewTextBoxColumn
            // 
            this.destektipiDataGridViewTextBoxColumn.DataPropertyName = "destektipi";
            this.destektipiDataGridViewTextBoxColumn.HeaderText = "destektipi";
            this.destektipiDataGridViewTextBoxColumn.Name = "destektipiDataGridViewTextBoxColumn";
            // 
            // kayittarihDataGridViewTextBoxColumn
            // 
            this.kayittarihDataGridViewTextBoxColumn.DataPropertyName = "kayittarih";
            this.kayittarihDataGridViewTextBoxColumn.HeaderText = "kayittarih";
            this.kayittarihDataGridViewTextBoxColumn.Name = "kayittarihDataGridViewTextBoxColumn";
            // 
            // kayitsaatDataGridViewTextBoxColumn
            // 
            this.kayitsaatDataGridViewTextBoxColumn.DataPropertyName = "kayitsaat";
            this.kayitsaatDataGridViewTextBoxColumn.HeaderText = "kayitsaat";
            this.kayitsaatDataGridViewTextBoxColumn.Name = "kayitsaatDataGridViewTextBoxColumn";
            // 
            // sorumluDataGridViewTextBoxColumn
            // 
            this.sorumluDataGridViewTextBoxColumn.DataPropertyName = "sorumlu";
            this.sorumluDataGridViewTextBoxColumn.HeaderText = "sorumlu";
            this.sorumluDataGridViewTextBoxColumn.Name = "sorumluDataGridViewTextBoxColumn";
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "konu";
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // desteksuresiDataGridViewTextBoxColumn
            // 
            this.desteksuresiDataGridViewTextBoxColumn.DataPropertyName = "desteksuresi";
            this.desteksuresiDataGridViewTextBoxColumn.HeaderText = "desteksuresi";
            this.desteksuresiDataGridViewTextBoxColumn.Name = "desteksuresiDataGridViewTextBoxColumn";
            // 
            // crmkayitBindingSource
            // 
            this.crmkayitBindingSource.DataMember = "crmkayit";
            this.crmkayitBindingSource.DataSource = this.juniorDataSet;
            // 
            // juniorDataSet
            // 
            this.juniorDataSet.DataSetName = "JuniorDataSet";
            this.juniorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crmkayitTableAdapter
            // 
            this.crmkayitTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrele (destek kodu / ad / konu / ticari alan)";
            // 
            // listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "listele";
            this.Text = "listele";
            this.Load += new System.EventHandler(this.listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmkayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juniorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JuniorDataSet juniorDataSet;
        private System.Windows.Forms.BindingSource crmkayitBindingSource;
        private JuniorDataSetTableAdapters.crmkayitTableAdapter crmkayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn destekkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticariunvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destektipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitsaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorumluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desteksuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}