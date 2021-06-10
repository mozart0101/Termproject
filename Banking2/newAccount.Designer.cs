
namespace Banking2
{
    partial class newAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unmarriedradio = new System.Windows.Forms.RadioButton();
            this.marriedradio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accnotext = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.balance = new System.Windows.Forms.Label();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객 정보";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재 날짜";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(453, 98);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(122, 18);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "데이터 레이블";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "계좌번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "생년월일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "핸드폰 번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "주소";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unmarriedradio);
            this.groupBox1.Controls.Add(this.marriedradio);
            this.groupBox1.Location = new System.Drawing.Point(595, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결혼여부";
            // 
            // unmarriedradio
            // 
            this.unmarriedradio.AutoSize = true;
            this.unmarriedradio.Location = new System.Drawing.Point(238, 28);
            this.unmarriedradio.Name = "unmarriedradio";
            this.unmarriedradio.Size = new System.Drawing.Size(69, 22);
            this.unmarriedradio.TabIndex = 0;
            this.unmarriedradio.TabStop = true;
            this.unmarriedradio.Text = "미혼";
            this.unmarriedradio.UseVisualStyleBackColor = true;
            // 
            // marriedradio
            // 
            this.marriedradio.AutoSize = true;
            this.marriedradio.Location = new System.Drawing.Point(114, 28);
            this.marriedradio.Name = "marriedradio";
            this.marriedradio.Size = new System.Drawing.Size(69, 22);
            this.marriedradio.TabIndex = 0;
            this.marriedradio.TabStop = true;
            this.marriedradio.Text = "혼인";
            this.marriedradio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.femaleradio);
            this.groupBox2.Controls.Add(this.maleradio);
            this.groupBox2.Location = new System.Drawing.Point(595, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(238, 28);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(51, 22);
            this.femaleradio.TabIndex = 0;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "여";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(114, 28);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(51, 22);
            this.maleradio.TabIndex = 0;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "남";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(666, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "사진 올리기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 755);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accnotext
            // 
            this.accnotext.Location = new System.Drawing.Point(165, 177);
            this.accnotext.Name = "accnotext";
            this.accnotext.Size = new System.Drawing.Size(371, 28);
            this.accnotext.TabIndex = 9;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(165, 260);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(371, 28);
            this.nametxt.TabIndex = 9;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(165, 422);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(371, 28);
            this.phonetxt.TabIndex = 9;
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(165, 498);
            this.addtxt.Multiline = true;
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(371, 60);
            this.addtxt.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(370, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(759, 619);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 22);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "부";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(759, 677);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 22);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "모";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(706, 740);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(44, 18);
            this.balance.TabIndex = 12;
            this.balance.Text = "잔고";
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(759, 730);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(329, 28);
            this.balancetxt.TabIndex = 13;
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 911);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.addtxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accnotext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newAccount";
            this.Text = "newAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton unmarriedradio;
        private System.Windows.Forms.RadioButton marriedradio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton femaleradio;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accnotext;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.TextBox balancetxt;
    }
}