using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace LPhysical
{
    public partial class BeginPage : Form
    {
        public BeginPage()
        {
            InitializeComponent();
            label3.Text = "Phần mềm được lập trình dựa trên\n     nền tảng .NET Framework";
            
        }

        private void class10_Click(object sender, EventArgs e)
        {
            Ktcoban clten = new Ktcoban();
            clten.Show();
        }


        private void KT12_Click(object sender, EventArgs e)
        {
            KT12 cl12 = new KT12();
            cl12.Show();
        }

        private void class11_Click(object sender, EventArgs e)
        {
            Ktmmot cl11 = new Ktmmot();
            cl11.Show();
        }

        private void Dohoa_Click(object sender, EventArgs e)
        {
            Thaukinh tk = new Thaukinh();
            tk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            luyende ld = new luyende();
            ld.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChonThi ct = new ChonThi();
            ct.Show();
        }

    }
}
