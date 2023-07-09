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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            linkLabel1.Text = ContextData.User.Name;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TypePriceForm typePriceForm = new TypePriceForm();
            typePriceForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ListObject<Production> listObject = 
            //    new ListObject<Production>(ProductionBehavior.GetProduction().ToList(), ProductionBehavior.OpenForm);
            ListObject<User> listObject =
                new ListObject<User>(UserBehavior.GetUsers().ToList(), UserBehavior.OpenForm);
            listObject.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListObject<Recept> listObject = new ListObject<Recept>();
            listObject.ShowDialog();
        }
    }
}
