namespace DataBase_Uni
{
    partial class clgaddform
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.clgnametxt = new System.Windows.Forms.TextBox();
            this.clgDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clgnumtxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clgDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 53;
            this.label8.Text = "رییس دانشکده";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "شهر";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(43, 9);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(100, 22);
            this.pname.TabIndex = 3;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deletebtn.Location = new System.Drawing.Point(476, 63);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(100, 45);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "حذف";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Editbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Editbtn.Location = new System.Drawing.Point(582, 63);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(100, 45);
            this.Editbtn.TabIndex = 4;
            this.Editbtn.Text = "ویرایش";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(248, 9);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(100, 22);
            this.citytxt.TabIndex = 2;
            // 
            // clgnametxt
            // 
            this.clgnametxt.Location = new System.Drawing.Point(391, 10);
            this.clgnametxt.Name = "clgnametxt";
            this.clgnametxt.Size = new System.Drawing.Size(100, 22);
            this.clgnametxt.TabIndex = 1;
            // 
            // clgDGV
            // 
            this.clgDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clgDGV.Location = new System.Drawing.Point(12, 124);
            this.clgDGV.Name = "clgDGV";
            this.clgDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clgDGV.RowTemplate.Height = 24;
            this.clgDGV.Size = new System.Drawing.Size(776, 184);
            this.clgDGV.TabIndex = 46;
            this.clgDGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "نام دانشکده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "شماره‌ی دانشکده";
            // 
            // clgnumtxt
            // 
            this.clgnumtxt.Location = new System.Drawing.Point(581, 9);
            this.clgnumtxt.Name = "clgnumtxt";
            this.clgnumtxt.Size = new System.Drawing.Size(100, 22);
            this.clgnumtxt.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(691, 63);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 45);
            this.addbtn.TabIndex = 56;
            this.addbtn.Text = "اضافه کردن ";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // clgaddform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clgnumtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.clgnametxt);
            this.Controls.Add(this.clgDGV);
            this.Name = "clgaddform";
            this.Text = "س";
            this.Load += new System.EventHandler(this.clgaddform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clgDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.TextBox clgnametxt;
        private System.Windows.Forms.DataGridView clgDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clgnumtxt;
        private System.Windows.Forms.Button addbtn;
    }
}