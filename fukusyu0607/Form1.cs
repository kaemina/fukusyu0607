using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{    
   
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシードを指定して初期化したら
        //それを使い続ける
        private static Random rand = new Random();
        int vx = rand.Next(-10 ,11);
        int vy = rand.Next(-10,11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);
        int vx4 = rand.Next(-10, 11);
        int vy4= rand.Next(-10, 11);
        int time = 100 * 5;

        public Form1()
        {
            InitializeComponent();
            //以下に、label1.Leftとlabel1.Topの座標をランダムで求めよ
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
       
        
        {
            label1.Left += vx;
            label1.Top += vy;

            //マウスと重なったときタイマーを止める
            Point p = PointToClient(MousePosition);

            if(   (p.X>=label1.Left)
                &&(p.X<label1.Right)
                &&(p.Y>=label1.Top)
                &&(p.Y< label1.Bottom)
                )
            {
                Left--;
                label1.Visible = false;
                timer1.Enabled=false;
            }
                if (label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top<0)
            {
                vy = Math.Abs(vy);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if(label1.Right>ClientSize.Width)
            {
              vx = -Math.Abs(vx) ;
            }
            if(label1.Bottom>ClientSize.Height)
            {
               vy = -Math.Abs(vx) ;
            }
            //
            label2.Left += vx3;
            label2.Top += vy3;

            //マウスと重なったときタイマーを止める
           

            if ((p.X >= label2.Left)
                && (p.X < label2.Right)
                && (p.Y >= label2.Top)
                && (p.Y < label2.Bottom)
                )
            {
                timer1.Enabled = false;
            }
            if (label2.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            if (label2.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if (label2.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vx3);
            }
            //
            label3.Left += vx4;
            label3.Top += vy4;

            //マウスと重なったときタイマーを止める


            if ((p.X >= label3.Left)
                && (p.X < label3.Right)
                && (p.Y >= label3.Top)
                && (p.Y < label3.Bottom)
                )
            {
                timer1.Enabled = false;
            }
            if (label3.Left < 0)
            {
                vx4 = Math.Abs(vx4);
            }
            if (label3.Top < 0)
            {
                vy4 = Math.Abs(vy4);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if (label3.Right > ClientSize.Width)
            {
                vx4 = -Math.Abs(vx4);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy4 = -Math.Abs(vx4);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
