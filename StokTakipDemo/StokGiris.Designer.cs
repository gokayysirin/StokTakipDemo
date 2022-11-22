namespace StokTakipDemo
{
    partial class StokGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEklenecekStok = new System.Windows.Forms.TextBox();
            this.tbxUrunKodu = new System.Windows.Forms.TextBox();
            this.btnStokArtir = new System.Windows.Forms.Button();
            this.gbxStokArtir = new System.Windows.Forms.GroupBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxStokArtir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eklenecek Ürün Miktarı";
            // 
            // tbxEklenecekStok
            // 
            this.tbxEklenecekStok.Location = new System.Drawing.Point(357, 96);
            this.tbxEklenecekStok.Name = "tbxEklenecekStok";
            this.tbxEklenecekStok.Size = new System.Drawing.Size(162, 27);
            this.tbxEklenecekStok.TabIndex = 2;
            // 
            // tbxUrunKodu
            // 
            this.tbxUrunKodu.Location = new System.Drawing.Point(357, 36);
            this.tbxUrunKodu.Name = "tbxUrunKodu";
            this.tbxUrunKodu.ReadOnly = true;
            this.tbxUrunKodu.Size = new System.Drawing.Size(162, 27);
            this.tbxUrunKodu.TabIndex = 3;
            // 
            // btnStokArtir
            // 
            this.btnStokArtir.Location = new System.Drawing.Point(357, 177);
            this.btnStokArtir.Name = "btnStokArtir";
            this.btnStokArtir.Size = new System.Drawing.Size(162, 29);
            this.btnStokArtir.TabIndex = 4;
            this.btnStokArtir.Text = "Stok Arttır";
            this.btnStokArtir.UseVisualStyleBackColor = true;
            this.btnStokArtir.Click += new System.EventHandler(this.btnStokArtir_Click);
            // 
            // gbxStokArtir
            // 
            this.gbxStokArtir.Controls.Add(this.tbxUrunKodu);
            this.gbxStokArtir.Controls.Add(this.btnStokArtir);
            this.gbxStokArtir.Controls.Add(this.label1);
            this.gbxStokArtir.Controls.Add(this.label2);
            this.gbxStokArtir.Controls.Add(this.tbxEklenecekStok);
            this.gbxStokArtir.Location = new System.Drawing.Point(2, 298);
            this.gbxStokArtir.Name = "gbxStokArtir";
            this.gbxStokArtir.Size = new System.Drawing.Size(787, 226);
            this.gbxStokArtir.TabIndex = 5;
            this.gbxStokArtir.TabStop = false;
            this.gbxStokArtir.Text = "Stok Ekleme Ekranı";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AllowUserToAddRows = false;
            this.dgwProducts.AllowUserToDeleteRows = false;
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(2, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 29;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(787, 280);
            this.dgwProducts.TabIndex = 6;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // StokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 536);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxStokArtir);
            this.Name = "StokGiris";
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.StokGiris_Load);
            this.gbxStokArtir.ResumeLayout(false);
            this.gbxStokArtir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxEklenecekStok;
        private TextBox tbxUrunKodu;
        private Button btnStokArtir;
        private GroupBox gbxStokArtir;
        private DataGridView dgwProducts;
    }
}