using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking2
{
    public partial class FDForm : Form
    {
        public FDForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("현금");
            comboBox1.Items.Add("체크");

        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("yyyy/MM/dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(accnotxt.Text);
            fdform.Mode = comboBox1.SelectedItem.ToString();
            fdform.Won = wontxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.interest_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("yyyy/MM/dd");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("yyyy/MM/dd");
            fdform.Maturity_Amount = ((Convert.ToDecimal(wontxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text)) /
                (100 * 12 * 30)) + (Convert.ToDecimal(wontxt.Text));
            dbe.FDs.Add(fdform);
            decimal amount = Convert.ToDecimal(wontxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdammount = totalamount - amount;
            accounts.balance = fdammount;

            dbe.SaveChanges();
            MessageBox.Show("정기예금 시작");

        }
    }
}
