using Model;
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
    public partial class Registration : Form
    {
        User User;
        public Registration()
        {
            InitializeComponent();
            User = new User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                UserBehavior.AddUser(User);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void validateForm()
        {
            if(textBox1.Text.Length==0)  throw new Exception("Не задано имя");
            if (textBox2.Text.Length == 0) throw new Exception("Не задан Логин");
            if (textBox3.Text.Length == 0) throw new Exception("Не задан Пароль");

            User.Name = textBox1.Text;
            User.Login = textBox2.Text;
            User.Password = textBox3.Text;            
        }
    }
}
