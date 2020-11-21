namespace DataBase_Uni
{
    partial class crsaddform
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.crsDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cnum = new System.Windows.Forms.TextBox();
            this.clgnumcombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.cname = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.crsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "واحد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "نام درس";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.Location = new System.Drawing.Point(478, 105);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 45);
            this.deletebtn.TabIndex = 48;
            this.deletebtn.Text = "حذف";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebtn.Location = new System.Drawing.Point(584, 105);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 45);
            this.updatebtn.TabIndex = 47;
            this.updatebtn.Text = "ویرایش";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(690, 105);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 45);
            this.addbtn.TabIndex = 49;
            this.addbtn.Text = "اضافه کردن ";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // crsDGV
            // 
            this.crsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crsDGV.Location = new System.Drawing.Point(14, 166);
            this.crsDGV.Name = "crsDGV";
            this.crsDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.crsDGV.RowTemplate.Height = 24;
            this.crsDGV.Size = new System.Drawing.Size(776, 184);
            this.crsDGV.TabIndex = 46;
            this.crsDGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crsDGV_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "شماره‌ی دانشکده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "کد درس";
            // 
            // cnum
            // 
            this.cnum.Location = new System.Drawing.Point(626, 25);
            this.cnum.Name = "cnum";
            this.cnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cnum.Size = new System.Drawing.Size(100, 22);
            this.cnum.TabIndex = 53;
            // 
            // clgnumcombo
            // 
            this.clgnumcombo.FormattingEnabled = true;
            this.clgnumcombo.Location = new System.Drawing.Point(221, 63);
            this.clgnumcombo.Name = "clgnumcombo";
            this.clgnumcombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clgnumcombo.Size = new System.Drawing.Size(121, 24);
            this.clgnumcombo.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 56;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchbtn.Location = new System.Drawing.Point(579, 23);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(34, 24);
            this.searchbtn.TabIndex = 57;
            this.searchbtn.Text = "+";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(627, 63);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(100, 22);
            this.cname.TabIndex = 58;
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(469, 63);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(100, 22);
            this.unit.TabIndex = 59;
            // 
            // crsaddform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clgnumcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.crsDGV);
            this.Name = "crsaddform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن دروس";
            this.Load += new System.EventHandler(this.crsaddform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView crsDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnum;
        private System.Windows.Forms.ComboBox clgnumcombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox unit;
    }
}