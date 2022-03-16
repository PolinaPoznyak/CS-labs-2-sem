using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        private const string path = @"D:\ООП\CS labs 2 sem\Bank\File.json";
        private Account account;
        private Owner owner;
        public List<Owner> OwnerList { get; set; }
        public Form1()
        {
            InitializeComponent();
            OwnerList = new List<Owner>();
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            fullName_textBox.Text = string.Empty;
            number_textBox.Text = string.Empty;
            passport_textBox.Text = string.Empty;
            contribType_comboBox.Text = string.Empty;
            OutputBox.Text = string.Empty;
            sms_checkBox.Checked = false;
            netBank_checkBox.Checked = false;
            fixedProc_radioButton.Checked = false;
            floatProc_radioButton.Checked = false;
        }

        private void toFile_button_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializator.ToJson(OwnerList, path);
                MessageBox.Show("Данные записаны в файл");
            }
            catch (Exception)
            {

                MessageBox.Show("Не удалось сериализовать");
            }
        }

        private void fromFile_button_Click(object sender, EventArgs e)
        {
            try
            {
                OwnerList = JsonSerializator.FromJson(path);
                foreach (var owner in OwnerList)
                {
                    OutputBox.Text += owner.ShowOwnerInfo();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Не удалось сериализовать объект");
            }
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            try
            {
                account = new Account(Int32.Parse(number_textBox.Text), opendate_calendar.Value, Int32.Parse(balance_textBox.Text), contribType_comboBox.Text);
                owner = new Owner(account, fullName_textBox.Text, birthday_calendar.Value, passport_textBox.Text, sms_checkBox.Checked, netBank_checkBox.Checked);
                OutputBox.Text += owner.ShowOwnerInfo();
                Form2 userInfo = new Form2(owner, account);
                OwnerList.Add(owner);
                userInfo.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Для продолжения регистрации, пожалуйста, заполните все поля формы");
            }
        }

        private void sum_trackBar_Scroll(object sender, EventArgs e)
        {
            balance_textBox.Text = sum_trackBar.Value.ToString();
        }

        private void number_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char bs = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(bs))
            {
                e.Handled = true;
            }
        }

        private void fullName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            char bs = e.KeyChar;
            char ws = e.KeyChar;

            if (!Char.IsLetter(letter) && !Char.IsControl(bs) && !Char.IsWhiteSpace(ws))
            {
                e.Handled = true;
            }
        }
    }
}
