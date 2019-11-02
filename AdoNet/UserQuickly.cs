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
    public partial class UserQuickly : Form
    {
        public UserQuickly()
        {
            InitializeComponent();
        }

        private void UserQuickly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.Users);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Update(this.dataSet1.Users);

        }
    }
}
