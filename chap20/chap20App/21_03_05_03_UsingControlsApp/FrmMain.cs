using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_03_05_03_UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFonts.Items.Add(font.Name);
            }
        }

        // 콤보박스, 체크박스 값 변경으로 글자체 변경하는 메서드
        private void ChangeFont()
        {
            // SelectedIndex : 콤보박스에서 선택된 값
            if (CboFonts.SelectedIndex < 0)    // 콤보박스에 아무것도 선택안했을때(아무선택안하면 -1 반환) 메서드 탈출
            {
                return;
            }
            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold;     // 00000001 볼드체
            if (ChkItalic.Checked) style |= FontStyle.Italic; // 00000010 이탤릭체
            // 00000001 | 00000010 = 00000011 = Bold + Italic -> 비트 연산에의해 3이되는데 3은 볼드면서 이태릭체이다.

            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 14, style);
            // 텍스트박스의 폰트를 콤보박스에서 선택된 값으로 변경
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrBDisplay.Value = TrbHandle.Value;
        }
    }
}
