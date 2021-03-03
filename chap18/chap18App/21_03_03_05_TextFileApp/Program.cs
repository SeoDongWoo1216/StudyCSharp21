using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_05_TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\GitRepository\StudyCSharp21\SampleDir\SubFolder\a.dat";  // 텍스트 파일 생성위치

            StreamWriter sw = null;

            try
            {
                //sw = new StreamWriter(new FileStream(filepath, FileMode.OpenOrCreate)); //  FileMode.Append로하면 기존의 파일에서 계속 추가됨
                sw = new StreamWriter(new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write));
                sw.WriteLine($"int.MaxValue    = {int.MaxValue}");
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"uint.MaxValue   = {uint.MaxValue}");
                sw.WriteLine("안녕하세요");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일 생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외 발생 : {ex.Message}");
            }
            finally
            {
                sw.Close();  // Close() 안하면 에러가 남.
            }

            StreamReader sr = null;
            //sr = new StreamReader(new FileStream(filepath, FileMode.Open));
            sr = new StreamReader(new FileStream(filepath, FileMode.Open, FileAccess.Read));
            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

            while (sr.EndOfStream == false)  // 제일 마지막값까지 아닐동안 sr 읽기
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            

        }
    }
}
