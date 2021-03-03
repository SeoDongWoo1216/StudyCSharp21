using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_04_GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\GitRepository\\StudyCSharp21\\SampleDir";   // 폴더/파일 생성 테스트 폴더
            string strTargetDir = "SubFolder";                               // 생성할 폴더명
            string strTargetFile = "readme.txt";                             // 생성할 파일명

            string targetPath = $"{strDir}\\{strTargetDir}";

            if (Directory.Exists(targetPath))   // exists : 폴더가 존재하는지 bool형으로 반환
            {
                Console.WriteLine("이미 폴더가 존재합니다."); 
            }
            else  // 폴더없으면 디렉터리 생성
            {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("폴더 생성 성공!");
            }

            targetPath += $"\\{strTargetFile}";
            if (File.Exists(targetPath))
            {
                Console.WriteLine("이미 파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close();     // 파일을 생성후에 닫아줘야함.
                Console.WriteLine("파일 생성 성공!");
            }
        }
    }
}
