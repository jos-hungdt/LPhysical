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
    public partial class FmConlac : Form
    {
        public FmConlac()
        {
            InitializeComponent();
        }
        private void Paint(float y1, float x1, float y2, float x2, Color color)
        {
            Graphics pline = this.CreateGraphics();
            pline.DrawLine(new Pen(color, 2), y1, x1, y2, x2);
        }
        private void Paints(float y1, float x1, float y2, float x2, Color color)
        {
            Graphics pline = this.CreateGraphics();
            pline.DrawLine(new Pen(color, 5), y1, x1, y2, x2);
        }
        private void Elips(float x, float y, float width, float height, Color color)
        {
            Graphics draw = this.CreateGraphics();
            draw.DrawEllipse(new Pen(color, 2), x, y, width, height);
        }
        int i = 1;
        static float tl;
        static float vk;
        static float l;


        private void button3_Click(object sender, EventArgs e)
        {
            if ((l >= 1) && (l < 7)) tl = l * 50 + 20;
            else if ((l >= 7) && (l <= 35)) tl = l * 10 + 20;
            else tl = l + 20;

            if ((tl > 100) && (tl < 180)) vk = 150;
            else if ((tl >= 180) && (tl < 230)) vk = 80;
            else if (tl <= 100) vk = 230;
            else vk = 10;

            double gk = tl * Math.Sin(Math.PI * 30 / 180);
            float ck = lamtron(gk);
            double lk = tl * Math.Cos(Math.PI * 30 / 180);
            float nt = lamtron(lk);
            while (i == 2)
            {

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string getl = tbL.Text;
            l = float.Parse(getl);

            //if (l < 5) tl = l * 80 + 20;
            if ((l >= 1) && (l < 7)) tl = l * 50 + 20;
            else if ((l >= 7) && (l <= 35)) tl = l * 10 + 20;
            else tl = l + 20;

            if ((tl > 100) && (tl < 180)) vk = 150;
            else if ((tl >= 180) && (tl < 230)) vk = 80;
            else if (tl <= 100) vk = 230;
            else vk = 10;
            //vẽ cung con lắc
            Elips(vk, -(tl - 20), tl * 2, tl * 2, Color.Yellow);
            //xóa phần trên
            for (double xx = tl * Math.Cos(Math.PI * 30 / 180); xx > 0; xx--)
            {
                float kk = lamtron(xx);
                Paint(0, kk, 1000, kk, Color.White);
            }

            // vẽ dây và vật nặng
            Paint(vk + tl, 20, vk + tl, tl + 10, Color.Red);
            Elips(vk + tl - 10, tl + 10, 20, 20, Color.Green);

            //vẽ ảnh
            double gk = tl * Math.Sin(Math.PI * 30 / 180);
            float ck = lamtron(gk);
            double lk = tl * Math.Cos(Math.PI * 30 / 180);
            float nt = lamtron(lk);
            //vẽ bên trái
            Paint(vk + tl, 20, vk + tl - ck - 20, nt, Color.Yellow);
            Elips(vk + tl - ck - 35, nt - 5, 20, 20, Color.Yellow);
            //vẽ bên phải
            Paint(vk + tl, 20, vk + tl + ck + 20, nt, Color.Yellow);
            Elips(vk + tl + ck + 17, nt - 5, 20, 20, Color.Yellow);
            //kt phần vẽ ảnh
            Paints(vk + tl - 20, 18, vk + tl + 20, 18, Color.Brown);
        }
        private void btnAtc_Click(object sender, EventArgs e)
        {
            string getl = tbL.Text;
            l = float.Parse(getl);

            //if (l < 5) tl = l * 80 + 20;
            if ((l >= 1) && (l < 7)) tl = l * 50 + 20;
            else if ((l >= 7) && (l <= 35)) tl = l * 10 + 20;
            else tl = l + 20;

            if ((tl > 100) && (tl < 180)) vk = 150;
            else if ((tl >= 180) && (tl < 230)) vk = 80;
            else if (tl <= 100) vk = 230;
            else vk = 10;
            //vẽ cung con lắc
            Elips(vk, -(tl - 20), tl * 2, tl * 2, Color.Yellow);
            //xóa phần trên
            for (double xx = tl * Math.Cos(Math.PI * 30 / 180); xx > 0; xx--)
            {
                float kk = lamtron(xx);
                Paint(0, kk, 1000, kk, Color.White);
            }

            Paints(vk + tl - 20, 18, vk + tl + 20, 18, Color.Brown);
            // vẽ dây và vật nặng
            Paint(vk + tl, 20, vk + tl, tl + 10, Color.Red);
            Elips(vk + tl - 10, tl + 10, 20, 20, Color.Green);

            //vẽ ảnh
            double gk = tl * Math.Sin(Math.PI * 30 / 180);
            float ck = lamtron(gk);
            double lk = tl * Math.Cos(Math.PI * 30 / 180);
            float nt = lamtron(lk);
            //vẽ bên trái
            Paint(vk + tl, 20, vk + tl - ck - 20, nt, Color.Yellow);
            Elips(vk + tl - ck - 35, nt - 5, 20, 20, Color.Yellow);
            //vẽ bên phải
            Paint(vk + tl, 20, vk + tl + ck + 20, nt, Color.Red);
            Elips(vk + tl + ck + 17, nt - 5, 20, 20, Color.Green);
            //kt phần vẽ ảnh
            //vẽ phần bên phải
            Paint(vk + tl, 20, vk + tl + ck - 14, nt + 18, Color.Red);
            Elips(vk + tl + ck - 17, nt + 15, 20, 20, Color.Green);
            //--
            Paint(vk + tl, 20, vk + tl + ck - 50, nt + 35, Color.Red);
            Elips(vk + tl + ck - 55, nt + 35, 20, 20, Color.Green);
            //--
            Paint(vk + tl, 20, vk + tl + ck - 87, nt + 47, Color.Red);
            Elips(vk + tl + ck - 94, nt + 46, 20, 20, Color.Green);

        }
        public float lamtron(double k)
        {
            string str = k.ToString();
            str = str + ".";
            string tv = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == ".")
                {
                    for (int j = 0; j < i; j++)
                        tv = tv + str[j];
                    break;
                }
            }
            float tvv = float.Parse(tv);
            return tvv;
        }


    }
}




















