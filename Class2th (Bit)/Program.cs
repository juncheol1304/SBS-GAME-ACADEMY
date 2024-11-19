﻿namespace Class2th__Bit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는
            // 메모리 공간입니다.

            // const float pi = 3.141592f;

            // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며,
            // 한 번 저장된 값은 더 이상 변경할 수 없습니다.

            // pi = 6.5f;

            // 상수의 경우 메모리 공간을 가지고 있지 않은 상수를 리터럴
            // 상수라고 하며, 메모리 공간을 가지고 있는 상수를 심볼릭
            // 상수라고 합니다.

            #endregion

            #region 산술 연산자
            // 1. int result1 변수 + 변수 
            // 2. int result2 리터럴 상수 - 변수
            // 3. int result3 리터럴 상수 * 심볼릭 상수
            // 4. int result4 심볼릭 상수 / 변수
            // 5. int result5 리터럴 상수 % 리터럴 상수

            // int a = 10;
            // const int b = 10;

            // int result1 = a + a;
            // int result2 = 15 - a;
            // int result3 = 5 * b;
            // int result4 = b / a;
            // int result5 = 10 % 10;

            // Console.WriteLine("result1의 값 : " + result1);
            // Console.WriteLine("result2의 값 : " + result2);
            // Console.WriteLine("result3의 값 : " + result3);
            // Console.WriteLine("result4의 값 : " + result4);
            // Console.WriteLine("result5의 값 : " + result5);
            #endregion

            #region 비트
            // 데이터를 나타내는 최소의 단위이며, 0 또는 1의 조합으로
            // 논리 계산을 수행하는 단위입니다.

            #region 10 진수를 2 진수로 변환하는 과정
            // 10진수 1이 될 때까지 계속 2로 나누어 준 다음
            // 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.

            int count = 19;
            // [0][0][0][1][0][0][1][1]

            #endregion

            #region 2 진수를 10 진수로 변환하는 과정
            // 1 byte에 2 진수로 저장된 값을 2의 제곱으로 나타내며,
            // 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산하여
            // 각각의 비트를 모두 더하여 10진수로 나타냅니다.

            int time = 10; // [0][0][0][0][1][0][1][0]


            #endregion

            #region 비트 연산자
            // 비트 단위로 논리 연산을 수행하기 위해 사용하는 연산자입니다.

            #region AND 연산자
            // 두 개의 피연산자가 모두 1 이면
            // 1을 반환하는 연산자입니다.

            // int x1 = 8;  // [0][0][0][0][1][0][0][0]
            // int y1 = 11; // [0][0][0][0][1][0][1][1]  
            //              // ------------------------
            //              // [0][0][0][0][1][0][0][0]
            // 
            // Console.WriteLine("x1 변수와 y1 변수를 AND 연산한 결과 : " + (x1 & y1));
            #endregion

            #region OR 연산자
            // 두 개의 피연산자 중에서 하나라도 1이 있다면
            // 1을 반환하는 연산자입니다.

            // int x2 = 15; // [0][0][0][0][1][1][1][1]
            // int y2 = 6;  // [0][0][0][0][0][1][1][1]
            //              // ------------------------
            //              // [0][0][0][0][1][1][1][1]
            // 
            // Console.WriteLine("x2 변수와 y2 변수를 OR 연산한 결과 : " + (x2 | y2));

            #endregion

            #region XOR 연산자
            // 두 개의 피연산자가 서로 같으면 0을 반환하고, 서로 다르면
            // 1을 반환하는 연산자입니다.

            // int x3 = 13; // [0][0][0][0][1][1][0][1]
            // int y3 = 18; // [0][0][0][1][0][0][1][0]
            //              // ------------------------
            //              // [0][0][0][1][1][1][1][1]
            // 
            // Console.WriteLine("x3 변수와 y2 변수를 XOR 연산한 결과 : " + (x3 ^ y3));

            #endregion

            #region NOT 연산자
            // 하나의 피연산자 비트를 반전시키는 연산자 입니다.

            // int power = 20; // [0][0][0][1][0][1][0][0]
            //                 // ------------------------ 
            //                 // [1][1][1][0][1][0][1][1]
            // 
            // Console.WriteLine("power 변수를 NOT 연산한 결과 : " +(~power));

            // 첫 번째 비트는 부호를 나타내며, 첫 번째 비트에
            // 1이 있다면 값은 음수가 됩니다.
            #endregion

            #endregion

            // 메모리는 비트 단위로 데이터를 저장할 수 있으며, 1개의
            // 비트에는 0 또는 1의 값만 저장할 수 있습니다.
            #endregion
        }
    }
}