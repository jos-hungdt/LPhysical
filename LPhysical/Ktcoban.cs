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
    public partial class Ktcoban : Form
    {
        public Ktcoban()
        {
            InitializeComponent();
            ComboSession();
        }
        private void ComboSession()
        {
            try
            {
                LPhyDataDataContext data = new LPhyDataDataContext();
                cmbSession.DataSource = data.TENBASEs.Select(d => d.BAI + " : " + d.NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi! Vui lòng thử lại.\n Nếu quá 3 lần mà không truy cập được thì vui lòng thông cảm \n Đội ngũ DEV sẽ cố gắng sửa lỗi trong thời gian sớm nhất \n Thông tin lỗi: \n" + ex);
            }
        }
        public static string address;
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                string bai = cmbSession.SelectedValue.ToString();
                List<TENBASE> DsHs = new List<TENBASE>();
                DsHs = (from data in db.TENBASEs select data).ToList();
                foreach (var str in DsHs)
                {
                    string bh = str.BAI + " : " + str.NAME;
                    if (bh == bai)
                    {
                        string path = System.IO.Directory.GetCurrentDirectory();
                        address = path + "/AppFile/ktcblop10/" + str.CONTENT;
                    }
                }
                webBrowserht.Navigate(new Uri(address));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi! Vui lòng thử lại.\n Nếu quá 3 lần mà không truy cập được thì vui lòng thông cảm \n Đội ngũ DEV sẽ cố gắng sửa lỗi trong thời gian sớm nhất \n Thông tin lỗi: \n" + ex);
            }
        }
    }
}
