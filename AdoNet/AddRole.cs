using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraton_2
{
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void AddRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Rols' table. You can move, or remove it, as needed.
            this.rolsTableAdapter.Fill(this.dataSet1.Rols);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.rolsTableAdapter.Update(this.dataSet1.Rols);

        }
    }
}
