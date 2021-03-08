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
        Random random = new Random(37);
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러 영역
        private void Form1_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");


            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFonts.Items.Add(font.Name);
            }
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

        private void BtnModal_Click(object sender, EventArgs e)
        {
            // 모달 : 모달창을 띄운상태에서 다른 창에 포커스가 가지않음
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Coral;
            frm.ShowDialog();  // 모달창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            // 모달리스 : 모달창을 띄운상태에서 다른 창에 포커스 가능
            Form frm = new Form
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.Show();  // 모달리스창 띄우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 모달창이 메세지박스 : 사용자에게 메세지를 보여주는 창 => 제일 많이 씀
            MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // 텍스트박스의 문자열을 메세지박스에 출력

            //OK 버튼 눌렀을때 메세지박스 출력
            //if (MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    MessageBox.Show("저장되었습니다");
            //}
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   // 이벤트 핸들러를 return을 통해 빠져나가야함.
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();

            DisplayTreeToList();
        }

        #endregion


        #region 사용자메서드 영역

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

        // 트리뷰 내용 리스트뷰에 표시
        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)  // 메서드 오버로딩
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath }));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);  // 재귀호출(자기자신을 스스로 부르는것)
            } 

        }

        #endregion





    }
}
