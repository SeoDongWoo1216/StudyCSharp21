﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_03_08_01_FileCopyApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if(Dialog.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Text = Dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소!");
            Environment.Exit(0);
        }

        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);  // 동기 파일 복사
            MessageBox.Show($"{totalCopied} 로 복사했습니다");   // .
        }

        private long CopySync(string sourcePath, string targetPath)
        {
            BtnAsyncCopy.Enabled = false; // 비동기 버튼 비활성화(Enable vs Disable(지금은 이거))
            long totalCopied = 0;         // 전부 복사했는지 확인

            // using을 통해 Close()를 하지않아도 컴파일러가 알아서 클로즈해줌.(stream은 물결이라고 생각)
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))       // 존재하는 파일이니까 Open
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) // 새로 생성하기위해 create
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1024(1KB) * 1024(1KB) ==> 1MB
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0 ) // 1MB씩 파일을 읽고 읽을 파일이 없을때는 0을 반환 => 파일을 다 읽었으면 0이된다
                    {
                        targetStream.Write(buffer, 0, nRead);   // 복사되는 거
                        totalCopied += nRead;

                        // 프로그레스바에 복사상태 진행 표시
                        PrbCopy.Value = (int)(totalCopied / sourceStream.Length) * 100;
                    }
                }
            }
            // copy 끝나면
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }





        // 비동기 복사(async 키워드 추가) : 백그라운드에서 복사(일처리)
        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyASync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied} 로 복사했습니다.", "비동기 복사 완료");
        }

        private async Task<long> CopyASync(string sourcePath, string targetPath)
        {
            BtnSyncCopy.Enabled = false; // 비동기 버튼 비활성화(Enable vs Disable(지금은 이거))
            long totalCopied = 0;         // 전부 복사했는지 확인

            // using을 통해 Close()를 하지않아도 컴파일러가 알아서 클로즈해줌.(stream은 물결이라고 생각)
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))       // 존재하는 파일이니까 Open
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) // 새로 생성하기위해 create
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1024(1KB) * 1024(1KB) ==> 1MB
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0) // 1MB씩 파일을 읽고 읽을 파일이 없을때는 0을 반환 => 파일을 다 읽었으면 0이된다
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead);   // 복사되는 거
                        totalCopied += nRead;

                        // 프로그레스바에 복사상태 진행 표시
                        PrbCopy.Value = (int)(totalCopied / sourceStream.Length) * 100;
                    }
                }
            }
            // copy 끝나면
            BtnSyncCopy.Enabled = true;
            return totalCopied;
        }
    }
}
