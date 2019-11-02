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
    public partial class CustomerQuickly : Form
    {
        public CustomerQuickly()
        {
            InitializeComponent();
        }

        private void CustomerQuickly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Update(this.dataSet1.Customer);

        }
    }
}
