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

namespace Text2Gif
{
    public partial class Form1 : Form
    {
        string text = "Всем привет, в детстве, я ставил много софта, и родители обрезали мне возможность его ставить, убрали у меня админские права. И только сейчас, в 15, я нашёл выход." +
            " Итак, с вами снова Тёмный! И в этом видео я покажу как в 99% удачно установить ЛЮБУЮ ПРОГРАММУ на ваш ПК БЕЗ прав администратора.";
        public Form1()
        {
            InitializeComponent();
        }

        int tPos = 0;       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tPos <= text.Length)
            {
                textlabel.Text = text.Substring(0, tPos++);
            }
            else
                tPos = 0;
                
            if(textlabel.Text.Length == text.Length)
            {
                timer1.Stop();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            text = guna2TextBox1.Text;
            timer1.Start();
            //char[] b = text.ToCharArray();
            //foreach (char x in b)
            //{
            //    Thread.Sleep(10);
            //        textlabel.Text += x.ToString();               
               
            //}
            
        }
    }
}
