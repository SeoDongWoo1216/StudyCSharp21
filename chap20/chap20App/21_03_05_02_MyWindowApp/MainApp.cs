using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_03_05_02_MyWindowApp
{
    class MainApp : Form
    {

        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += MainApp_MouseClick;
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e)
        {
            var result = $"sender : {sender} \r\n" +        // 메세지 보낸사람
                         $"e: {e}\r\n " +                   // 
                         $"e.X : {e.X}, e.Y : {e.Y}" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";
            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));
        }
    }
}
