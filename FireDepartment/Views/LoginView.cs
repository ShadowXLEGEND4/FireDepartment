using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireDepartment.Controllers;

namespace FireDepartment.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var message = LoginController.ShowMessage(button1.Text, button2.Text);
            if (message != null)
            {
                MessageBox.Show(message);
            }
            else
            {
                LoginView lv = new LoginView();
                this.Hide();
                gv.Show();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterView register = new RegisterView();
            register.Show();
            register.Text = "Register";
        }
    }
}
