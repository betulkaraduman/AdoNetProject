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
    public partial class CustomerSubmit : Form
    {
        public CustomerSubmit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=DESKTOP-TAQVNQ0\\SQLEXPRESS ;Initial Catalog=Maraton1;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Customer values(@name,@surname,@rolId)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@rolId", textBox3.Text);
            //SqlDataReader rd = null;
            int result = cmd.ExecuteNonQuery();
            if (result != 0) { MessageBox.Show("Insert is successfull"); }
            con.Close();
        }

    }
}
