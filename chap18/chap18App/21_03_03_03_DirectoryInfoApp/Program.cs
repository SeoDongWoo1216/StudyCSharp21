using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_03_DirectoryInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir; //
            strDir = @"C:\Program Files\Bandizip";  // 폴더 정보 확인 경로

            Console.WriteLine($"{strDir} 디렉토리 정보");
            //var directories = (from dir in Directory.GetDirectories(strDir)
            //                   let info = new DirectoryInfo(dir)  
            //                   select new
            //                   {
            //                       Name = info.Name,
            //                       Attribute = info.Attributes
            //                   }).ToList();
            //foreach (var item in directories)
            //{
            //    Console.WriteLine($"{item.Name},{item.Attribute}");
            //}
            
            var directories = new DirectoryInfo(strDir).GetDirectories();
            foreach (var item in directories)
            {
                Console.WriteLine($"{item.Name},{item.Attributes},{item.Extension}");
            }

            Console.WriteLine($"{strDir} 내 파일 정보");
            var files = new DirectoryInfo(strDir).GetFiles();   // GetFiles(); 로 파일 정보를 불러올 수 있음.
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name} : {item.Attributes} : {(item.Length/1024):#,###}KB : {item.Extension}");
            }
        }
    }
}
