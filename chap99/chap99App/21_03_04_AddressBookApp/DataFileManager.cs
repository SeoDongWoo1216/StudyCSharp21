using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_04_AddressBookApp
{
    class DataFileManager
    {
        // 텍스트 파일에서 저장된 주소록을 불러온다(파일로드)
        const string dataFileName = "address.dat";  // 파일명

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;  // 만들 데이터파일 위치 + 파일명

            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));  // Open
            while (sr.EndOfStream == false)          // 파일의 마지막으로가면 true가 됨.
            {
                var temp = sr.ReadLine();            // temp 데이터를 잘라서 listAddress에 할당.
                var splits = temp.Split('|');   // split 메서드를 통해 |를 기준으로 하나씩 잘라줌.
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list) // manager.listaddress를 받아서 작업
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;  // 만들 데이터파일 위치 + 파일명
            var sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0)
            {
                foreach (var item in list)  // 만약 파일에 데이터가있으면 이름, 번호, 주소출력
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
