﻿
namespace Banking2
{
    partial class Debitform
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
            this.datelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.acctxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.oldbaltxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(166, 50);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 18);
            this.datelbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "계좌번호 입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "잔고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "형식";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "금액";
            // 
            // acctxt
            // 
            this.acctxt.Location = new System.Drawing.Point(202, 149);
            this.acctxt.Name = "acctxt";
            this.acctxt.Size = new System.Drawing.Size(508, 28);
            this.acctxt.TabIndex = 3;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(202, 225);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(508, 28);
            this.nametxt.TabIndex = 3;
            // 
            // oldbaltxt
            // 
            this.oldbaltxt.Location = new System.Drawing.Point(202, 306);
            this.oldbaltxt.Name = "oldbaltxt";
            this.oldbaltxt.Size = new System.Drawing.Size(508, 28);
            this.oldbaltxt.TabIndex = 3;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(202, 463);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(508, 28);
            this.amounttxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "자세히 보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(508, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // Debitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 652);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.oldbaltxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.acctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label1);
            this.Name = "Debitform";
            this.Text = "Debitform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox acctxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox oldbaltxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}