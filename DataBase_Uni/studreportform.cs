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
    public partial class studreportform : Form
    {
        public studreportform()
        {
            InitializeComponent();
        }
                                             //Data Source=.;Initial Catalog=Univercity_DBproject;Integrated Security=True
        SqlConnection con = new SqlConnection("Server=.;Database=Univercity_DBproject;Trusted_Connection=True;");
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

        private void studreportform_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from stud where sname like '%' + @a + '%'", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@a", nametxt.Text);
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
                    
                }
            }
        }

        private void snumtxt_TextChanged(object sender, EventArgs e)
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter da = new SqlDataAdapter($"select * from stud where s# like  {snumtxt.Text} ", con))
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
                    
                }
            }
               
        }
    }
}
