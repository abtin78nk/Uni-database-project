namespace DataBase_Uni
{
    partial class studreportform
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
            this.studDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.snumtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 52;
            this.label1.Text = "جستجو بر اساس";
            // 
            // studDGV
            // 
            this.studDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDGV.Location = new System.Drawing.Point(10, 97);
            this.studDGV.Name = "studDGV";
            this.studDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studDGV.RowTemplate.Height = 24;
            this.studDGV.Size = new System.Drawing.Size(776, 333);
            this.studDGV.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "شماره دانشجویی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "نام و نام خانوادگی";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(577, 48);
            this.nametxt.Name = "nametxt";
            this.nametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 0;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // snumtxt
            // 
            this.snumtxt.Location = new System.Drawing.Point(285, 50);
            this.snumtxt.Name = "snumtxt";
            this.snumtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.snumtxt.Size = new System.Drawing.Size(100, 22);
            this.snumtxt.TabIndex = 1;
            this.snumtxt.TextChanged += new System.EventHandler(this.snumtxt_TextChanged);
            // 
            // studreportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.snumtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studDGV);
            this.Name = "studreportform";
            this.Text = "studreportform";
            this.Load += new System.EventHandler(this.studreportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox snumtxt;
    }
}