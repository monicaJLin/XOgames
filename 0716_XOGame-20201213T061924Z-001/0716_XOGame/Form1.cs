using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0716_XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //下棋的動作控制程式
        Boolean T = false;//下棋次序的切換變數
        private void c1_Click_1(object sender, EventArgs e)
        {
            Label c = (Label)sender;
            if (c.Text == "")
            {

                if (T == true)
                {
                    c.Text = "X";
                }
                else
                {
                    c.Text = "O";
                }
                T = !T;
                //呼叫ChkWin
                if (ChkWin() != "") 
                { MessageBox.Show( ChkWin() + "手獲勝!"); }
            }
        }
        //設定共用副程式
        private void Form1_Load(object sender, EventArgs e)
        {
            this.c2.Click += new System.EventHandler(this.c1_Click_1);
            this.c3.Click += new System.EventHandler(this.c1_Click_1);
            this.c4.Click += new System.EventHandler(this.c1_Click_1);
            this.c5.Click += new System.EventHandler(this.c1_Click_1);
            this.c6.Click += new System.EventHandler(this.c1_Click_1);
            this.c7.Click += new System.EventHandler(this.c1_Click_1);
            this.c8.Click += new System.EventHandler(this.c1_Click_1);
            this.c9.Click += new System.EventHandler(this.c1_Click_1);
            button1_Click(sender, e);//清除狀態

        }
        //重玩按鍵
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)//表單上的每一個控制項
            {
                if (x is Label)//如果是標籤物件
                {
                    ((Label)x).Text = "";//清掉文字內容
                }
            }

        }
        //檢查是否連線的副程式
        string ChkWin()
        {
            if (c1.Text + c2.Text + c3.Text == "OOO") { return "O"; }
            if (c4.Text + c5.Text + c6.Text == "OOO") { return "O"; }
            if (c7.Text + c8.Text + c9.Text == "OOO") { return "O"; }
            if (c1.Text + c4.Text + c7.Text == "OOO") { return "O"; }
            if (c2.Text + c5.Text + c8.Text == "OOO") { return "O"; }
            if (c3.Text + c6.Text + c9.Text == "OOO") { return "O"; }
            if (c1.Text + c5.Text + c9.Text == "OOO") { return "O"; }
            if (c3.Text + c5.Text + c7.Text == "OOO") { return "O"; }
            if (c1.Text + c2.Text + c3.Text == "XXX") { return "X"; }
            if (c4.Text + c5.Text + c6.Text == "XXX") { return "X"; }
            if (c7.Text + c8.Text + c9.Text == "XXX") { return "X"; }
            if (c1.Text + c4.Text + c7.Text == "XXX") { return "X"; }
            if (c2.Text + c5.Text + c8.Text == "XXX") { return "X"; }
            if (c3.Text + c6.Text + c9.Text == "XXX") { return "X"; }
            if (c1.Text + c5.Text + c9.Text == "XXX") { return "X"; }
            if (c3.Text + c5.Text + c7.Text == "XXX") { return "X"; }
            return "";///OX都沒有連線,傳回空字串

        }
        //Exit(ESC)
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
