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
    public partial class Ktmmot : Form
    {
        public Ktmmot()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                cmbSession.DataSource = db.ELEVENs.Select(d => d.BAI + " : " + d.NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi! Vui lòng thử lại.\n Nếu quá 3 lần mà không truy cập được thì vui lòng thông cảm \n Đội ngũ DEV sẽ cố gắng sửa lỗi trong thời gian sớm nhất \n Thông tin lỗi: \n" + ex);
            }
        }
        static string address;
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                string bai = cmbSession.SelectedValue.ToString();

                List<ELEVEN> ktmm = new List<ELEVEN>();
                ktmm = (from data in db.ELEVENs select data).ToList();

                foreach (var st in ktmm)
                {
                    string bh = st.BAI + " : " + st.NAME;
                    if (bh == bai)
                    {
                        string path = System.IO.Directory.GetCurrentDirectory();
                        address = path + "/AppFile/ktcblop11/" + st.CONTENT;
                    }
                }
                wbResult.Navigate(new Uri(address));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi rồi! Vui lòng thử lại.\n Nếu quá 3 lần mà không truy cập được thì vui lòng thông cảm \n Đội ngũ DEV sẽ cố gắng sửa lỗi trong thời gian sớm nhất \n Thông tin lỗi: \n" + ex);
            }
        }
    }
}
