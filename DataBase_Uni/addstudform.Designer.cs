namespace DataBase_Uni
{
    partial class addstudform
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.studDGV = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fathertxt = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.borndatetxt = new System.Windows.Forms.MaskedTextBox();
            this.clgnumcombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.snumtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Avglbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.avgv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(571, 50);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 28);
            this.nametxt.TabIndex = 0;
            // 
            // studDGV
            // 
            this.studDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDGV.Location = new System.Drawing.Point(12, 254);
            this.studDGV.Name = "studDGV";
            this.studDGV.RowTemplate.Height = 24;
            this.studDGV.Size = new System.Drawing.Size(776, 184);
            this.studDGV.TabIndex = 11;
            this.studDGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.studDGV_MouseUp);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(582, 193);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 45);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "ویرایش";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(688, 193);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 45);
            this.button11.TabIndex = 8;
            this.button11.Text = "اضافه کردن ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.idtxt.Location = new System.Drawing.Point(571, 83);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 28);
            this.idtxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(739, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "تاریخ تولد";
            // 
            // studytxt
            // 
            this.studytxt.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.studytxt.Location = new System.Drawing.Point(571, 154);
            this.studytxt.Name = "studytxt";
            this.studytxt.Size = new System.Drawing.Size(100, 28);
            this.studytxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "رشته‌ی تحصیلی";
            // 
            // fathertxt
            // 
            this.fathertxt.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.fathertxt.Location = new System.Drawing.Point(339, 50);
            this.fathertxt.Name = "fathertxt";
            this.fathertxt.Size = new System.Drawing.Size(100, 28);
            this.fathertxt.TabIndex = 1;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.city.Location = new System.Drawing.Point(339, 85);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 28);
            this.city.TabIndex = 3;
            // 
            // yeartxt
            // 
            this.yeartxt.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.yeartxt.Location = new System.Drawing.Point(341, 120);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(100, 28);
            this.yeartxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "نام پدر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "شهر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "سال ورود";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "شماره‌ی دانشکده";
            // 
            // borndatetxt
            // 
            this.borndatetxt.Font = new System.Drawing.Font("IRANSans", 7.8F);
            this.borndatetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.borndatetxt.Location = new System.Drawing.Point(571, 120);
            this.borndatetxt.Mask = "####/##/##";
            this.borndatetxt.Name = "borndatetxt";
            this.borndatetxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.borndatetxt.Size = new System.Drawing.Size(100, 28);
            this.borndatetxt.TabIndex = 4;
            // 
            // clgnumcombo
            // 
            this.clgnumcombo.FormattingEnabled = true;
            this.clgnumcombo.Location = new System.Drawing.Point(339, 157);
            this.clgnumcombo.Name = "clgnumcombo";
            this.clgnumcombo.Size = new System.Drawing.Size(100, 24);
            this.clgnumcombo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(677, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "شماره‌ دانشجویی";
            // 
            // snumtxt
            // 
            this.snumtxt.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snumtxt.Location = new System.Drawing.Point(571, 9);
            this.snumtxt.Name = "snumtxt";
            this.snumtxt.Size = new System.Drawing.Size(100, 28);
            this.snumtxt.TabIndex = 22;
            this.snumtxt.TextChanged += new System.EventHandler(this.snumtxt_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchbtn.Location = new System.Drawing.Point(529, 9);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(36, 30);
            this.searchbtn.TabIndex = 24;
            this.searchbtn.Text = "+";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Avglbl
            // 
            this.Avglbl.AutoSize = true;
            this.Avglbl.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avglbl.Location = new System.Drawing.Point(199, 159);
            this.Avglbl.Name = "Avglbl";
            this.Avglbl.Size = new System.Drawing.Size(103, 22);
            this.Avglbl.TabIndex = 26;
            this.Avglbl.Text = "معدل ترم گذشته";
            this.Avglbl.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBtn.Location = new System.Drawing.Point(465, 193);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 45);
            this.DeleteBtn.TabIndex = 27;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avgv
            // 
            this.avgv.AutoSize = true;
            this.avgv.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgv.Location = new System.Drawing.Point(90, 157);
            this.avgv.Name = "avgv";
            this.avgv.Size = new System.Drawing.Size(103, 22);
            this.avgv.TabIndex = 29;
            this.avgv.Text = "معدل ترم گذشته";
            this.avgv.Visible = false;
            // 
            // addstudform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Avglbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.snumtxt);
            this.Controls.Add(this.clgnumcombo);
            this.Controls.Add(this.borndatetxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studytxt);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.city);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.fathertxt);
            this.Controls.Add(this.studDGV);
            this.Controls.Add(this.nametxt);
            this.Name = "addstudform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن دانشجویان";
            this.Load += new System.EventHandler(this.addstudform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.DataGridView studDGV;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fathertxt;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox borndatetxt;
        private System.Windows.Forms.ComboBox clgnumcombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox snumtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label Avglbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label avgv;
    }
}