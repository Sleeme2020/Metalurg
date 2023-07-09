using Metalurg.Model;
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
    public partial class ReceptForm : Form
    {
        public ReceptForm()
        {
            InitializeComponent();
            int id = 0;
            //receptProductBindingSource.DataSource= ContextData.Context.Products.Local.ToBindingList();
            receptProductBindingSource.Filter = $"Recept.Id = {id}";
        }
    }
}
