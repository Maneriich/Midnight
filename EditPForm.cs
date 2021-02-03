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
    public partial class EditPForm : Form
    {
        public EditPForm()
        {
            InitializeComponent();
        }

        private void cbxOpcoesP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbTipoProduto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbTipoP_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = false;
            txtTipoP.Visible = true;
        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            Form f1 = FindForm();
            MainForm f2 = new MainForm();
            f2.Show();
            f1.Hide();
        }

        private void EditPForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
