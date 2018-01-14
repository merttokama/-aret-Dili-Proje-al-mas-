using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaretDili_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmArsiv frm1 = new FrmArsiv();
            frm1.MdiParent = this;
            frm1.Show();

            FrmGiris frm = new FrmGiris();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
