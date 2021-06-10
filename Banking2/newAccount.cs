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
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities1 BSE;
        MemoryStream ms;
        

        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities1();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);

           // var item = BSE.user
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            datelbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label1_Click(object sender, EventArgs e)   
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opebdlg = new OpenFileDialog();
            if (opebdlg.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(opebdlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maleradio.Checked)
            {
                gender = "남자";
            }
            else if (femaleradio.Checked)
            {
                
                    gender = "여자";
                }
            if (marriedradio.Checked)
                {
                   m_status = "결혼";
                }
            else if (unmarriedradio.Checked)
                {
                    m_status = "미혼";
                }


                BSE = new banking_dbEntities1();
                userAccount acc = new userAccount();
                acc.Account_No = Convert.ToDecimal(accnotext.Text);
                acc.Name = nametxt.Text;
                acc.DOB = dateTimePicker1.Value.ToString();
                acc.PhoneNo = phonetxt.Text;
                acc.Address = addtxt.Text;
                acc.Gender = gender;
                acc.maritial_status = m_status;
                acc.date = datelbl.Text;
                acc.Picutre = ms.ToArray();
                acc.balance = Convert.ToDecimal(balancetxt.Text);                
                BSE.userAccounts.Add(acc);
                BSE.SaveChanges();
                MessageBox.Show("저장 되었습니다."); 
            
        }
    }
}
