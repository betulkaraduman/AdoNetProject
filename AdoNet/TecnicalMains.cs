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
    public partial class TecnicalMains : Form
    {
        int _Id;
        public TecnicalMains(int id)
        {
            _Id = id;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=DESKTOP-TAQVNQ0\\SQLEXPRESS ;Initial Catalog=Maraton1;Integrated Security=True");

        private void TecnicalMains_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select*from Faults where TecnicalId=@Id", con);
            cmd.Parameters.AddWithValue("@Id", _Id);
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(table);
            dataGridView1.DataSource = table;



            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                if (item.ToString() == "NULL")
                {
                    item.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (item.Cells[5].Value.ToString() == "Process") { }
                else item.DefaultCellStyle.BackColor = Color.Red;
            }
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("update Faults set state=@state,Time=@time",con);
            con.Open();
            cmd.Parameters.AddWithValue("@state", dataGridView1.Rows[0].ToString());
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            int result = cmd.ExecuteNonQuery();
            if (result != 0) { MessageBox.Show("Update is succesfull"); }

        }
    }
}
