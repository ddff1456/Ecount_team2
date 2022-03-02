using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
    //연습 클래스 생성
    //클래스 == 설계도 == 데이터타입
    class Person    //설계도라고 정의 : 최소 : 속성 + 기능 : 너 설계도 부르고 ...객체를 생성
    {   //속성(정보를 담는 그릇 : 크기 + 이름 > 변수)
        int num; //클래스가 가지는 변수 : instance variable(지역변수) : 생성되는 객체마다 가지는 변수
                 // Pserson p = new Person();   Person p2 = new Person();
                 //p.num과 p2.num 다른것
                 //기본적인 접근자를 가지고 있다
                 //아무것도 명시하지 않으면 private int num 으로 처리
                 //Tip) default int num JAVA는

        //private 데이터를 보호하겠다 의지가 ... 설계도를 만든 사람의 ...
        //객체지향 언어의 특징
        //캡슐화, 은닉화 자원을 보호 구현하는 기술 : private
        //1. private : 클래스 내부에서는 모두 같은 식구, 객체입장에서 볼수없음
        //2. public : 클래스 내부에서는 모두 같은 식구, 객체입장에서 볼수잇음 보호분제(직접할당)
        //3. private 사용하면서 객체가 사용할 수 있게
        //3.1 함수생성 : public : 캡슐화된 자원에 read, write ... (간접할당)

        private int k;
        public int y;

        public int getK() //보호된 자원의 값을 return 읽기전용
        {
            return k;
        }
        public void setK(int data) //보호된 자원값을 쓰기전용
        {                          //설계자의 의도는 마이너스 값은 받지 않겠다.
            if(data < 0)
            {
                k = 0;
            }
            else if(data > 0)
            {
                k = data;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2명의 사람을 만드세요
            Person p = new Person();
            Person p2 = new Person();
            //p.num = 100; p라는 변수가 직접적으로 num 변수에 접근을 막는다.
            p.y = 100; //직접할당
            p2.y = 200; //직접할당
            //y라는 변수 양수값만

            p.setK(-100);
            Console.WriteLine(p.getK());
        }
    }
}
