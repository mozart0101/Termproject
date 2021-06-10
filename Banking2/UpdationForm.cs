using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking2
{
    public partial class UpdationForm : Form
    {
        banking_dbEntities1 dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;


        public UpdationForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            acctxt.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;
            phonetxt.Text = item.PhoneNo;
            addresstxt.Text = item.Address;
            byte[] img = item.Picutre;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            if (item.Gender == "남자")
            {
                male.Checked = true;
            }
            else if (item.Gender == "여자")
            {
                female.Checked = true;

            }

            if (item.maritial_status == "혼인")
            {
                married.Checked = true;

            }
            else if (item.maritial_status == "미혼")
            {
                unmarried.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();

            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new banking_dbEntities1();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accountno = Convert.ToDecimal(acctxt.Text);
            userAccount userAccount = dbe.userAccounts.First(s => s.Account_No.Equals(accountno));
            userAccount.Account_No = Convert.ToDecimal(acctxt.Text);
            userAccount.Name = nametxt.Text;
            userAccount.date = dateTimePicker1.Value.ToString();
            userAccount.PhoneNo = phonetxt.Text;
            if (male.Checked == true)
            {
                userAccount.Gender = "남자";
            }
            else
            {
                if (female.Checked == true)
                    userAccount.Gender = "여자";
            }
            if (married.Checked == true)
            {
                userAccount.maritial_status = "결혼";

            }
            else
            {
                if (unmarried.Checked == true)
                    userAccount.maritial_status = "미혼";
            }
            Image img = pictureBox1.Image;
            if (img.RawFormat != null)
            {
                if (ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    userAccount.Picutre = ms.ToArray();
                }
            }
            userAccount.Address = addresstxt.Text;
            dbe.SaveChanges();
            MessageBox.Show("업데이트완료");
        }
    }
}
