using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPhysical
{
    public partial class Navi : Form
    {
        public Navi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thaukinh tk = new Thaukinh();
            tk.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmConlac cl = new FmConlac();
            cl.Show();
            this.Close();
        }


    }
}
