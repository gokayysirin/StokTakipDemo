namespace StokTakipDemo
{
    partial class FrmEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxProductCode = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Miktarı";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(186, 134);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(305, 27);
            this.tbxName.TabIndex = 3;
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxProductCode.Location = new System.Drawing.Point(186, 189);
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.ReadOnly = true;
            this.tbxProductCode.Size = new System.Drawing.Size(305, 27);
            this.tbxProductCode.TabIndex = 4;
            this.tbxProductCode.Text = "Ürün kodu otomatik oluşturulmaktadır";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(186, 237);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(305, 27);
            this.tbxStock.TabIndex = 5;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxStock);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.tbxProductCode);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Location = new System.Drawing.Point(106, 58);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(608, 422);
            this.gbxAdd.TabIndex = 6;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ürün Ekleme";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 48);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 601);
            this.Controls.Add(this.gbxAdd);
            this.Name = "FrmEkle";
            this.Text = "Stok Takip Sistemi";
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxName;
        private TextBox tbxProductCode;
        private TextBox tbxStock;
        private GroupBox gbxAdd;
        private Button btnAdd;
    }
}