## 19. 스레드와 태스크
>  **스레드(thread)** 는 명령어를 실행하기 위한 스케줄링 단위이며, 프로세스 내부에서 생성할 수 있다. 이는 운영체제에서 멀티 스레딩을 지원한다면 하나의 프로세스가 여러 개의 스레드 자원을 가질 수 있음을 의미한다. <br>
>  프로그램이 실행되면 주 스레드가 기본적으로 하나가 생성된다. 주 스레드는 컴파일된 C# 코드를 순차적으로 실행해 나간다. Thread 타입에는 현재 명령어를 실행 중인 스레드 자원에 접근할 수 있는 정적 속성을 제공한다. 이를 활용하면 다음의 코드처럼 프로그램을 실행하고 있는 스레드의 상태를 알 수 있다.
- [스레드 다뤄보기](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap19/Chap19App/21_03_05_01_FirstThread/Program.cs)
- [여러가지 스레드 메서드](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap19/Chap19App/21_03_05_02_ThreadStateApp/Program.cs)
- [스레드 종료](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap19/Chap19App/21_03_05_03_SideTaskApp/Program.cs)
- [프로그레스 바를 이용한 스레드](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap19/Chap19App/21_03_05_04_ProgressTestApp/frmMain.cs)
