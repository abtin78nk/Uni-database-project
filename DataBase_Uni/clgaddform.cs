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
    public partial class clgaddform : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
        void Display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select * from clg", con);
            da.Fill(ds, "clg");
            clgDGV.DataSource = ds;
            clgDGV.DataMember = "clg";
            clgDGV.Columns[0].HeaderText = "شماره‌ی دانشکده";
            clgDGV.Columns[1].HeaderText = "نام دانشکده";
            clgDGV.Columns[2].HeaderText = "شهر";
            clgDGV.Columns[3].HeaderText = "رییس دانشکده";
        }
        public clgaddform()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            clgnumtxt.Text = clgDGV[0, clgDGV.CurrentRow.Index].Value.ToString();
            clgnametxt.Text = clgDGV[1, clgDGV.CurrentRow.Index].Value.ToString();
            citytxt.Text = clgDGV[2, clgDGV.CurrentRow.Index].Value.ToString();
            pname.Text = clgDGV[3, clgDGV.CurrentRow.Index].Value.ToString();
        }
        private void clgaddform_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"insert into clg(clgname,city,pname)values(N'{clgnametxt.Text}',N'{citytxt.Text}',N'{pname.Text}')", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();   
            }
                
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"update clg set pname='{pname.Text}' where clg#={clgnametxt.Text}", con))
            {
                con.Open();
                cmd.Parameters.Clear();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand($"Delete from clg where clg#={clgnumtxt.Text}", con))
            {
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                clgnametxt.Text = pname.Text = citytxt.Text = "";
            }
        }
    }
}
