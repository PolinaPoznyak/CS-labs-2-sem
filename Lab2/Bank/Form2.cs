using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form2 : Form
    {
        public Owner owner;
        public Account account;
        public Form2(Owner owner, Account account)
        {
            InitializeComponent();
            this.owner = owner;
            this.account = account;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fio_label.Text = owner.fullName;
            num_label.Text = owner.account.number.ToString();
            dateReg_label.Text = owner.account.openingDate.ToString();
            balance_label.Text = $"{owner.account.ShowBalance()} BYN";
            contrType_label.Text = $"{owner.account.ShowContribType()}";
        }
    }
}
