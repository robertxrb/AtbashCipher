namespace AtbashCipher
{
    partial class AtbashAutorization
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAutorization = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AtbashCipher.Properties.Resources.AtbashLogo;
            this.pictureBox.Location = new System.Drawing.Point(280, 88);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(276, 269);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // textlogin
            // 
            this.textlogin.BackColor = System.Drawing.Color.BurlyWood;
            this.textlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textlogin.Location = new System.Drawing.Point(17, 85);
            this.textlogin.MaxLength = 32;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(198, 29);
            this.textlogin.TabIndex = 5;
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.BurlyWood;
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpassword.Location = new System.Drawing.Point(17, 151);
            this.textpassword.MaxLength = 32;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(198, 31);
            this.textpassword.TabIndex = 6;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.Color.Sienna;
            this.checkBox.Location = new System.Drawing.Point(17, 188);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(154, 20);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "Показать пароль";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(310, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шифр Атбаш";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Новый пользователь?";
            // 
            // buttonAutorization
            // 
            this.buttonAutorization.BackColor = System.Drawing.Color.Linen;
            this.buttonAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutorization.Location = new System.Drawing.Point(17, 214);
            this.buttonAutorization.Name = "buttonAutorization";
            this.buttonAutorization.Size = new System.Drawing.Size(198, 32);
            this.buttonAutorization.TabIndex = 10;
            this.buttonAutorization.Text = "Вход";
            this.buttonAutorization.UseVisualStyleBackColor = false;
            this.buttonAutorization.Click += new System.EventHandler(this.buttonAutorization_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Linen;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(16, 305);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(226, 34);
            this.buttonRegistration.TabIndex = 11;
            this.buttonRegistration.Text = "Зарегистрировать аккаунт";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // AtbashAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonAutorization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtbashAutorization";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAutorization;
        private System.Windows.Forms.Button buttonRegistration;
    }
}