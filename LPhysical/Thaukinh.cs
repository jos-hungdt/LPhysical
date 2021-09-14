using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LPhysical
{
    public partial class Thaukinh : Form
    {
        public static float saveoa, saveof, saveab;
        public static string oa, of, ab;

        public Thaukinh()
        {
            InitializeComponent();
            if(tk == true) loaitk.Text = "Thấu kính hội tụ";
            
        
        }
        //khai bao bien tinh de su dung trong viec chuyen doi loai thau kính
        //neu tk = true thì là tk hoi tu, còn neu tk = false thi thau kính phan kì
        public static bool tk = true;
        private void Paint(float x1, float y1, float x2, float y2, Color m) // function paint solid
        {
            Graphics dohoa = this.CreateGraphics();
            /*int x1 = 200, y1 = 50;
            int x2 = 400, y2 = 100;*/
            dohoa.DrawLine(new Pen(m, 2), x1, y1, x2, y2);
            
        }
        private void Paints(float x1, float y1, float x2, float y2, Color m) // function paint solid
        {
            Graphics dohoa = this.CreateGraphics();
            dohoa.DrawLine(new Pen(m, 3), x1, y1, x2, y2);
            
        }
        private void Paintss(float x1, float y1, float x2, float y2, Color m) // function paint solid
        {
            Graphics dohoa = this.CreateGraphics();
            dohoa.DrawLine(new Pen(m, 5), x1, y1, x2, y2);

        }
        //nút doi tu tk hoi tu sang phân kì
        private void btn_doitk_Click(object sender, EventArgs e)
        {
            if (tk == true) { tk = false; loaitk.Text = "Thấu kính phân kì"; } else { tk = true; loaitk.Text = "Thấu kính hội tụ"; }

        }
        //nút show ra
        //Tạo các label biểu diễn điểm
        Label lbO = new Label() { Text = "O" };
        Label lbA = new Label() { Text = "A" };
        Label lbB = new Label() { Text = "B" };
        Label lbF = new Label() { Text = "F" };
        Label lbFf = new Label() { Text = "F'" };
        Label lbAa = new Label() { Text = "A'" };
        Label lbBb = new Label() { Text = "B'" };
        //---Kết thúc tạo label
        private void btn_Show_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lbA);
            this.Controls.Remove(lbAa);
            this.Controls.Remove(lbB);
            this.Controls.Remove(lbBb);
            this.Controls.Remove(lbF);
            this.Controls.Remove(lbFf);
            this.Controls.Remove(lbO);
            for (float i = 0; i < 1000; i++)
            {
                Paintss(i, 0, i, 500, Color.White);
            }
            //lay du lieu tu textbox
             oa = tbOA.Text;
             of = tbOF.Text;
             ab = tbAB.Text;
            // kiem tra gia tri nhap vao
            
            if(oa.Length == 0 || of.Length == 0 || ab.Length == 0)
            {
                lbthongtin.ForeColor = Color.Red;
                lbthongtin.Text = "Thông tin : VUI LÒNG NHẬP ĐỦ CÁC SỐ LIỆU\n KHÔNG ĐỂ TRỐNG TRƯỜNG NÀO !";
            }
            else if (ktso(oa) == false || ktso(of) == false || ktso(ab) == false)
            {
                lbthongtin.ForeColor = Color.Red;
                lbthongtin.Text = "Thông tin : VUI LÒNG NHẬP SỐ! ";
            }
            else if (float.Parse(oa) == 0 || float.Parse(of) == 0 || float.Parse(ab) == 0)
            {
                lbthongtin.ForeColor = Color.Red;
                lbthongtin.Text = "Thông tin: CÁC GIÁ TRỊ PHẢI LỚN HƠN 0. VUI LÒNG NHẬP LẠI !";
            }
            //ve do thi thau kinh
            else if (tk == true) // neu la thau kinh hoi tu
            {

                float ofp = float.Parse(of);
                float oap = float.Parse(oa);
                float abp = float.Parse(ab);

                //OA < OF
                if (float.Parse(oa) < float.Parse(of))
                {
                    if (oap > 30 || ofp > 30 || abp > 30)
                    {
                        oap = oap * 2;
                        ofp = ofp * 2;
                    }
                    else
                    {
                        oap = oap * 10;
                        ofp = ofp * 10;
                        abp = abp * 10;
                    }
                    Paint(0, 220, 1000, 220, Color.Black); //ve tia ngang
                    Paints(450, 0, 450, 450, Color.Orange);   //ve guong
                    Paint(455, 10, 450, 0, Color.Orange);
                    Paint(445, 10, 450, 0, Color.Orange);
                    Paint(445, 440, 450, 450, Color.Orange);
                    Paint(455, 440, 450, 450, Color.Orange);
                    //---------------------
                    float a, b, c, d;

                    a = 450 - ofp;
                    b = 450 + ofp;
                    // ve F va F'
                    Paintss(a, 218, a, 221, Color.Red);//F
                    Paintss(b, 218, b, 221, Color.Red);//F'
                    // ve vật
                    d = 450 - oap;
                    c = 220 - abp;
                    Paints(d, 219, d, c, Color.Blue);//AB
                    Paint(d - 1, c, 451, c, Color.Green); //ve tia tu A toi guong      
                    //------------vẽ tia ngược
                    float f, t;
                    f = (((b - d) * (220 - c)) - ((b - 450) * 220) + ((450 - d) * c)) / (900 - (d + b));
                    t = ((450 - d) / (220 - c)) * f + (d - ((450 - d) / (220 - c)) * c);//tọa độ y của giao điểm
                    
                    float p, q;
                    p = 250; //tọa độ điểm qua O
                    q = ((450 - d) / (220 - c)) * 250 + (d - ((450 - d) / (220 - c)) * c);//Tọa độ điểm qua O
                    //----
                    Paint(b, 220, t, f, Color.Green);
                    Paint(q, p, t, f, Color.Green);
                    Paint(450, c, t, f, Color.Yellow);
                    Paint(d, c, t, f, Color.Yellow);
                    //---
                    //vẽ ảnh A'B'
                    Paints(t, f, t, f + 5, Color.Blue);
                    for(int i = 220; i>f+10;i= i - 20)
                    {
                        Paints(t, i, t, i - 10, Color.Blue);
                    }

                    lbthongtin.Text = "Thông tin: + Vật nằm trong tiêu cự của thấu kính \n+ Ảnh ảo \n+ Ảnh nằm trước thấu kính và lớn hơn vật ";
                    //Đặt điểm O
                    this.Controls.Add(lbO);
                    lbO.Height = 15;
                    lbO.Width = 15;
                    lbO.Location = new Point(420, 230);
                    //đặt điểm F
                    int op;
                    op = convert(a);
                    this.Controls.Add(lbF);
                    lbF.Height = 15;
                    lbF.Width = 15;
                    lbF.Location = new Point(op, 230);
                    //Đặt điểm A
                    this.Controls.Add(lbA);
                    int qp;
                    qp = convert(d);
                    lbA.Height = 15;
                    lbA.Width = 15;
                    lbA.Location = new Point(qp, 230);
                    //đặt điểm B
                    int pq = convert(c);
                    pq = pq - 20;
                    this.Controls.Add(lbB);
                    lbB.Height = 15;
                    lbB.Width = 10;
                    lbB.Location = new Point(qp, pq);
                    //vẽ f'
                    int ap;
                    ap = convert(b);
                    ap = ap - 15;
                    this.Controls.Add(lbFf);
                    lbFf.Height = 15;
                    lbFf.Width = 25;
                    lbFf.Location = new Point(ap, 230);
                    int vt;
                    vt = convert(t);
                    this.Controls.Add(lbAa);
                    lbAa.Height = 19;
                    lbAa.Width = 19;
                    lbAa.Location = new Point(vt, 230);
                    //đặt điểm A'
                    int vw;
                    vw = convert(f);
                    vw = vw - 20;
                    vt = vt - 5;
                    this.Controls.Add(lbBb);
                    lbBb.Height = 15;
                    lbBb.Width = 19;
                    lbBb.Location = new Point(vt, vw);
                }
                //OA = OF
                else if (float.Parse(oa) == float.Parse(of))
                {
                    if(oap > 30 || ofp > 30 || abp > 30)
                    {
                        oap = oap * 2;
                        ofp = ofp * 2;
                    }
                    else
                    {
                        oap = oap * 10;
                        ofp = ofp * 10;
                        abp = abp * 10;
                    }
                    Paint(0, 220, 1000, 220, Color.Black); //ve tia ngang
                    Paints(320, 0, 320, 450, Color.Orange);   //ve guong
                    Paint(325, 10, 320, 0, Color.Orange);
                    Paint(315, 10, 320, 0, Color.Orange);
                    Paint(315, 440, 320, 450, Color.Orange);
                    Paint(325, 440, 320, 450, Color.Orange);
                    //---------------------
                    float a, b, c, d;
                    float k, f;

                    a = 320 - ofp;
                    b = 320 + ofp;
                    // ve F va F'
                    Paintss(a, 218, a, 221, Color.Red);//F
                    Paintss(b, 218, b, 221, Color.Red);//F'
                    // ve vật
                    a = 320 - oap;
                    c = 220 - abp;
                    Paints(a, 219, a, c, Color.Blue);//AB
                    Paint(a - 1, c, 321, c, Color.Green); //ve tia tu A toi guong 
                   //vẽ từ B tới gốc O
                    d = c - 50;                    
                    k = ((320 - a) / (220 - c)) * d + (320 - ((320 - a) / (220 - c)) * 220);
                    f = ((320 - a) / (220 - c)) * 300 + (320 - ((320 - a) / (220 - c)) * 220);
                    Paint(k, d, f, 300, Color.Green);

                    //vẽ từ I tới F'
                    float t, p, o;
                    t = c - 50;
                    p = ((320 - b) / (c - 220)) * t + (b - ((320 - b) / (c - 220)) * 220);
                    o = ((320 - b) / (c - 220)) * 250 + (b - ((320 - b) / (c - 220)) * 220);
                    Paint(p, t, o, 250, Color.Green);
                    //-------------
                    lbthongtin.Text = "Thông tin: + Vật nằm trùng với điểm rìa tiêu cự F \n + Ảnh ở Vô cùng";

                    //đặt điểm O
                    this.Controls.Add(lbO);
                    lbO.Height = 15;
                    lbO.Width = 15;
                    lbO.Location = new Point(300, 230);
                    //đặt điểm A và F
                    int op;
                    op = convert(a);
                    op = op - 15;
                    this.Controls.Add(lbA);
                    lbA.Height = 15;
                    lbA.Width = 25;
                    lbA.Location = new Point(op, 230);
                    lbA.Text = "A F";
                    //đặt điểm B
                    int pq = convert(c);
                    this.Controls.Add(lbB);
                    lbB.Height = 15;
                    lbB.Width = 10;
                    lbB.Location = new Point(op, pq);
                    //vẽ f'
                    int ap;
                    ap = convert(b);
                    ap = ap - 15;
                    this.Controls.Add(lbFf);
                    lbFf.Height = 15;
                    lbFf.Width = 25;
                    lbFf.Location = new Point(ap, 230);
                }
                //OA > OF
                else if (float.Parse(oa) > float.Parse(of))
                {

                    if (oap > 30 || ofp > 30 || abp > 30)
                    {
                        oap = oap * 2;
                        ofp = ofp * 2;
                    }
                    else
                    {
                        oap = oap * 10;
                        ofp = ofp * 10;
                        abp = abp * 10;
                    }
                    Paint(0, 220, 1000, 220, Color.Black); //ve tia ngang
                    Paints(320, 0, 320, 450, Color.Orange);   //ve guong
                    Paint(325, 10, 320, 0, Color.Orange);
                    Paint(315, 10, 320, 0, Color.Orange);
                    Paint(315, 440, 320, 450, Color.Orange);
                    Paint(325, 440, 320, 450, Color.Orange);
                    //---------------------
                    float a, b, c, d;

                    a = 320 - ofp;
                    b = 320 + ofp;
                    // ve F va F'
                    Paintss(a, 218, a, 221, Color.Red);//F
                    Paintss(b, 218, b, 221, Color.Red);//F'
                    // ve vật
                    d = 320 - oap;
                    c = 220 - abp;
                    Paints(d, 219, d, c, Color.Blue);//AB
                    Paint(d - 1, c, 321, c, Color.Green); //ve tia tu A toi guong 
                    //------------vẽ  tia qua O vaf F'
                    float f, t;
                    f = ((-(b - 320) * c) + ((320 - d) * 220)) / (640 - b - d);
                    t = ((320 - d) / (220 - c)) * f + (320 - ((320 - d) / (220 - c)) * 220);

                    Paint(d, c, t, f, Color.Green);
                    Paint(320, c, t, f, Color.Green);
                    //------------
                    Paints(t, f, t, 219, Color.Blue);
                    if(oap / ofp == 2)
                    {
                        lbthongtin.Text = "Thông tin : + Vật cách thấu kính một khoảng bằng 2 lần tiêu cự\n + Vật cho ảnh thật \n + Ảnh nằm sau thấu kính và bằng kích thước của vật";
                    }
                    else if(oap / ofp < 2)
                    {
                        lbthongtin.Text = "Thông tin : + Vật nằm ngoài tiêu cự của thấu kính\n + Vật cho ảnh thật \n + Ảnh nằm sau thấu kính và lớn hơn vật";
                    }
                    else
                    {
                        lbthongtin.Text = "Thông tin : + Vật nằm ngoài tiêu cự của thấu kính\n + Vật cho ảnh thật \n + Ảnh nằm sau thấu kính và bé hơn vật";
                    }
                    //đặt điểm O
                    this.Controls.Add(lbO);
                    lbO.Height = 15;
                    lbO.Width = 15;
                    lbO.Location = new Point(300, 230);
                    //đặt điểm F
                    int op;
                    op = convert(a);
                    this.Controls.Add(lbF);
                    lbF.Height = 15;
                    lbF.Width = 15;
                    lbF.Location = new Point(op, 230);
                    //Đặt điểm A
                    this.Controls.Add(lbA);
                    int qp;
                    qp = convert(d);
                    lbA.Height = 15;
                    lbA.Width = 15;
                    lbA.Location = new Point(qp, 230);
                    //đặt điểm B
                    int pq = convert(c);
                    pq = pq - 20;
                    this.Controls.Add(lbB);
                    lbB.Height = 15;
                    lbB.Width = 10;
                    lbB.Location = new Point(qp, pq);
                    //vẽ f'
                    int ap;
                    ap = convert(b);
                    ap = ap - 15;
                    this.Controls.Add(lbFf);
                    lbFf.Height = 15;
                    lbFf.Width = 25;
                    lbFf.Location = new Point(ap, 230);
                    // Vẽ A'
                    int rr = convert(t);
                    this.Controls.Add(lbAa);
                    lbAa.Height = 15;
                    lbAa.Width = 15;
                    lbAa.Location = new Point(rr, 195);
                    // ĐẶt điểm B'
                    int bb = convert(f);
                    this.Controls.Add(lbBb);
                    lbBb.Height = 15;
                    lbBb.Width = 15;
                    lbBb.Location = new Point(rr, bb);
                }
            }
                else if(tk == false) //neu la thau kinh phan ki
                {
                    this.Controls.Remove(lbA);
                    this.Controls.Remove(lbAa);
                    this.Controls.Remove(lbBb);
                    this.Controls.Remove(lbB);
                    this.Controls.Remove(lbF);
                    this.Controls.Remove(lbFf);

                    float ofp = float.Parse(of);
                    float oap = float.Parse(oa);
                    float abp = float.Parse(ab);

                    if (oap > 30 || ofp > 30 || abp > 30)
                    {
                        oap = oap * 2;
                        ofp = ofp * 2;
                        abp = abp * 2;
                    }
                    else
                    {
                        oap = oap * 10;
                        ofp = ofp * 10;
                        abp *= 10;
                    }

                    Paint(0, 220, 1000, 220, Color.Black); //ve tia ngang
                    //vẽ thấu kính phân kì
                    Paints(400, 10, 400, 440, Color.SlateBlue);   
                    Paint(390, 0, 400, 10, Color.SlateBlue);
                    Paint(410, 0, 400, 10, Color.SlateBlue);
                    //
                    Paint(390, 450, 400, 440, Color.SlateBlue);
                    Paint(410, 450, 400, 440, Color.SlateBlue);
                    //---------------------
                    float a, b, c,k;

                    //a = 400 - ofp;
                    k = 400 - ofp;
                    b = 400 + ofp;
                    // ve F va F'
                    Paintss(k, 218, k, 221, Color.Red);//F
                    Paintss(b, 218, b, 221, Color.Red);//F'
                    // ve vật
                    a = 400 - oap;
                    c = 220 - abp;
                    Paints(a, 219, a, c, Color.Tomato);//AB
                    Paint(a - 1, c, 401, c, Color.SpringGreen); //ve tia tu A toi guong 
                    //---- 
                    float d,f;
                    d = c + 200;
                    f = ((400 - a) / (220 - c)) * d + (400 - (((400 - a) * 220) / (220 - c)));
                    Paint(a, c, f, d, Color.SpringGreen);//vẽ từ B qua O
                    float q, p;
                    q = c - 100;
                    p = ((k - 400) / (220 - c)) * q + (400 - ((k - 400) * c) / (220 - c));
                    Paint(k, 220, p, q, Color.SpringGreen);// vẽ từ F qua I
                    Paint(k, 220, 400, c, Color.Yellow);
                    //------------- vẽ ảnh
                    float w, t;
                    w = (((220 - c) * (k - a)) - ((k - 400) * 220) + ((400 - a) * c)) / (800 - a - k);
                    t = ((400 - a) / (220 - c)) * w + (a - ((400 - a) / (220 - c)) * c);
                    Paints(t, w, t, w + 5, Color.Tomato);
                    for (int i = 220; i > w + 10; i = i - 20)
                    {
                        Paints(t, i, t, i - 10, Color.Tomato);
                    }
                    if(oap > ofp)
                    {
                        lbthongtin.Text = "Thông tin: + Vật nằm ngoài tiêu cự \n + Ảnh ảo \n + Ảnh nằm trước thấu kính và bé hơn vật";
                    }
                    else if(oap < ofp)
                    {
                        lbthongtin.Text = "Thông tin: + Vật nằm trong tiêu cự \n + Ảnh ảo \n + Ảnh nằm trước thấu kính và bé hơn vật";
                    }
                    else if(oap == ofp)
                    {
                        lbthongtin.Text = "Thông tin: + Vật nằm trùng điểm rìa tiêu cự F \n + Ảnh ảo \n + Ảnh nằm trước thấu kính và bé hơn vật";
                    }                    
                    this.Controls.Add(lbO);
                    lbO.Height = 19;
                    lbO.Width = 19;
                    lbO.Location = new Point(380,230);
                    //----đặt diểm O
                    int o;
                    o = convert(k);
                    this.Controls.Add(lbF);
                    lbF.Height = 19;
                    lbF.Width = 19;
                    lbF.Location = new Point(o ,230); 
                    //Đặt điểm F
                    int y;
                    y = convert(b);
                    this.Controls.Add(lbFf);
                    lbFf.Height = 19;
                    lbFf.Width = 19;
                    lbFf.Location = new Point(y, 230);
                    //Đặt điểm F'
                    int mn;
                    mn = convert(a);
                    mn = mn - 15;
                    this.Controls.Add(lbA);
                    lbA.Height = 19;
                    lbA.Width = 19;
                    lbA.Location = new Point(mn, 230);
                    //đặt điểm A
                    int ml;
                    ml = convert(c);
                    ml = ml - 20;
                    this.Controls.Add(lbB);
                    lbB.Height = 17;
                    lbB.Width = 17;
                    lbB.Location = new Point(mn, ml);
                    //Đặt điểm B
                    int vt;
                    vt = convert(t);
                    this.Controls.Add(lbAa);
                    lbAa.Height = 19;
                    lbAa.Width = 19;
                    lbAa.Location = new Point(vt, 230);
                    //đặt điểm A'
                    int vw;
                    vw = convert(w);
                    vw = vw - 20;
                    vt = vt - 5;
                    this.Controls.Add(lbBb);
                    lbBb.Height = 15;
                    lbBb.Width = 19;
                    lbBb.Location = new Point(vt, vw);
                }
            }
        
        //button tro lai gia tri truoc 
        private void btn_back_Click(object sender, EventArgs e)
        {
            
            if ((saveab == 0) && (saveoa == 0) && (saveof == 0))
            {
                lbthongtin.Text = "Thông tin : \n   Không có dữ liệu nào được lưu!";
                lbthongtin.ForeColor = Color.Red;
            }
            else
            {
                tbOA.Text = saveoa.ToString();
                tbOF.Text = saveof.ToString();
                tbAB.Text = saveab.ToString();


                btn_Show_Click(sender, e);
            }
            //lb1.Text = "1";
            //lb2.Text = "2";
            //lb3.Text = "3";
            //lb4.Text = "4";
            //lb5.Text = "5";
            //lb6.Text = "6";
            //lb7.Text = "7";
            //lb8.Text = "8";
            //lb9.Text = "9";
            //lb10.Text = "10";
            //lb11.Text = "11";
            //lb12.Text = "12";
            //lb13.Text = "13";
            //lb14.Text = "14";
            //lb15.Text = "15";
            //lb16.Text = "16";
            //lb17.Text = "17";
        }

        //ham kiem tra gia tri nhap vào
        public bool ktso(string q)
        {

            bool kt;
            kt = true;
            char c;
            //kiem tra xem gia tri nhap vao co phai la so khong..
                for (int i = 0; i <= q.Length - 1 ; i++)
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

        //button lưu giá trị trươc đó
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAB.Text != null && tbOA.Text != null && tbOF.Text != null)
                {
                    saveab = float.Parse(tbAB.Text);
                    saveoa = float.Parse(tbOA.Text);
                    saveof = float.Parse(tbOF.Text);
                }
                else
                {
                    saveoa = 0;
                    saveof = 0;
                    saveab = 0;
                }
            }
            catch(Exception)
            {
                lbthongtin.Text = "Lỗi rồi!\n Hãy chắc chắn bạn đã nhập đúng yêu cầu \n Vui lòng thử lại";
            }
        }
        //chú thích
        private void btn_Des_Click(object sender, EventArgs e)
        {
            //Paint(450, 200, 450, 450, Color.Black);
            //Paint(50, 320, 800, 320, Color.Black);

            //Paint(30, 200, 650, 200, Color.Black); //ve duong ngang
            //Paint(350, 80, 350, 300, Color.Orange);  // ve guong

            //Paint(200, 160, 200, 200, Color.Blue); // ve v?t AB
            //Paints(265, 198, 265, 203, Color.Red); // ve F
            //Paints(445, 198, 445, 203, Color.Red);// V? F'

            //Paint(199, 160, 352, 160, Color.Green);//BI
            //Paint(350, 160, 650, 285, Color.Green);//IF'
            //Paint(200, 160, 650, 274, Color.Green);//BO
            //Paint(580, 200, 580, 257, Color.Blue);//V? ?nh A'B'

            
            if(tk == true)
            {
                lbthongtin.Text = "THẤU KÍNH HỘI TỤ \n + Vật và ảnh biểu diễn bằng màu xanh dương\n + Tia tới và tia ló biểu diễn bằng màu xanh sẫm và màu vàng khi ló sau vật\n + Thấu kính biểu diễn bằng màu cam\n + Các điểm F, F' biểu diễm bởi màu đỏ\n + Các tia ngược sau vật biểu diễn màu vàng";
            }
            else
            {
                lbthongtin.Text = "THẤU KÍNH PHÂN KÌ \n + Vật và ảnh biểu diễn bằng màu đỏ\n + Tia tới và tia ló biểu diễn bằng màu xanh sáng và màu vàng khi ló sau thấu kính\n + Thấu kính biểu diễn bằng màu than\n + Các điểm F, F' biểu diễm bởi màu đỏ\n + Các tia ngược sau vật biểu diễn màu vàng";
            }
        }
        //xóa những gì vừa vẽ
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lbA);
            this.Controls.Remove(lbAa);
            this.Controls.Remove(lbB);
            this.Controls.Remove(lbBb);
            this.Controls.Remove(lbF);
            this.Controls.Remove(lbFf);
            this.Controls.Remove(lbO);
            for(float i = 0; i <1000; i++)
            {
                Paintss(i, 0, i, 500, Color.White);
            }
        }
        public int convert(float q)
        {
            string str = q.ToString();
            string kq = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    break;
                }
                else kq = kq + str[i];
            }
            int kqt = int.Parse(kq);
            return kqt;
        }
   }
}

