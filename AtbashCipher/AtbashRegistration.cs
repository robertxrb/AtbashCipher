using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtbashCipher
{
    public partial class AtbashRegistration : Form
    {
        Database database = new Database();
        public AtbashRegistration()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textpassword.UseSystemPasswordChar = false;
                textpassword2.UseSystemPasswordChar = false;
            }
            if (checkBox.Checked == false)
            {
                textpassword.UseSystemPasswordChar = true;
                textpassword2.UseSystemPasswordChar = true;
            }
        }

        private void buttonregistrationconfirm_Click(object sender, EventArgs e)
        {
            User user = new User(textlogin.Text, textpassword.Text, textpassword2.Text);
            if (user.Correct() == true)
            {
                if (database.CheckCorrect(textlogin.Text) == false)
                {
                    database.CreateUser(textlogin.Text, textpassword.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Имя уже занято");
                }
            }
        }
    }
}
