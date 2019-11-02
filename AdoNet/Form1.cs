using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraton_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TAQVNQ0\\SQLEXPRESS ;Initial Catalog=Maraton1;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from Users where Username=@username and Password=@password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int rolId = rd.GetInt32(3);
                int Id = rd.GetInt32(0);
                if (rolId == 1)
                {
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                    this.Hide();
                }
                else if (rolId == 2)
                {
                    TecnicalMains frm = new TecnicalMains(Id);
                    frm.ShowDialog();
                    this.Hide();
                }

                //Form2 frm = new Form2();
                //frm.ShowDialog();

            }
            con.Close();
        }
    }
}
