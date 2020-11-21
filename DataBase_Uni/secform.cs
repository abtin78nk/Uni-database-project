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
    public partial class secform : Form
    {
        public secform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
        private void secform_Load(object sender, EventArgs e)
        {
            Display();
        }
        void Display()
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select * from sec", con))
                {
                    da.Fill(ds, "sec");
                    secDGV.DataSource = ds;
                    secDGV.DataMember = "sec";

                }
            }
        }   
        private void addbtn_Click(object sender, EventArgs e)

        {
            string term = "951";
            int sec = 501;
            using (SqlCommand cmd = new SqlCommand($"insert into sec(sec#,s#,c#,term,pname,score)values({sec},{snum.Text},{cnum.Text},{term},N'{pname.Text}',{score.Text})", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Double avg;
            using (SqlCommand cmd = new SqlCommand($"select AVG(score) from sec where s#={Avgtxt.Text}", con))
            {
                con.Open();
                avg = Convert.ToDouble(cmd.ExecuteScalar());
                using (SqlCommand c = new SqlCommand($"update stud set average={avg} where s#={Avgtxt.Text}", con))
                {
                    c.ExecuteNonQuery();
                    con.Close();
                    new addstudform().ShowDialog();
                }
            }  
        }

        private void secDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            pname.Text = secDGV[4, secDGV.CurrentRow.Index].Value.ToString();
            cnum.Text = secDGV[2, secDGV.CurrentRow.Index].Value.ToString();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update sec set pname=N'{pname.Text}' where c#={cnum.Text}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Display();
        }
    }
}
