## 13. 대리자와 이벤트
> 타입은 '값'을 담을 수 있다. 이 값의 범위에 '메서드'도 포함될 수 있다. 이때 메서드를 가리킬 수 있는 타입을 C#에서는 **델리게이트(delegate)** 라는 구문으로 제공한다.<br> 
> 델리게이트 타입을 만드는 방법은 일반적인 class 구문이 아니고 delegate라는 예약어로 표현한다. <br>


델리게이트가 타입인 것은 중요한데, 변수가 사용되는 곳이면 델리게이트또한 함께 사용되는데, 이것은 다음과 같은 의미를 갖는다.
1. 메서드의 반환값으로 델리게이트를 사용할 수 있다.
2. 메서드의 인자로 델리게이트를 전달할 수 있다.
3. 클래스의 멤버로 델리게이트를 정의할 수 있다.

여기서 델리게이트가 메서드를 가리키는 것임을 떠올려보면 다음과같이 해석할 수 있다.
1. 메서드의 반환값으로 메서드를 사용할 수 있다.
2. 메서드의 인자로 메서드를 전달할 수 있다.
3. 클래스의 멤버로 메서드를 정의할 수 있다.


- [delegate](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap13/chap13App/21_03_02_01_FirstDelegateTest/Program.cs)
- [비교 대리자 예제](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap13/chap13App/21_03_02_02_CallbackTestApp/Program.cs)
- [chain delegate](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap13/chap13App/21_03_02_03_DelegateChainApp/Program.cs)
- [chain delegate(easy)](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap13/chap13App/21_03_03_01_DelegateChain2App(Fire)/Program.cs)
- [Event](https://github.com/SeoDongWoo1216/StudyCSharp21/blob/main/chap13/chap13App/21_03_03_02_UsingEventApp/Program.cs)
