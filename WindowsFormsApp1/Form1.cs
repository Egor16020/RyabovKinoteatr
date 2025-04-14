using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCaptcha.Text = GenerateCaptcha(4); // генерируем 4 символа
            label5.Visible = false; // скрыть сообщение об ошибке
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string captchaInput = textBoxCaptcha.Text; // не забудьте добавить TextBox для ввода CAPTCHA

            if (username == "user" && password == "user" && captchaInput == labelCaptcha.Text)
            {
                // Открываем главную форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                label5.Text = "Неверный логин, пароль или CAPTCHA!";
                label5.Visible = true; // Отображаем сообщение об ошибке
                labelCaptcha.Text = GenerateCaptcha(4); // Генерируем новую CAPTCHA
            }
        }

        

        private void textBoxCaptcha_TextChanged(object sender, EventArgs e)
        {

        }

        private string GenerateCaptcha(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }
    }
}
