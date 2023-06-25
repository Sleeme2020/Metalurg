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
    public partial class TypePriceForm : Form
    {
        public TypePriceForm()
        {
            InitializeComponent();
        }

        private void TypePriceForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(TypePriceBehavior.GetType());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypePriceBehavior.Add(textBox1.Text);
            TypePriceForm_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is TypePrice a)
            {
                a.Name = textBox1.Text;
                TypePriceBehavior.update(a);
                TypePriceForm_Load(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is TypePrice a)
            {
                TypePriceBehavior.Remove(a.Id);
                TypePriceForm_Load(null, null);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem is TypePrice a)
            {
                textBox1.Text = a.Name;
            }
        }
    }
}
