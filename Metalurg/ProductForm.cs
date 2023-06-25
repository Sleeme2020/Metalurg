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
using System.Windows.Forms.Design.Behavior;

namespace Metalurg
{
    public partial class ProductForm : Form
    {
        Product _product;
        Product Product
        {
            get { return _product; }

            set
            {
                if (value != null)
                {
                    _product = value;
                    textBox1.Text = value.Name;
                    richTextBox1.Text = value.Description;
                    UpdPrice();
                }
            }
        }
        public ProductForm()
        {
            InitializeComponent();
            UpdTypePrice();
        }

        void UpdTypePrice()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(TypePriceBehavior.GetType());
        }

        void UpdPrice()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(PriceBahavior.GetPrice(_product));
        }
        public ProductForm(Product product) : this()
        {
            Product = product;
        }

        delegate void Behevior(Product product);
        private void button1_Click(object sender, EventArgs e)
        {
            Behevior behevior;
            if (Product == null)
            {
                _product = new Product();
                behevior = ProductBehavior.Add;
            }
            else
            {
                behevior = ProductBehavior.Update;
            }
            _product.Name = textBox1.Text;
            _product.Description = richTextBox1.Text;

            behevior(_product);
            ContextData.GetProduct();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is TypePrice pr)
            {
                PriceBahavior.Add(DateTime.Now, _product, pr, (int)numericUpDown1.Value);


                UpdPrice();
            }
        }
    }
}
