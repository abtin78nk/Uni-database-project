namespace DataBase_Uni
{
    partial class secform
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.snum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.secDGV = new System.Windows.Forms.DataGridView();
            this.cnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Avgtxt = new System.Windows.Forms.TextBox();
            this.ubtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 70;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "دانشجو";
            // 
            // snum
            // 
            this.snum.Location = new System.Drawing.Point(624, 17);
            this.snum.Name = "snum";
            this.snum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snum.Size = new System.Drawing.Size(100, 22);
            this.snum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "درس";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(684, 59);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 45);
            this.addbtn.TabIndex = 63;
            this.addbtn.Text = "اضافه کردن ";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // secDGV
            // 
            this.secDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secDGV.Location = new System.Drawing.Point(12, 119);
            this.secDGV.Name = "secDGV";
            this.secDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secDGV.RowTemplate.Height = 24;
            this.secDGV.Size = new System.Drawing.Size(776, 184);
            this.secDGV.TabIndex = 60;
            this.secDGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.secDGV_CellMouseUp);
            // 
            // cnum
            // 
            this.cnum.Location = new System.Drawing.Point(435, 17);
            this.cnum.Name = "cnum";
            this.cnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cnum.Size = new System.Drawing.Size(100, 22);
            this.cnum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "نمره";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(74, 17);
            this.score.Name = "score";
            this.score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.score.Size = new System.Drawing.Size(100, 22);
            this.score.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "استاد";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(257, 17);
            this.pname.Name = "pname";
            this.pname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pname.Size = new System.Drawing.Size(100, 22);
            this.pname.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(281, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 75;
            this.button2.Text = "حساب کردن معدل";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "معدل";
            // 
            // Avgtxt
            // 
            this.Avgtxt.Location = new System.Drawing.Point(398, 68);
            this.Avgtxt.Name = "Avgtxt";
            this.Avgtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Avgtxt.Size = new System.Drawing.Size(100, 22);
            this.Avgtxt.TabIndex = 76;
            // 
            // ubtn
            // 
            this.ubtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ubtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ubtn.Location = new System.Drawing.Point(578, 59);
            this.ubtn.Name = "ubtn";
            this.ubtn.Size = new System.Drawing.Size(100, 45);
            this.ubtn.TabIndex = 78;
            this.ubtn.Text = "و";
            this.ubtn.UseVisualStyleBackColor = false;
            this.ubtn.Click += new System.EventHandler(this.ubtn_Click);
            // 
            // secform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.ubtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Avgtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.snum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.secDGV);
            this.Controls.Add(this.cnum);
            this.Name = "secform";
            this.Text = "b";
            this.Load += new System.EventHandler(this.secform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox snum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView secDGV;
        private System.Windows.Forms.TextBox cnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Avgtxt;
        private System.Windows.Forms.Button ubtn;
    }
}