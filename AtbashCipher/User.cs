using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashCipher
{
    class User
    {
        private string Login;
        private string Password;
        private string Password2;
        public User(string login, string password, string password2 = null)
        {
            Login = login;
            Password = password;
            Password2 = password2;
        }

        public bool Correct()
        {
            if (Login.Trim() == "")
            {
                MessageBox.Show("Заполните поле логина.");
                return false;
            }
            else if (Login.Trim() != Login)
            {
                MessageBox.Show("Логин не должен содержать пробелов.");
                return false;
            }
            else if (Login.Length < 3)
            {
                MessageBox.Show("Логин должен иметь длину более двух символов.");
                return false;
            }
            else if (Password == "")
            {
                MessageBox.Show("Заполните поле пароля.");
                return false;
            }
            else if (Password.Trim() != Password)
            {
                MessageBox.Show("Пароль не должен содержать пробелов.");
                return false;
            }
            else if (Password.Length < 6)
            {
                MessageBox.Show("Пароль должен иметь длину более пяти символов.");
                return false;
            }
            else if (Password.Length > 9)
            {
                MessageBox.Show("Пароль должен иметь длину менее десяти символов.");
                return false;
            }
            else if (Password != Password2 && Password2 != null)
            {
                MessageBox.Show("Пароль и повторение пароля не совпадают");
                return false;
            }
            return true;
        }
    }
}
