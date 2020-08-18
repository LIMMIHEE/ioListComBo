using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioListComBo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "사과", Price = 200 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 700 });
            productBindingSource.Add(new Product() { Name = "배추", Price = 600 });
            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
