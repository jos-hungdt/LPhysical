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
    public partial class ChonThi : Form
    {
        public ChonThi()
        {
            InitializeComponent();
            SetValue();
        }
        public void SetValue()
        {
            List<string> data = new List<string>();
            data.Add("Lớp 10");
            data.Add("Lớp 11");
            data.Add("Lớp 12");

            Cbclass.DataSource = data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static int t;

        public static string getValue;
        private void vaothi_Click(object sender, EventArgs e)
        {
            
            lbn.Text = "";
            lbch.Text = "";
            string name = tbname.Text;
            string soc = tbsocauhoi.Text;
            string lop = Cbclass.SelectedValue.ToString();
            if (name.Length == 0 || soc.Length == 0)
            {
                if (name.Length == 0)
                {
                    lbn.Text = "Không để trống trường này";
                }
                if (soc.Length == 0)
                {
                    lbch.Text = "Trường này là bắt buộc";
                }
            }
            else if(ktso(soc) == false)
            {
                lbch.Text = "Bạn phải nhập số";
            }
            else if(int.Parse(soc) < 1 || int.Parse(soc) >50)
            {
                lbch.Text = "Phải nhập số từ 1 đến 50";
            }
            else
            {
                List<Giatri> values = new List<Giatri>();
                values.Add(new Giatri { Name = name, lop = lop, socau = soc });
                string _lop = Cbclass.SelectedValue.ToString();
                string _socah = tbsocauhoi.Text;
                foreach(var k in values)
                {
                     t = int.Parse(k.socau);
                }
                t = t * 5;

                getValue = tbname.Text;
                MessageBox.Show("THÔNG TIN BÀI THI VÀ MỘT SỐ LƯU Ý \n1. Bài thi gồm " + soc + " câu. Mỗi câu sẽ có bốn đáp án A, B, C, D cho bạn lựa chọn\n2. Mỗi câu trả lời đúng sẽ được tính 2 điểm \n3. Thời gian thi là: "+ t +" giây \n4. Muốn nộp bài thi thì hãy nhấn vào nút NỘP BÀI \n5. Khi bạn nhấn OK thì thời gian bắt đầu tính");
                FmThi thi = new FmThi(getValue,_lop,_socah);
                thi.Show();
                this.Close();
            }
        }
        public bool ktso(string q)
        {

            bool kt;
            kt = true;
            char c;
            //kiem tra xem gia tri nhap vao co phai la so khong..
            for (int i = 0; i <= q.Length - 1; i++)
            {
                c = '0';
                while (c <= '9' && q[i] != c)
                {
                    c++;
                }
                if (c > '9')
                {
                    kt = false;
                }
            }

            return kt;
        }
    }
    public class Giatri
    {
        public string Name { get; set; }
        public string lop { get; set; }
        public string socau { get; set; }
    }
}
