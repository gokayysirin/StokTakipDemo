namespace StokTakipDemo
{
    partial class StokAzalt
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
            this.gbxStokArtir = new System.Windows.Forms.GroupBox();
            this.tbxUrunKodu = new System.Windows.Forms.TextBox();
            this.btnStokAzalt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCikisStok = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxStokArtir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStokArtir
            // 
            this.gbxStokArtir.Controls.Add(this.tbxUrunKodu);
            this.gbxStokArtir.Controls.Add(this.btnStokAzalt);
            this.gbxStokArtir.Controls.Add(this.label1);
            this.gbxStokArtir.Controls.Add(this.label2);
            this.gbxStokArtir.Controls.Add(this.tbxCikisStok);
            this.gbxStokArtir.Location = new System.Drawing.Point(12, 298);
            this.gbxStokArtir.Name = "gbxStokArtir";
            this.gbxStokArtir.Size = new System.Drawing.Size(787, 226);
            this.gbxStokArtir.TabIndex = 6;
            this.gbxStokArtir.TabStop = false;
            this.gbxStokArtir.Text = "Stok Çıkış Ekranı";
            // 
            // tbxUrunKodu
            // 
            this.tbxUrunKodu.Location = new System.Drawing.Point(364, 36);
            this.tbxUrunKodu.Name = "tbxUrunKodu";
            this.tbxUrunKodu.ReadOnly = true;
            this.tbxUrunKodu.Size = new System.Drawing.Size(162, 27);
            this.tbxUrunKodu.TabIndex = 3;
            // 
            // btnStokAzalt
            // 
            this.btnStokAzalt.Location = new System.Drawing.Point(364, 177);
            this.btnStokAzalt.Name = "btnStokAzalt";
            this.btnStokAzalt.Size = new System.Drawing.Size(162, 29);
            this.btnStokAzalt.TabIndex = 4;
            this.btnStokAzalt.Text = "Stok Azalt";
            this.btnStokAzalt.UseVisualStyleBackColor = true;
            this.btnStokAzalt.Click += new System.EventHandler(this.btnStokAzalt_Click);
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
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çıkarılacak Ürün Miktarı";
            // 
            // tbxCikisStok
            // 
            this.tbxCikisStok.Location = new System.Drawing.Point(364, 96);
            this.tbxCikisStok.Name = "tbxCikisStok";
            this.tbxCikisStok.Size = new System.Drawing.Size(162, 27);
            this.tbxCikisStok.TabIndex = 2;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AllowUserToAddRows = false;
            this.dgwProducts.AllowUserToDeleteRows = false;
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 29;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(787, 280);
            this.dgwProducts.TabIndex = 7;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // StokAzalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 533);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxStokArtir);
            this.Name = "StokAzalt";
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.StokAzalt_Load);
            this.gbxStokArtir.ResumeLayout(false);
            this.gbxStokArtir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxStokArtir;
        private TextBox tbxUrunKodu;
        private Button btnStokAzalt;
        private Label label1;
        private Label label2;
        private TextBox tbxCikisStok;
        private DataGridView dgwProducts;
    }
}