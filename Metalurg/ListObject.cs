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
using static System.Windows.Forms.ListViewItem;

namespace Metalurg
{
    public partial class ListObject<T> : Form
    {
        List<T> list;
        OpenForm<T> openForm;
        public ListObject()
        {
            InitializeComponent();
        }
        public ListObject(List<T> values, OpenForm<T> openForm) : this()
        {
            list = values;
            this.openForm = openForm;
            listView1.View = View.Details;
            Update();
        }

        void Update()
        {
            object[] Views = new object[typeof(T).GetProperties().Length];
            listView1.Columns.Clear();
            foreach (var prop in typeof(T).GetProperties())
            {
                listView1.Columns.Add(prop.Name);
            }


            foreach (T item in list)
            {
                ListViewItem ViewItem = new ListViewItem();
                //ViewItem.Text = item.ToString();
                ViewItem.Tag = item;
                foreach (var prop in typeof(T).GetProperties())
                {
                    ListViewSubItem subviewItem = new();
                    subviewItem.Text = prop.GetValue(item)?.ToString();
                    ViewItem.SubItems.Add(subviewItem);
                }
                listView1.Items.Add(ViewItem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            T t = default(T);
            openForm(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].Tag is T t)
                {
                    openForm(t);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
