# StudyCSharp
PKNU C# 학습 리포지토리입니다 <br><br>
교안 : 이것이 C#이다(한빛미디어) <br><br>
교재 : 시작하세요! C# 8.0 프로그래밍 (위키북스)

## Basic C#
기본 문법 학습

- [3. 데이터 보관](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap03/Chap03App)
- [4. 데이터를 가공하는 연산자](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap04/Chap04App)
- [5. 코드 흐름 제어](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap05/Chap05App)
- [10. 배열, 컬렉션, 인덱서](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap10/chap10App)

## 객체지향 프로그래밍
고급 문법 학습
- [5. 메서드](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap06/Chap06App)
- [7. 클래스](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap07/Chap07App)
- [8. 인터페이스와 추상클래스](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap08/Chap08App)
- [9. 프로퍼티](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap09/chap09App)
- [11. 일반화 프로그래밍](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap11/chap11App)
- [12. 예외 처리](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap12/chap12App)
- [13. 대리자와 이벤트](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap13/chap13App)
- [15. LINQ](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap15/Chap15App)
- [18. 문자열과 파일 다루기](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap18/chap18App)
- [19. 스레드와 테스크](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap19/Chap19App)
- [20. WinForm](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap20/chap20App)


## Project 실습 : 콘솔 전화번호부 프로그램
- [소스보기](https://github.com/SeoDongWoo1216/StudyCSharp21/tree/main/chap99/chap99App/21_03_04_AddressBookApp) <br>
> 콘솔창에서 데이터를 저장, 검색, 수정, 삭제를 통해 전화번호부를 관리하는 프로그램입니다. <br>

- MainApp : 메인 메서드에서 키보드로 숫자를 입력받았을때 case문으로 각각 나뉘어서 AddressManager로 넘겨줍니다.
- AddressInfo : 클래스 변수를 통해 타입을 정의하고, AddressManager에서 List를 통해 이를 활용하여 데이터를 가공할 수 있도록 세팅했습니다.
- AddressManager : 입력받은 case문 기능들을 구현했습니다.
- DataFileManager : .dat 파일을 통해 유사 데이터베이스처럼 데이터를 가공할 수 있게하여 콘솔 프로그램이 종료되면 모든 데이터가 소실되는 단점을 보완하였습니다. 


#### 첫 화면
![첫화면](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/0_%EC%B2%AB%ED%99%94%EB%A9%B4.png "첫 화면")

#### 데이터 입력
![입력1](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/1_%EC%9E%85%EB%A0%A5_02.png "입력1")
![입력2](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/1_%EC%9E%85%EB%A0%A5_03.png "입력2")
![입력3](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/1_%EC%9E%85%EB%A0%A5_04(%EC%B6%9C%EB%A0%A5).png "입력된거확인(출력)")


#### 데이터 검색
![검색1](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/2_%EA%B2%80%EC%83%89_01.png "데이터 검색")

#### 데이터 수정
![수정1](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/3_%EC%88%98%EC%A0%95_01.png "수정")
![수정2](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/3_%EC%88%98%EC%A0%95_02(%EC%B6%9C%EB%A0%A5).png "데이터 수정 확인(출력)")

#### 데이터 삭제
![삭제1](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/4_%EC%82%AD%EC%A0%9C_01.png "삭제")
![삭제2](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/4_%EC%82%AD%EC%A0%9C_02(%EC%B6%9C%EB%A0%A5).png "데이터 삭제 확인(출력)")

#### 프로그램 종료
![종료](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap99/chap99App/21_03_04_AddressBookApp/ResultImage/6_%EC%A2%85%EB%A3%8C.png "프로그램 종료")
