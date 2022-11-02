namespace StokTakipDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStockUp = new System.Windows.Forms.Button();
            this.btnStockDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(57, 58);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(128, 124);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Ürünleri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 124);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 124);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ürün Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(57, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 124);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Ürün Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnStockUp
            // 
            this.btnStockUp.Location = new System.Drawing.Point(239, 235);
            this.btnStockUp.Name = "btnStockUp";
            this.btnStockUp.Size = new System.Drawing.Size(128, 124);
            this.btnStockUp.TabIndex = 4;
            this.btnStockUp.Text = "Stok Arttır";
            this.btnStockUp.UseVisualStyleBackColor = true;
            // 
            // btnStockDown
            // 
            this.btnStockDown.Location = new System.Drawing.Point(412, 235);
            this.btnStockDown.Name = "btnStockDown";
            this.btnStockDown.Size = new System.Drawing.Size(128, 124);
            this.btnStockDown.TabIndex = 5;
            this.btnStockDown.Text = "Stok Azalt";
            this.btnStockDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.btnStockDown);
            this.Controls.Add(this.btnStockUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListele;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnStockUp;
        private Button btnStockDown;
    }
}