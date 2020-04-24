using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Models;
using CrmUI.Forms;

namespace CrmUI
{
    public partial class Form1 : Form
    {
        private Context dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new Context();
           // Language.Save();

            foreach (var language in Language.Load())
            {
                var item = new ToolStripMenuItem()
                {
                    Name = language.Name,
                    Text = language.Name,
                    
                };

                item.Click += Item_Click;
                languageMenuItem.DropDownItems.Add(item);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            var language = Language.Load();

            bindingSource1.DataSource = language.Find(p => p.Name == menuItem.Name );

        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(dbContext.Products);
            catalogProduct.Show();

        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(dbContext.Sellers);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(dbContext.Customers);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(dbContext.Checks);
            catalogCheck.Show();
        }

        private void CustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Customers.Add(form.Customer);
                dbContext.SaveChanges();
            }
        }

        private void ProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(dbContext);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Products.Add(form.Product);
                dbContext.SaveChanges();
            }
        }

        private void SellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Sellers.Add(form.Seller);
                dbContext.SaveChanges();
            }
        }

        private void markToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new MarkForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Marks.Add(form.Mark);
                dbContext.SaveChanges();
            }
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogMark = new Catalog<Mark>(dbContext.Marks);
            catalogMark.Show();
        }
    }
}
