using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_04_AddressBookApp
{
    class AddressManager
    {
        public List<AddressInfo> listaddress; // 주소록을 담을 컬렉션

        public void PrintMenu()  // private는 기본값이라 생략되어 있음.(표기안해도됨)
        {
            // 메뉴 출력
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체 출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("----------------------------------------");
        }

        public int SelectMenu()
        {
            // 메뉴 번호 입력
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine();         // ReadLine()은 키보드입력을 문자열로 받음.
            int.TryParse(input, out int menuNum);      // 키보드 입력받은 문자열을 정수로 변환.(이상한거 입력하면 0반환)

            if (!(menuNum > 0 && menuNum < 7))  // 123456 값이 아닌 경우
                menuNum = 0;
            return menuNum;
        }

        public void InputAddress()
        {
            // 주소 저장
            Console.WriteLine("주소 입력");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("빈값은 입력할 수 없습니다.");
                Console.ReadLine();
            }
            else
                listaddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
        }

        public void SearchAddress()
        {
            // 주소 검색
            Console.WriteLine("주소 검색");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;   // 찾는 이름이 있는지?
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true; // 찾았음.
                    Console.WriteLine();
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine($"----------------------------------------");
                    break;        // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();   // 화면 멈춤
        }

        public void UpdateAddress()
        {
            // 주소 수정
            Console.WriteLine("주소 수정");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine("");
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine($"----------------------------------------");

                    Console.Write($"이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write($"전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write($"주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone) || string.IsNullOrEmpty(uAddress))
                    {
                        Console.Write("빈값은 입력할 수 없습니다.");
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                        Console.WriteLine("데이터가 수정되었습니다.");
                    }
                    break;        // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }

            Console.ReadLine();   // 화면 멈춤
        }

        public void DeleteAddress()
        {
            // 주소 삭제
            Console.WriteLine("주소 삭제");
            Console.WriteLine("----------------------------------------");

            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listaddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine($"----------------------------------------");

                    Console.Write("삭제하시겠습니까?[y/n] >>> ");
                    string answer = Console.ReadLine();   // y/n 입력받기
                    if (answer.ToUpper() == "Y")
                    {
                        listaddress.RemoveAt(idx);
                        Console.WriteLine("데이터가 삭제되었습니다.");
                    }
                    else if (answer.ToUpper() == "N")
                    {
                        Console.WriteLine("데이터가 보존되었습니다.");
                    }

                    break;        // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }

            Console.ReadLine();   // 화면 멈춤
        }

        public void PrintAllAddress()
        {
            // 주소 전체 출력
            Console.WriteLine("주소 전체 출력");
            Console.WriteLine("----------------------------------------");
            int idx = 0;

            if (listaddress.Count == 0)
            {
                Console.WriteLine("주소록이 없습니다.");
            }
            else
            {
                foreach (var item in listaddress)
                {
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine($"----------------------------------------");
                    Console.WriteLine();
                    idx++;
                }
            }
            Console.ReadLine();   // 화면 멈춤
        }
    }
}
