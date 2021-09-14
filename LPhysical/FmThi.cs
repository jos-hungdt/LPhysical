using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPhysical
{
    public partial class FmThi : Form
    {
        public FmThi()
        {
            InitializeComponent();
        }
        //khai bao bien dung chung cho ca chuc nang nay
        static string getName = " ";
        static string getClass = " ";
        static string getNum = " ";
        static int dem = 0;


        public static int[] mangQC = new int[60];
        public static string[] mangRE = new string[60];
        public static int[] mangTT = new int[60];
        //khai báo phương thức để lấy dữ liệu từ Form ChonThi
        public FmThi(string layName, string layLop, string laysch)
            : this()
        {
            getName = layName;
            getClass = layLop;
            getNum = laysch;
        }
        private void FmThi_Load(object sender, EventArgs e)
        {
            dem = 0;
            //gan gtri cho cac label
            lbName.Text = getName;
            lbLop.Text = getClass;
            //tao mang ma cau hoi
            int sch = int.Parse(getNum);

            if (getClass == "Lớp 10")
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                List<DERAL10> listdr = new List<DERAL10>();
                var query = from data in db.DERAL10s select data;
                listdr = query.ToList();
                int k = 0;
                int sc = int.Parse(getNum);
                foreach (var str in listdr)
                {
                    if (str.QID > 0)
                    {
                        k++;
                    }
                }
                Random rd = new Random();
                int j;
                for (int i = 0; i <= sc; i++)
                {
                    j = rd.Next(1, k - 1);
                    if (j == 0) j = j + 1;
                    mangQC[i] = j;
                }

                foreach (var str in listdr)
                {
                    if (str.QID == mangQC[0])
                    {
                        tbConQues.Text = str.CONTENT;
                        j = rd.Next(1, 4);
                        if (j == 0) j = j + 1;
                        mangTT[0] = j;
                        if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                        else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                        else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                        else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                    }
                }
                lbcau.Text = "- Câu 1 -";
            }//dấu if lớp 10
            else if (getClass == "Lớp 11")
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                List<DERAL11> listdr = new List<DERAL11>();
                var query = from data in db.DERAL11s select data;
                listdr = query.ToList();
                int k = 0;
                int sc = int.Parse(getNum);
                foreach (var str in listdr)
                {
                    if (str.QID > 0)
                    {
                        k++;
                    }
                }
                Random rd = new Random();
                int j;
                for (int i = 0; i <= sc; i++)
                {
                    j = rd.Next(1, k - 1);
                    if (j == 0) j = j + 1;
                    mangQC[i] = j;
                }

                foreach (var str in listdr)
                {
                    if (str.QID == mangQC[0])
                    {
                        tbConQues.Text = str.CONTENT;
                        j = rd.Next(1, 4);
                        if (j == 0) j = j + 1;
                        mangTT[0] = j;
                        if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                        else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                        else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                        else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                    }
                }
                lbcau.Text = "- Câu 1 -";
            }// dấu của else if
            else
            {
                LPhyDataDataContext db = new LPhyDataDataContext();
                List<DERAL12> listdr = new List<DERAL12>();
                var query = from data in db.DERAL12s select data;
                listdr = query.ToList();
                int k = 0;
                int sc = int.Parse(getNum);
                foreach (var str in listdr)
                {
                    if (str.QID > 0)
                    {
                        k++;
                    }
                }
                Random rd = new Random();
                int j;
                for (int i = 0; i <= sc; i++)
                {
                    j = rd.Next(1, k - 1);
                    mangQC[i] = j;
                }

                foreach (var str in listdr)
                {
                    if (str.QID == mangQC[0])
                    {
                        tbConQues.Text = str.CONTENT;
                        j = rd.Next(1, 4);
                        if (j == 0) j = j + 1;
                        mangTT[0] = j;
                        if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                        else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                        else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                        else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                    }
                }
                lbcau.Text= "- Câu 1 -";
            }// dấu của else
            gettime = int.Parse(getNum);
            gettime = gettime * 1;
            timer1.Start();

            if ((gettime < 1) && (pt < 1))
            {
                btn_Nopbai_Click(sender, e);
            }
        }
        //kết thúc phần load mở đầu
        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                int sch = int.Parse(getNum); // lấy số câu hỏi
                //nếu bạn là học sinh lớp 10
                if (getClass == "Lớp 10")
                {
                    dem = dem + 1;
                    if (dem >= sch)
                    {
                        foreach (RadioButton rdii in pnlCheck.Controls)
                        {
                            if (rdii.Checked)
                            {
                                mangRE[dem - 1] = rdii.Text;
                                rdii.Checked = false;
                                break;
                            }
                            else
                            {
                                mangRE[dem - 1] = "Empty";
                            }
                        }
                        MessageBox.Show("Đây là câu cuối cùng");
                    }
                    else
                    {
                        if (dapanA.Checked == true)
                        {
                            mangRE[dem - 1] = dapanA.Text;
                            dapanA.Checked = false;
                        }
                        else if (dapanB.Checked == true)
                        {
                            mangRE[dem - 1] = dapanB.Text;
                            dapanB.Checked = false;
                        }
                        else if (dapanC.Checked == true)
                        {
                            mangRE[dem - 1] = dapanC.Text;
                            dapanC.Checked = false;
                        }
                        else if (dapanD.Checked == true)
                        {
                            mangRE[dem - 1] = dapanD.Text;
                            dapanD.Checked = false;
                        }
                        //phần này là phần gán câu hỏi và các đáp án 
                        lbcau.Text = "- Câu " + (dem + 1).ToString() + " -";
                        LPhyDataDataContext db = new LPhyDataDataContext();
                        List<DERAL10> listdr = new List<DERAL10>();
                        var query = from data in db.DERAL10s select data;
                        listdr = query.ToList();
                        Random rd = new Random();
                        int j;
                        foreach (var str in listdr)
                        {
                            if (str.QID == mangQC[dem])
                            {
                                tbConQues.Text = str.CONTENT;
                                j = rd.Next(1, 4);
                                if (j == 0) j = j + 1;
                                mangTT[dem] = j;
                                if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                                else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                                else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                                else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                            }
                        }
                        //kết thúc phần gán câu hỏi 
                    }

                }
                //nếu bạn là học sinh 11
                else if (getClass == "Lớp 11")
                {
                    dem = dem + 1;
                    if (dem >= sch)
                    {
                        foreach (RadioButton rdii in pnlCheck.Controls)
                        {
                            if (rdii.Checked)
                            {
                                mangRE[dem - 1] = rdii.Text;
                                rdii.Checked = false;
                                break;
                            }
                            else
                            {
                                mangRE[dem - 1] = "Empty";
                            }
                        }
                        MessageBox.Show("Đây là câu cuối cùng");
                    }
                    else
                    {
                        if (dapanA.Checked == true)
                        {
                            mangRE[dem - 1] = dapanA.Text;
                            dapanA.Checked = false;
                        }
                        else if (dapanB.Checked == true)
                        {
                            mangRE[dem - 1] = dapanB.Text;
                            dapanB.Checked = false;
                        }
                        else if (dapanC.Checked == true)
                        {
                            mangRE[dem - 1] = dapanC.Text;
                            dapanC.Checked = false;
                        }
                        else if (dapanD.Checked == true)
                        {
                            mangRE[dem - 1] = dapanD.Text;
                            dapanD.Checked = false;
                        }
                        //phần này là phần gán câu hỏi và các đáp án 
                        lbcau.Text = "- Câu " + (dem + 1).ToString() + " -";
                        LPhyDataDataContext db = new LPhyDataDataContext();
                        List<DERAL11> listdr = new List<DERAL11>();
                        var query = from data in db.DERAL11s select data;
                        listdr = query.ToList();
                        Random rd = new Random();
                        int j;
                        foreach (var str in listdr)
                        {
                            if (str.QID == mangQC[dem])
                            {
                                tbConQues.Text = str.CONTENT;
                                j = rd.Next(1, 4);
                                if (j == 0) j = j + 1;
                                mangTT[dem] = j;
                                if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                                else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                                else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                                else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                            }
                        }
                        //kết thúc phần gán câu hỏi 
                    }

                }
                //nếu bạn là học sinh 12
                else
                {
                    dem = dem + 1;
                    if (dem >= sch)
                    {
                        foreach (RadioButton rdii in pnlCheck.Controls)
                        {
                            if (rdii.Checked)
                            {
                                mangRE[dem - 1] = rdii.Text;
                                rdii.Checked = false;
                                break;
                            }
                            else
                            {
                                mangRE[dem - 1] = "Empty";
                            }
                        }
                        MessageBox.Show("Đây là câu cuối cùng");
                    }
                    else
                    {
                        if (dapanA.Checked == true)
                        {
                            mangRE[dem - 1] = dapanA.Text;
                            dapanA.Checked = false;
                        }
                        else if (dapanB.Checked == true)
                        {
                            mangRE[dem - 1] = dapanB.Text;
                            dapanB.Checked = false;
                        }
                        else if (dapanC.Checked == true)
                        {
                            mangRE[dem - 1] = dapanC.Text;
                            dapanC.Checked = false;
                        }
                        else if (dapanD.Checked == true)
                        {
                            mangRE[dem - 1] = dapanD.Text;
                            dapanD.Checked = false;
                        }
                        //phần này là phần gán câu hỏi và các đáp án 
                        lbcau.Text = "- Câu " + (dem + 1).ToString() + " -";
                        LPhyDataDataContext db = new LPhyDataDataContext();
                        List<DERAL12> listdr = new List<DERAL12>();
                        var query = from data in db.DERAL12s select data;
                        listdr = query.ToList();
                        Random rd = new Random();
                        int j;
                        foreach (var str in listdr)
                        {
                            if (str.QID == mangQC[dem])
                            {
                                tbConQues.Text = str.CONTENT;
                                j = rd.Next(1, 4);
                                if (j == 0) j = j + 1;
                                mangTT[dem] = j;
                                if (j == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
                                else if (j == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
                                else if (j == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
                                else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }
                            }
                        }
                        //kết thúc phần gán câu hỏi 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex);
            }
        }
        //phần tính và đưa ra điểm số đạt được
        private void btn_Nopbai_Click(object sender, EventArgs e)
        {
            LPhyDataDataContext db = new LPhyDataDataContext();
            if (getClass == "Lớp 10")
            {
                int sch = int.Parse(getNum);
                int point = 0;
                List<DERAL10> listdr = new List<DERAL10>();
                var query = from data in db.DERAL10s select data;
                listdr = query.ToList();
                for (int j = 0; j < sch; j++)
                {
                    foreach (var str in listdr)
                    {
                        if (str.QID == mangQC[j])
                        {
                            if (str.CTLDUNG == mangRE[j])
                            {
                                point = point + 10;
                            }
                        }
                    }
                }
                if (point == sch * 10)
                {
                    MessageBox.Show("Chúc mừng bạn đã đạt điểm tối đa. Bạn thật giỏi! :))" + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else if (point == 0)
                {
                    MessageBox.Show("Rất tiếc bạn không được điểm nào. \n Cố gắng hơn nữa nhé Fighting!!!");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else
                {
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành bài thi. \n Bạn đạt " + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
            }
            else if (getClass == "Lớp 11")
            {
                int sch = int.Parse(getNum);
                int point = 0;
                List<DERAL11> listdr = new List<DERAL11>();
                var query = from data in db.DERAL11s select data;
                listdr = query.ToList();
                for (int j = 0; j < sch; j++)
                {
                    foreach (var str in listdr)
                    {
                        if (str.QID == mangQC[j])
                        {
                            if (str.CTLDUNG == mangRE[j])
                            {
                                point = point + 10;
                            }
                        }
                    }
                }
                if (point == sch * 10)
                {
                    MessageBox.Show("Chúc mừng bạn đã đạt điểm tối đa. Bạn thật giỏi! :))" + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else if (point == 0)
                {
                    MessageBox.Show("Rất tiếc bạn không được điểm nào. \n Cố gắng hơn nữa nhé Fighting!!!");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else
                {
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành bài thi. \n Bạn đạt " + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
            }
            else
            {
                int sch = int.Parse(getNum);
                int point = 0;
                List<DERAL12> listdr = new List<DERAL12>();
                var query = from data in db.DERAL12s select data;
                listdr = query.ToList();
                for (int j = 0; j < sch; j++)
                {
                    foreach (var str in listdr)
                    {
                        if (str.QID == mangQC[j])
                        {
                            if (str.CTLDUNG == mangRE[j])
                            {
                                point = point + 10;
                            }
                        }
                    }
                }
                if (point == sch * 10)
                {
                    MessageBox.Show("Chúc mừng bạn đã đạt điểm tối đa. Bạn thật giỏi! :))" + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else if (point == 0)
                {
                    MessageBox.Show("Rất tiếc bạn không được điểm nào. \n Cố gắng hơn nữa nhé Fighting!!!");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
                else
                {
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành bài thi. \n Bạn đạt " + point.ToString() + " điểm");
                    this.Close();
                    BeginPage gn = new BeginPage();
                    gn.Show();
                }
            }
        }

        static int gettime;
        static int pt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pt < 1 && gettime < 1)
            {
                timer1.Stop();
                btn_Nopbai_Click(sender, e);
            }
            else
            {
                if (pt < 1)
                {
                    pt = 60;
                    gettime = gettime - 1;
                    if (gettime < 10) lbphut.Text = "0" + gettime.ToString();
                    else lbphut.Text = gettime.ToString();
                }
                pt--;
                if (pt < 10) lbgiay.Text = "0" + pt.ToString();
                else lbgiay.Text = pt.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
                gettime = gettime - 1;
                if (gettime < 10) lbphut.Text = "0" + gettime.ToString();
                else lbphut.Text = gettime.ToString();
            
        }

        //kết thúc phần tính điểm
        //private void btn_Back_Click(object sender, EventArgs e)
        //{           
        //    try
        //    {
        //        int sch = int.Parse(getNum);    
        //        LPhyDataDataContext db = new LPhyDataDataContext();
        //        if(dem < 1)
        //        {
        //            MessageBox.Show("Can't Back");
        //        }
        //        else
        //        {
        //            if (dem > sch) dem = sch;
        //            dem = dem - 1;
        //            lbcau.Text = "-Câu " + dem.ToString() + " -";
        //            if(getClass == "Lớp 10")
        //            {

        //            }
        //            else if(getClass == "Lớp 11")
        //            {

        //            }
        //            else
        //            {
        //                List<DERAL12> listdr = new List<DERAL12>();
        //                var query = db.DERAL12s.Select(d => d);
        //                listdr = query.ToList();
        //                foreach(var str in listdr)
        //                {
        //                    if(str.QID == mangQC[dem - 1])
        //                    {
        //                        tbConQues.Text = str.CONTENT;
        //                        if (mangTT[dem-1] == 1) { dapanA.Text = str.CTLDUNG; dapanB.Text = str.CTL3; dapanC.Text = str.CTL1; dapanD.Text = str.CTL2; }
        //                        else if (mangTT[dem - 1] == 2) { dapanA.Text = str.CTL2; dapanB.Text = str.CTLDUNG; dapanC.Text = str.CTL1; dapanD.Text = str.CTL3; }
        //                        else if (mangTT[dem - 1] == 3) { dapanA.Text = str.CTL1; dapanB.Text = str.CTL3; dapanC.Text = str.CTLDUNG; dapanD.Text = str.CTL2; }
        //                        else { dapanA.Text = str.CTL3; dapanB.Text = str.CTL2; dapanC.Text = str.CTL1; dapanD.Text = str.CTLDUNG; }                       
        //                    }
        //                    if(dapanA.Text == mangRE[dem-1])
        //                    {
        //                        dapanA.Checked = true;
        //                        break;
        //                    }
        //                    else if(dapanB.Text == mangRE[dem-1])
        //                    {
        //                        dapanB.Checked = true;
        //                        break;
        //                    }
        //                    else if(dapanC.Text == mangRE[dem - 1])
        //                    {
        //                        dapanC.Checked = true;
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        dapanD.Checked = true;
        //                        break;
        //                    }
        //                }
        //            }
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: \n" + ex);
        //    }
    }
}

