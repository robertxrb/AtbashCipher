namespace AtbashCipher
{
    partial class AtbashProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttoncipher = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(12, 37);
            this.richTextBox.MaxLength = 1000;
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(542, 75);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст для шифрования";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.BurlyWood;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBox.Location = new System.Drawing.Point(433, 7);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // buttoncipher
            // 
            this.buttoncipher.BackColor = System.Drawing.Color.Linen;
            this.buttoncipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncipher.Location = new System.Drawing.Point(12, 118);
            this.buttoncipher.Name = "buttoncipher";
            this.buttoncipher.Size = new System.Drawing.Size(542, 33);
            this.buttoncipher.TabIndex = 3;
            this.buttoncipher.Text = "Зашифровать | Расшифровать текст";
            this.buttoncipher.UseVisualStyleBackColor = false;
            this.buttoncipher.Click += new System.EventHandler(this.buttoncipher_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.Linen;
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsave.Location = new System.Drawing.Point(12, 238);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(542, 33);
            this.buttonsave.TabIndex = 4;
            this.buttonsave.Text = "Сохранить текст";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 157);
            this.richTextBox1.MaxLength = 1000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(542, 75);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // AtbashProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(566, 286);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttoncipher);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtbashProgram";
            this.Text = "Шифр Атбаш";
            this.Load += new System.EventHandler(this.AtbashProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttoncipher;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}