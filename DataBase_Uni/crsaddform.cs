using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_Uni
{
    public partial class crsaddform : Form
    {
        public crsaddform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
        void Display()
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select * from crs", con))
                {
                    da.Fill(ds, "crs");
                    crsDGV.DataSource = ds;
                    crsDGV.DataMember = "crs";
                    crsDGV.Columns[0].HeaderText = "کد درس";
                    crsDGV.Columns[1].HeaderText = "نام درس";
                    crsDGV.Columns[2].HeaderText = "تعداد واحد";
                    crsDGV.Columns[3].HeaderText = "شماره‌ی دانشکده";

                }
            }
        }

        void fillcombo()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("select clg#,clgname from clg", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.NewRow();
                row[1] = 1;
                row[1] = "دانشکده را انتخاب کنید";
                dt.Rows.InsertAt(row, 1);
                clgnumcombo.DataSource = dt;
                clgnumcombo.DisplayMember = "clgnameclg#";
                clgnumcombo.ValueMember = "clg#";
            }
        }
        bool validinput(string input)
        {
            int result = 0;
            if (int.TryParse(input, out result))
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"insert into crs(cname,unit,clg#)values('{cname.Text}','{unit.Text}','{clgnumcombo.Text}')", con))
            {  
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();  
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand($"update crs set cname=N'{cname.Text}',unit='{unit.Text}',clg#='{clgnumcombo.Text}' where c#={cnum.Text}", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cname.Text = unit.Text = clgnumcombo.Text = "";
                Display();
                
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"delete from crs where c#={cnum.Text}", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cnum.Text = cname.Text = unit.Text = clgnumcombo.Text = "";
            }
        }

        private void crsaddform_Load(object sender, EventArgs e)
        {
            Display();
            fillcombo();
        }

        private void crsDGV_MouseUp(object sender, MouseEventArgs e)
        {
            cnum.Text = crsDGV[0, crsDGV.CurrentRow.Index].Value.ToString();
            cname.Text = crsDGV[1, crsDGV.CurrentRow.Index].Value.ToString();
            unit.Text = crsDGV[2, crsDGV.CurrentRow.Index].Value.ToString();
            clgnumcombo.Text = crsDGV[3, crsDGV.CurrentRow.Index].Value.ToString();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlDataReader at;
            if (cnum.Text != null)
            {
                using (SqlCommand cmd = new SqlCommand($"select * from crs where c#={cnum.Text}", con))
                {
                    con.Open();
                    at = cmd.ExecuteReader();
                    if (at.Read())
                    {
                        cname.Text = at["cname"].ToString();
                        unit.Text = at["unit"].ToString();
                        clgnumcombo.Text = at["clg#"].ToString();
                    }
                    else
                        MessageBox.Show($"درسی با کد {cnum.Text} یافت نشد");
                    con.Close();
                }
            }
            else
                MessageBox.Show("کد درس را وارد کنید");
        }
    }
}
