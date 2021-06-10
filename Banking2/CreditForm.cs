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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddata();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            combobox1.Items.Add("돈");
            combobox1.Items.Add("체크");
        }

        private void loaddata()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("yyyy/MM/dd");
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = combobox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(amounttxt.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where u.Account_No == b
                        select u).FirstOrDefault();

            item.balance = item.balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("입금성공");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.maritial_status);


        }

        private void oldbaltxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
