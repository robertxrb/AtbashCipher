using System;
using System.IO;
using System.Windows.Forms;

namespace AtbashCipher
{
    public partial class AtbashProgram : Form
    {
        Atbash atb = new Atbash();
        public AtbashProgram()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
        }

        private void buttoncipher_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = atb.Encrypt(richTextBox.Text, comboBox.SelectedIndex);
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text Files | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                using (StreamWriter SW = new StreamWriter(saveFileDialog.FileName, false))
                {
                    SW.WriteLine(richTextBox1.Text);
                    SW.Close();
                }
            }
        }

        private void buttonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "TXT Files|*.txt";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                richTextBox.LoadFile(openFile1.FileName);
            }
        }

        private void AtbashProgram_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
