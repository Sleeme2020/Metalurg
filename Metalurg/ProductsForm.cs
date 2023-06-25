using Metalurg.Model;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metalurg
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            ContextData.DelegateEventProduct += UpdateProductList;
        }

        void UpdateProductList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(ProductBehavior.GetProduct());
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product p)
            {
                ProductForm productForm = new ProductForm(p);
                productForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product p)
            {
                ProductBehavior.Remove(p.Id);
                ContextData.GetProduct();
            }
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContextData.DelegateEventProduct -= UpdateProductList;
        }
    }
}
