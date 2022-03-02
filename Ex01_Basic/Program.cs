using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Basic        //논리적인 묶음의 단위(클래스간 충돌방지)
{
    //클래스는 설계도 == 클래스는 타입이다.
    //java ,c# : 클래스 만들려고 씀 : class  이름을 붙이면 설계도 : 객체생성가능
    //클래스 2가지 : Main 있는 클래스(exe), Main 없는 클래스(dll)
    //원칙적인 방법은 : 코든 클래스는  new 연산자를 통해서 메모리에 로드
    //Program p = new Program();
    class Car       //dll
    {

    }

    class Test
    {
        public int data;
    }



    class Program       
    {
        static void Main(string[] args)     //함수(Method) > 기능  > static (독자적으로 메모리)
                                            //이름이 Main() > 실행 가능(stack)
        {
            //Console.WriteLine("Hello world");

            //데이터 타입과 변수
            char c;// 2byte     //한글한자 : 2byte, 영문자, 특수문자, 공백 : 1byte
                   // >> 약속    >> 한문자를 2byte
            c = 'A';

            char d;
            d = '나';
            Console.WriteLine("c:{0}, d:{1}",c,d);

            //지역변수는 반드시[초기화]를 통해서 사용한다
            short s;
            s = 100;

            Console.WriteLine(s);

            int i = 10000000;
            Console.WriteLine(i);

            //1.12 리수 리터럴의 기본형을  double
            float f = 1.12f; //접미사  1.12f 4byte 그릇에 담긴 값

            Console.WriteLine(f);

            double dd = 1.123123;
            Console.WriteLine(dd);

            bool b = true; //논리적인 구조 (제어구조에서 논리판단)

            //값 타입 증명하기
            //aa값 value type 증명하기
            int aa = 100;
            int bb = aa; //할당 (값할당)
            bb = 200;
            Console.WriteLine("aa값은 {0}", aa);

            //참조타입 증명
            Console.WriteLine(aa.GetType());
            Console.WriteLine(aa.GetTypeCode());

            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            Test t2 = t;//할당(주소값)
            t2.data = 1111;
            Console.WriteLine("t객체의 data 변수값은 :{0}", t.data);
            Console.WriteLine(t ==t2);
            Console.WriteLine("{0}-{1}",t.GetHashCode(), t2.GetHashCode());
        }
    }
}
