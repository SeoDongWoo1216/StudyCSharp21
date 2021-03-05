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

namespace _21_03_05_04_ProgressTestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "시작!!!";
            label1.Update();

            Thread th = new Thread(() => {
                for (int i = 0; i <= 100; i++)
                {
                    label2.Text = i.ToString();
                    label2.Update();
                    
                    progressBar1.Value = i;
                    Thread.Sleep(10);
                }
                label1.Text = "종료";
                label1.Update();
            });
            th.IsBackground = true;
            th.Start();
            
            

        }
    }
}
