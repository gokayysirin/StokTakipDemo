﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetbyName(string key)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                return context.Products.Where(p => p.UrunAdi.Contains(key)).ToList();

            }
        }
        public void Add(Product product)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

            }
        }
    }
}
