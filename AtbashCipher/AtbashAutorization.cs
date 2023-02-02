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
    public partial class AtbashAutorization : Form
    {
        Database database = new Database();
        public AtbashAutorization()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            AtbashRegistration AtbashReg = new AtbashRegistration();
            AtbashReg.ShowDialog();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            if (checkBox.Checked == false)
            {
                textpassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            User user = new User(textlogin.Text, textpassword.Text);
            if (user.Correct() == true)
            {
                if (database.CheckUser(textlogin.Text, textpassword.Text))
                {
                    this.Hide();
                    AtbashProgram AtbashProg = new AtbashProgram();
                    AtbashProg.Closed += (s, args) => this.Close();
                    AtbashProg.Show();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных.");
                }
            }
        }
    }
}
