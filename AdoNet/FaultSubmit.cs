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
    public partial class FaultSubmit : Form
    {
        public FaultSubmit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=DESKTOP-TAQVNQ0\\SQLEXPRESS ;Initial Catalog=Maraton1;Integrated Security=True");

        private void FaultSubmit_Load(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click_1(object sender, EventArgs e)
        {
            


            SqlCommand cmd = new SqlCommand("Insert Into Faults values(@FaultNo,@FaultName,@MusteriId,@tecnicalId,@FaultDesc,@state,@time)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@FaultNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@FaultName", textBox2.Text);
            cmd.Parameters.AddWithValue("@FaultDesc", textBox3.Text);
            cmd.Parameters.AddWithValue("@MusteriId", comboBox4.SelectedValue);
            cmd.Parameters.AddWithValue("@tecnicalId", comboBox3.SelectedValue);
            cmd.Parameters.AddWithValue("@state", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@time", dateTimePicker1.Value);
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("Fault is added");
            }
            con.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = File;
                pictureBox1.Image.Save(File + @"C:\Users\Betul.karaduman\source\repos\Maraton\Maraton\Image" + openFileDialog.SafeFileName);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = File;
                pictureBox1.Image.Save(File + @"C:\Users\Betul.karaduman\source\repos\Maraton\Maraton\Image" + openFileDialog.SafeFileName);
            }

        }
    }
}
