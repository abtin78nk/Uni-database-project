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
    public partial class addprofform : Form
    {
        public addprofform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
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

        void Display()
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select * from prof", con))
                {
                    da.Fill(ds, "prof");
                    profDGV.DataSource = ds;
                    profDGV.DataMember = "prof";
                    profDGV.Columns[0].HeaderText = "کد استادی";
                    profDGV.Columns[1].HeaderText = "نام استاد";
                    profDGV.Columns[2].HeaderText = "مدرک";
                    profDGV.Columns[3].HeaderText = "شماره‌ی دانشکده";
                    profDGV.Columns[4].HeaderText = "رشته";
                    profDGV.Columns[5].HeaderText = "دفتر";
                }
            }
        }
        private void addprofform_Load(object sender, EventArgs e)
        {
            fillcombo();
            Display();
        }
        private void insertbtn_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand("insert into prof(pname,degree,clg#,esp,office,city) values (@a,@b,@c,@d,@e,@h)", con))
            {
                cmd.Parameters.AddWithValue("@a", nametxt.Text);
                cmd.Parameters.AddWithValue("@b", Dtxt.Text);
                cmd.Parameters.AddWithValue("@c", clgnumcombo.Text);
                cmd.Parameters.AddWithValue("@d", esptxt.Text);
                cmd.Parameters.AddWithValue("@e", officetxt.Text);
                cmd.Parameters.AddWithValue("@h", citytxt.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                nametxt.Text = Dtxt.Text = clgnumcombo.Text = citytxt.Text = esptxt.Text = officetxt.Text = "";
                
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("update prof set pname= @a,degree=@b,clg#=@c,esp=@d,office=@e,city=@h", con))
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", nametxt.Text);
                cmd.Parameters.AddWithValue("@b", Dtxt.Text);
                cmd.Parameters.AddWithValue("@c", clgnumcombo.Text);
                cmd.Parameters.AddWithValue("@d", esptxt.Text);
                cmd.Parameters.AddWithValue("@e", officetxt.Text);
                cmd.Parameters.AddWithValue("@h", citytxt.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                nametxt.Text = Dtxt.Text = clgnumcombo.Text = citytxt.Text = esptxt.Text = officetxt.Text = "";
                
            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"Delete from prof where p#={pnum.Text}", con))
            {
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                nametxt.Text = Dtxt.Text = clgnumcombo.Text = citytxt.Text = esptxt.Text = officetxt.Text = "";
                
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlDataReader info;
            using (SqlCommand cmd = new SqlCommand($"select * from prof where p#={pnum.Text}", con))
            {
                con.Open();
                info = cmd.ExecuteReader();
                if (info.Read())
                {
                    nametxt.Text = info["pname"].ToString();
                    Dtxt.Text = info["degree"].ToString();
                    clgnumcombo.Text = info["clg#"].ToString();
                    esptxt.Text = info["esp"].ToString();
                    officetxt.Text = info["office"].ToString();
                }
                else
                {
                    MessageBox.Show($"استادی با کد{pnum.Text} یافت نشد");
                    pnum.Text = "";
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnum.Text = profDGV[0, profDGV.CurrentRow.Index].Value.ToString();
            nametxt.Text = profDGV[1, profDGV.CurrentRow.Index].Value.ToString();
            Dtxt.Text = profDGV[2, profDGV.CurrentRow.Index].Value.ToString();
            esptxt.Text = profDGV[3, profDGV.CurrentRow.Index].Value.ToString();
            officetxt.Text = profDGV[4, profDGV.CurrentRow.Index].Value.ToString();
            citytxt.Text = profDGV[5, profDGV.CurrentRow.Index].Value.ToString();
        }
    }
}



