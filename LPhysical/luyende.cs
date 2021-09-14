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

namespace LPhysical
{
    public partial class luyende : Form
    {
        public luyende()
        {
            InitializeComponent();
            List<string> cls = new List<string>();
            cls.Add("Lớp 10");
            cls.Add("Lớp 11");
            cls.Add("Lớp 12");

            cbClas.DataSource = cls;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cbClas.SelectedValue.ToString() == "Lớp 10")
            {
                string path = Directory.GetCurrentDirectory();
                string address = path + "/AppFile/Luyende10/";
                wbRes.Navigate(new Uri(address));
            }
            else if (cbClas.SelectedValue.ToString() == "Lớp 11")
            {
                string path = Directory.GetCurrentDirectory();
                string address = path + "/AppFile/Luyende11/";
                wbRes.Navigate(new Uri(address));
            }
            else
            {
                string path = Directory.GetCurrentDirectory();
                string address = path + "/AppFile/Luyende12/";
                wbRes.Navigate(new Uri(address));
            }
        }

        private void luyende_Load(object sender, EventArgs e)
        {

        }
    }
}
