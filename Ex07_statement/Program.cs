using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //제어문과 연산자 같이 연습
            /**/

            /*int i = 0;
             잘 사용하지 않는다.
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("i : {0}", i);
            }
            Console.WriteLine("for 끝나고 : {0}",i);*/

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i : {0}", i);
            }
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) break;
                    //Console.Write("{0} * {1} = {2}\t",i,j,i*j);
                    Console.Write("*");
                }
                Console.WriteLine();//엔터 처리
            }
            Console.WriteLine();

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue; // skip
                    //Console.Write("{0} * {1} = {2}\t",i,j,i*j);
                    Console.Write("{0} * {1} = {2}\t",i,j,i*j);
                }
                Console.WriteLine();//엔터 처리
            }

            int result;
            Console.Write("숫자값을 입력하세요");
            result = int.Parse(Console.ReadLine()); //정수값으로 변환

            switch (result)
            {
                case 1: Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine(result);
                    break;
                case 4:
                    Console.WriteLine(result);
                    break;
                case 5:
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }

            //1~100까지 합을 구하세요
            //while(조건){}
            int k = 1;
            int ksum = 0;   //지역변수 사용전에 초기화 반드시
            while(k <= 100)
            {
                ksum += k;
                //반드시 내부에서 증가감을 처리
                k++;
            }
            Console.WriteLine("누적합 :{0}, i{1}",ksum, k);

            //1~100까지 홀수의 합
            int a = 0;
            int asum = 0;
            while (a <= 100)
            {
                if (a % 2 ==0)
                {
                    a++;
                    continue; //skip 아래구분
                }
                asum += a;
                a++;
            }
            Console.WriteLine("홀수합 :{0}, a{1}", asum, a);

            int even = 0;// 짝수
            int odd = 0; //홀수
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 ==0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            Console.WriteLine("짝수 :{0}, 홀수:{1} ",even,odd);

            //Q: 지정된 계정 : admin 암호 : 1234가 있다.
            //두값을 console에서 받아서 두값이 모두 일치하는 경우 "성공"출력
            //하나라도 값이 일치하지 않는 경우 "넌 누구냐" 출력하세요

            string ID ="";
            Console.Write("아이디를 입력하세요");
            ID = Console.ReadLine();

            string PWD="";
            Console.Write("비밀번호를 입력하세요");
            PWD = Console.ReadLine();

            if (ID =="admin" && PWD =="1234")
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("넌 누구냐");
            }

            if ('A' != 65)
            {
                Console.WriteLine("FALSE");
            }
            else
            {
                Console.WriteLine("TRUE");
            }

            //연산자 중에서 암기(Today point) : 삼항연산자
            int p2 = 10;
            int k2 = -10;

            int result2 = (p2 == k2) ? p2 : k2;
            Console.WriteLine("result2 : {0}", result2);
            
            if (p2 == k2)
            {

            }
            else
            {

            }

            int x1 = 3;
            int x2 = 5;

            //비트연산
            //3 십진수 값을 이진수(0,1)
            //128 64 32 16 8 4 2 1      (2의배수)
            //             0 0 1 1      십진수 3의 2진수
            //             0 1 0 1      십진수 5의 2진수
            //AND          0 0 0 1      3과5의 AND 연산 > 십진수   >1
            //OR           0 1 1 1      3과5의 OR  연산 > 십진수 > (1+2+4) > 7
            Console.WriteLine("x1 & x2 : " + (x1&x2));
            Console.WriteLine(x1 | x2);
        }
    }
}
