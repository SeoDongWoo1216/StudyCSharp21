using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_26_AddressQuiz
{

    class AddressVariable  // 주소 데이터를 저장할 클래스 선언
    {
        public string name;
        public string phone;
        public string address;
    }

    class Program
    {
        static List<AddressVariable> ArrayAddress = new List<AddressVariable>();  // 주소 변수들을 저장할 List 선언
        static void Main(string[] args)
        {

            while (true)
            {

                StartProgram();
                string input = ChoiceYourMenu();
                ScreenClear();

                switch (input)
                {
                    case "0":   // 데이터 입력
                        inputData();
                        break;
                    case "1":   // 데이터 검색
                        SerachData();
                        break;
                    case "2":   // 데이터 수정
                        UpdateData();
                        break;
                    case "3":   // 데이터 삭제
                        DeleteData();
                        break;
                    case "4":   // 데이터 출력
                        PrintData();
                        break;
                    case "5":   // 프로그램 종료
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("잘못입력하셨습니다.");
                        break;
                }
            }

        }



        private static void ScreenClear()     // 콘솔창 클리어
        {
            Console.Clear();
        }

        private static void StartProgram()    // 메뉴 출력
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("---------------------------------------");
        }

        private static string ChoiceYourMenu()     // 메뉴 선택(번호)
        {
            Console.Write("메뉴를 선택하세요 >>> ");
            string yourchoice = Console.ReadLine();
            if (int.TryParse(yourchoice, out int result))  // 메뉴를 선택할때 0~5 사이의 숫자를 입력안했을때 걸러주는 조건문
            {
                return yourchoice;
            }
            else
            {
                return "6";
            }

        }

        private static void EmptyData()        // 입력한 데이터가 없을때 출력
        {
            Console.WriteLine("입력하신 데이터가 없습니다. ");
        }

        private static void inputData()              // 0. 데이터 입력
        {
            ScreenClear();
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.Write("전화 입력: ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력: ");
            string address = Console.ReadLine();

            AddressVariable addr = new AddressVariable();  // 입력받은 데이터를 AddressVariable의 데이터로 추가
            addr.name = name;
            addr.phone = phone;
            addr.address = address;

            ArrayAddress.Add(addr);
        }

        private static void SerachData()             // 1. 데이터 검색
        {
            ScreenClear();
            if (ArrayAddress.Count != 0)     // 입력한 데이터가 없을경우 걸러주는 조건문
            {
                Console.Write("검색할 이름 입력 : ");
                string name = Console.ReadLine();

                for (int i = 0; i < ArrayAddress.Count; i++)
                {
                    if (name == ArrayAddress[i].name)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine(ArrayAddress[i].name);
                        Console.WriteLine(ArrayAddress[i].phone);
                        Console.WriteLine(ArrayAddress[i].address);
                        Console.WriteLine("---------------------------------------");
                        break;
                    }
                    else
                    {
                        EmptyData();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("검색할 데이터가 없습니다");
            }

        }

        private static void UpdateData()        // 2. 데이터 수정
        {
            ScreenClear();
            if (ArrayAddress.Count != 0)     // 입력한 데이터가 없을경우 걸러주는 조건문
            {
                Console.Write("수정할 이름 입력 : ");
                string name = Console.ReadLine();

                for (int i = 0; i < ArrayAddress.Count; i++)
                {
                    if (name == ArrayAddress[i].name)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine(ArrayAddress[i].name);
                        Console.WriteLine(ArrayAddress[i].phone);
                        Console.WriteLine(ArrayAddress[i].address);
                        Console.WriteLine("---------------------------------------");

                        Console.Write("이름 입력: ");
                        string u_name = Console.ReadLine();
                        Console.Write("전화 입력: ");
                        string u_phone = Console.ReadLine();
                        Console.Write("주소 입력: ");
                        string u_address = Console.ReadLine();

                        ArrayAddress[i].name = u_name;
                        ArrayAddress[i].phone = u_phone;
                        ArrayAddress[i].address = u_address;
                        Console.WriteLine("데이터가 수정되었습니다.");
                        break;
                    }

                    else
                    {
                        EmptyData();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("수정할 데이터가 없습니다");
            }

        }

        private static void DeleteData()        // 3. 데이터 삭제
        {
            ScreenClear();
            if (ArrayAddress.Count != 0)     // 입력한 데이터가 없을경우 걸러주는 조건문
            {
                Console.Write("삭제할 이름 입력 : ");
                string name = Console.ReadLine();
                for (int i = 0; i < ArrayAddress.Count; i++)
                {
                    if (name == ArrayAddress[i].name)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine(ArrayAddress[i].name);
                        Console.WriteLine(ArrayAddress[i].phone);
                        Console.WriteLine(ArrayAddress[i].address);
                        Console.WriteLine("---------------------------------------");

                        Console.Write("삭제하시겠습니까? [1 : 삭제/ 0 : 아니오] : ");
                        string AreyouDelete = Console.ReadLine();
                        if (AreyouDelete == "1")
                        {
                            ArrayAddress.RemoveAt(i);
                            Console.WriteLine("삭제되었습니다.");
                        }
                        else if (AreyouDelete == "0")
                        {
                            Console.WriteLine("데이터를 보존합니다.");
                        }
                        else
                        {
                            Console.WriteLine("잘못 입력하셨습니다. 데이터를 보존합니다.");
                        }
                        break;
                    }

                    else
                    {
                        EmptyData();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("삭제할 데이터가 없습니다");
            }
        }


        private static void PrintData()         // 4. 입력한 데이터 출력
        {
            ScreenClear();
            for (int i = 0; i < ArrayAddress.Count; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(ArrayAddress[i].name);
                Console.WriteLine(ArrayAddress[i].phone);
                Console.WriteLine(ArrayAddress[i].address);
                Console.WriteLine("---------------------------------------");
            }
        }

        private static void ExitProgram()       // 5. 프로그램 종료
        {
            ScreenClear();
            Console.WriteLine("프로그램을 종료합니다.");
            Environment.Exit(0);
        }
    }
}
