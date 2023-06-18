using Metalurg.Model;
namespace Metalurg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var us = UserBehavior.LoginUser(textBox1.Text, textBox2.Text);

                Main main = new Main();
                main.Show();
                ContextData.User = us;
                Hide();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}