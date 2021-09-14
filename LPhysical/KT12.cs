using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LPhysical
{
    public partial class KT12 : Form
    {
        public KT12()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                cmbSession.DataSource = db.TWENTHs.Select(d => d.BAI + " : " + d.NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi! Vui lòng thử lại.\n Nếu quá 3 lần mà không truy cập được thì vui lòng thông cảm \n Đội ngũ DEV sẽ cố gắng sửa lỗi trong thời gian sớm nhất \n Thông tin lỗi: \n"+ex);
            }
        }
        public static string address;
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                string bai = cmbSession.SelectedValue.ToString();

                List<TWENTH> ListSt = new List<TWENTH>();
                var query = from data in db.TWENTHs select data;
                ListSt = query.ToList();
                foreach (var str in ListSt)
                {
                    string dd = str.BAI + " : " + str.NAME;
                    if (bai == dd)
                    {
                        string file = str.CONTENT;
                        string path = Directory.GetCurrentDirectory();

                        address = path + "/AppFile/ktcblop12/" + str.CONTENT;
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
