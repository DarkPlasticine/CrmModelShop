using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Models;

namespace CrmUI.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public Mark Mark { get; set; }
        public ProductForm(Context context)
        {
            InitializeComponent();
            var t = context.Marks.Select(s => s).OrderBy(o => o.Name).ToList();
            comboBox1.DataSource = t;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = textBox1.Text,
                Count = (int) numericUpDown1.Value,
                Price = numericUpDown2.Value,
                MarkId = ((Mark) comboBox1.SelectedItem).Id,
                Description = textBox2.Text
            };
            Close();
        }
    }
}
