using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class SignUp : Form
    {
        SignUpDB signUpDB = new SignUpDB();
        public SignUp()
        {
            InitializeComponent();
        }

        private void email_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void username_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_box_TextChanged(object sender, EventArgs e)
        {
            password_text_box.UseSystemPasswordChar = true;
        }

        private void signup_window_button_Click(object sender, EventArgs e)
        {
            signUpDB.SignUp(username_text_box.Text, email_text_box.Text, password_text_box.Text);
            this.Close();
        }

    }
}
