using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class KırıkKumbaraForm : Form
    {
        public KırıkKumbaraForm(BindingList<Para> kagit, BindingList<Para> bozuk, double biriken)
        {
            InitializeComponent();
            DataGuncelle(kagit, bozuk, biriken);
        }
        public void DataGuncelle(BindingList<Para> kagitlar, BindingList<Para> bozuklar, double birikmis)
        {
            lblMiktar.Text = "Amount Of Money Saved: " + birikmis.ToString() + "₺";
            dgvAtilanKagitParalar.DataSource = null;
            dgvAtilanKagitParalar.DataSource = kagitlar.ToList();
            dgvAtilanBozukParalar.DataSource = null;
            dgvAtilanBozukParalar.DataSource = bozuklar.ToList();
        }

        private void dgvAtilanKagitParalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBozukParalar_Click(object sender, EventArgs e)
        {

        }

        private void lblKagitParalar_Click(object sender, EventArgs e)
        {

        }

        private void dgvAtilanBozukParalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMiktar_Click(object sender, EventArgs e)
        {

        }

        private void lblKagitParalar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
