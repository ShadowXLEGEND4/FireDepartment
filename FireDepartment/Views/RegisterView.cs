using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireDepartment.Views
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Firemans fireman = new Firemans();
            if (button1.Text == string.Empty)
            {
                MessageBox.Show("Please fill in your name!");
            }
            else if (button4.Text != button3.Text || button4.Text == string.Empty || button3.Text == string.Empty)
            {
                MessageBox.Show("Password don't match!");
            }
            else
            {
                fireman.Name = button1.Text;
                fireman.Password = button4.Text;
                RegisterController.AddFireman(fireman);
                MessageBox.Show("User has been registered!");
                LoginView login = new LoginView();
                this.Hide();
                login.Show();
            }
        }
    }
}
