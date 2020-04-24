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

namespace CrmUI.Forms
{
    public partial class MarkForm : Form
    {
        public Mark Mark { get; set; }
        public MarkForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mark = new Mark()
            {
                Name = textBox1.Text
            };
            Close();
        }
    }
}
