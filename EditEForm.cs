using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midnight
{
    public partial class EditEForm : Form
    {
        public EditEForm()
        {
            InitializeComponent();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSalvarE_Click(object sender, EventArgs e)
        {
            Form f1 = FindForm();
            MainForm f2 = new MainForm();
            f2.Show();
            f1.Hide();
        }
    }
}
