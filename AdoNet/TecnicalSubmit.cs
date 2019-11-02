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
    public partial class TecnicalSubmit : Form
    {
        public TecnicalSubmit()
        {
            InitializeComponent();
        }

        private void TecnicalSubmit_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("data source=DESKTOP-TAQVNQ0\\SQLEXPRESS ;Initial Catalog=Maraton1;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Users values(@name,@surname,@rolId,@username,@password)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@rolId", textBox3.Text);
            cmd.Parameters.AddWithValue("@username", textBox5.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);
            int result = cmd.ExecuteNonQuery();
            if (result != 0) { MessageBox.Show("Tecnical User is submit"); }
        }

      
    }
}
