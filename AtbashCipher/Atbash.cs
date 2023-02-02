using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashCipher
{
    class Atbash
    {
        private string alphabet;
        private string alphabetENG = "abcdefghijklmnopqrstuvwxyz";
        private string alphabetRUS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Encrypt(string text, int lang)
        {
            if (lang == 0)
            {
                alphabet = alphabetRUS;
            }
            if (lang == 1)
            {
                alphabet = alphabetENG;
            }
            text = text.ToLower();
            string line = "";

            for (int i = 0; i < text.Length; i++)
            {
                int index = alphabet.IndexOf(text[i]);
                if (index >= 0)
                {
                    line = line + alphabet[alphabet.Length - index - 1];
                }
                else
                {
                    line = line + text[i];
                }
            }

            return line;
        }
    }
}
