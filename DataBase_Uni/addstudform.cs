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
    public partial class addstudform : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
        public addstudform()
        {
            InitializeComponent();
        }
        void Display()
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select * from stud", con))
                {
                    da.Fill(ds, "stud");
                    studDGV.DataSource = ds;
                    studDGV.DataMember = "stud";
                    studDGV.Columns[0].HeaderText = "شماره‌ی دانشجویی";
                    studDGV.Columns[1].HeaderText = "نام و نام خانوادگی";
                    studDGV.Columns[2].HeaderText = "نام پدر";
                    studDGV.Columns[3].HeaderText = "کد ملی";
                    studDGV.Columns[4].HeaderText = "شهر";
                    studDGV.Columns[5].HeaderText = "تاریخ تولد";
                    studDGV.Columns[6].HeaderText = "سال ورود";
                    studDGV.Columns[7].HeaderText = "رشته";
                    studDGV.Columns[8].HeaderText = "شماره‌ی دانشکده";
                    studDGV.Columns[9].HeaderText = "معدل ترم گذشته";
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
        //bool validinput(string input)
        //{
        //    int result = 0;
        //    if (int.TryParse(input, out result))
        //        return true;
        //    return false;
        //}
        private void addstudform_Load(object sender, EventArgs e)
        {
            Display();
            fillcombo();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("insert into stud(sname,Fathername,NationalCode,city,Borndate,EntryYear,study,clg#) values(@a,@b,@c,@d,@e,@f,@g,@h)", con))
            {
                cmd.Parameters.AddWithValue("@a", nametxt.Text);
                cmd.Parameters.AddWithValue("@b", fathertxt.Text);
                cmd.Parameters.AddWithValue("@c", Int32.Parse(idtxt.Text));
                cmd.Parameters.AddWithValue("@d", city.Text);
                cmd.Parameters.AddWithValue("@e", borndatetxt.Text);
                cmd.Parameters.AddWithValue("@f", Int32.Parse(yeartxt.Text));
                cmd.Parameters.AddWithValue("@g", studytxt.Text);
                cmd.Parameters.AddWithValue("@h", Int32.Parse(clgnumcombo.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                nametxt.Text = fathertxt.Text = idtxt.Text = city.Text = borndatetxt.Text = yeartxt.Text = studytxt.Text = clgnumcombo.Text = "";
                Display();
            } 
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"update stud set sname=N'{nametxt.Text}',Fathername=N'{fathertxt.Text}',NationalCode=N'{idtxt.Text}',city=N'{city.Text}',Borndate=N'{borndatetxt.Text}',EntryYear=N'{yeartxt.Text}',study=N'{studytxt.Text}',clg#=N'{clgnumcombo.Text}' where s#='{snumtxt.Text}'", con))
            {
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                nametxt.Text = fathertxt.Text = idtxt.Text = city.Text = borndatetxt.Text = yeartxt.Text = studytxt.Text = clgnumcombo.Text = "";
            }
               
        }
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"Delete from stud where s#={snumtxt.Text}", con))
            {
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                snumtxt.Text = nametxt.Text = fathertxt.Text = idtxt.Text = city.Text = borndatetxt.Text = yeartxt.Text = studytxt.Text = clgnumcombo.Text = "";
            }
        }
        private void snumtxt_TextChanged(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = new SqlCommand($"select * from stud where s# like  {Int32.Parse(snumtxt.Text)} ", con);
            //da.Fill(ds, "stud");
            //studDGV.DataSource = ds;
            //studDGV.DataMember = "stud";
            //studDGV.Columns[0].HeaderText = "شماره‌ی دانشجویی";
            //studDGV.Columns[1].HeaderText = "نام و نام خانوادگی";
            //studDGV.Columns[2].HeaderText = "نام پدر";
            //studDGV.Columns[3].HeaderText = "کد ملی";
            //studDGV.Columns[4].HeaderText = "شهر";
            //studDGV.Columns[5].HeaderText = "تاریخ تولد";
            //studDGV.Columns[6].HeaderText = "سال ورود";
            //studDGV.Columns[7].HeaderText = "رشته";
            //studDGV.Columns[8].HeaderText = "شماره‌ی دانشکده";

        }

        private void studDGV_MouseUp(object sender, MouseEventArgs e)
        {
            snumtxt.Text = studDGV[0, studDGV.CurrentRow.Index].Value.ToString();
            nametxt.Text = studDGV[1, studDGV.CurrentRow.Index].Value.ToString();
            fathertxt.Text = studDGV[2, studDGV.CurrentRow.Index].Value.ToString();
            idtxt.Text = studDGV[3, studDGV.CurrentRow.Index].Value.ToString();
            city.Text = studDGV[4, studDGV.CurrentRow.Index].Value.ToString();
            borndatetxt.Text = studDGV[5, studDGV.CurrentRow.Index].Value.ToString();
            yeartxt.Text = studDGV[6, studDGV.CurrentRow.Index].Value.ToString();
            studytxt.Text = studDGV[7, studDGV.CurrentRow.Index].Value.ToString();
            clgnumcombo.Text = studDGV[8, studDGV.CurrentRow.Index].Value.ToString();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlDataReader info;
            using (SqlCommand cmd = new SqlCommand($"select * from stud where s#={snumtxt.Text}", con))
            {
                con.Open();
                info = cmd.ExecuteReader();
                if (info.Read())
                {
                    nametxt.Text = info["sname"].ToString();
                    fathertxt.Text = info["Fathername"].ToString();
                    idtxt.Text = info["NationalCode"].ToString();
                    city.Text = info["city"].ToString();
                    borndatetxt.Text = info["Borndate"].ToString();
                    yeartxt.Text = info["EntryYear"].ToString();
                    studytxt.Text = info["study"].ToString();
                    clgnumcombo.Text = info["clg#"].ToString();
                    Avglbl.Visible = true;
                    avgv.Visible = true;
                    avgv.Text = info["average"].ToString();

                }
                else
                {
                    MessageBox.Show($"مشخصات دانشجو با شماره‌ دانشجویی {snumtxt.Text} پیدا نشد");
                    snumtxt.Focus();
                    snumtxt.Text = "";
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
