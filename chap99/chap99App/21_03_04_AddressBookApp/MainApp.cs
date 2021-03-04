using System;
using System.Collections.Generic;

// 주소 CUID 퀴즈를 다같이 실습해보자.
namespace _21_03_04_AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    listaddress = new List<AddressInfo>()
                };

                DataFileManager fileManager = new DataFileManager();
                manager.listaddress = fileManager.ReadData();    // ReadData의 결과값을 listaddress로 보내줌

                while (true)
                {
                    Console.Clear();
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        case 1:    // 주소 입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;

                        case 2:    // 주소 검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;

                        case 3:    // 주소 수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;

                        case 4:    // 주소 삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;

                        case 5:    // 주소 전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;

                        case 6:    // 종료
                                   // 주소록을 다시 파일에 씀
                            fileManager.WriteData(manager.listaddress);
                            Console.WriteLine("프로그램이 종료됩니다.");
                            Environment.Exit(0);
                            break;

                        default:   // 다른 값이나 0은 디폴트로 처리 
                                   // 아무 로직 없음
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }

    }
}
