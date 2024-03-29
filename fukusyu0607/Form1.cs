﻿using System;
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
       int time = 100 * 5;
        int left=3;


        int[] velx = new int[3];
        int[] vely = new int[3];

        public Form1()
        {
            InitializeComponent();

            for (int i=0;i<3;i++)
            {
                velx[i] = rand.Next(-10, 11);
                vely[i] = rand.Next(-10, 11);
            }
           

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
            label1.Left += velx[0];
            label1.Top +=vely[0];

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
                velx[0] = Math.Abs(velx[0]);
            }
            if (label1.Top<0)
            {
                vely[0] = Math.Abs(vely[0]);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if(label1.Right>ClientSize.Width)
            {
                velx[0] = -Math.Abs(velx[0]);
            }
            if(label1.Bottom>ClientSize.Height)
            {
                vely[0] = -Math.Abs(vely[0]);
            }
            //
            label2.Left += velx[1];
            label2.Top += vely[1];

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
                velx[1] = Math.Abs(velx[1]);
            }
            if (label2.Top < 0)
            {
                 vely[1] = Math.Abs( vely[1]);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if (label2.Right > ClientSize.Width)
            {
                velx[1] = -Math.Abs(velx[1]);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vely[1] = -Math.Abs(vely[1]);
            }
            //
            label3.Left += velx[2];
            label3.Top += vely[2];

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
                velx[2] = Math.Abs( velx[2]);
            }
            if (label3.Top < 0)
            {
               vely[2]  = Math.Abs( vely[2]);
            }
            //フォームの右端＝ClientSize.Width
            //ラベルの右端＝label1.Right            
            if (label3.Right > ClientSize.Width)
            {
                velx[2] = -Math.Abs(velx[2]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vely[2]= -Math.Abs( vely[2]);
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
