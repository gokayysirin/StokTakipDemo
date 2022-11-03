﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipDemo
{
    public partial class FrmDuzenle : Form
    {
        public FrmDuzenle()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void FrmDuzenle_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                UrunAdi= tbxName.Text,
                UrunKodu= Convert.ToInt32(tbxCode.Text),
                UrunSayisi =Convert.ToInt32(tbxStock.Text)
            });
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxStock.Text= dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxCode.Text= dgwProducts.CurrentRow.Cells[0].Value.ToString();
        }
    }
}