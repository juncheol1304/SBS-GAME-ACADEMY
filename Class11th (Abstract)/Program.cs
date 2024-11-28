using System.Reflection.Metadata;
using Program.UnrealEngine;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 추상화
            // 객체를 정의할 때 필요없는 부분을 생략하고 객체의 
            // 속성 중에서 중요한 부분을 중점으로 두어 간단하게
            // 설계할 수 있도록 만들어주는 것입니다.

            // Charater charater = null;
            // 
            // charater = new Warrior();
            // charater.Skill();
            // charater.Stats();
            // 
            // charater = new Wizard();
            // charater.Skill();
            // charater.Stats();
            // 
            // charater = new Rogue();
            // charater.Skill();
            // charater.Stats();

            // 추상 클래스는 객체로 생성할 수 없습니다.

            #endregion

            #region 이름 공간
            // 속성을 구분할 수 있도록 유효 범위를 설정하는 
            // 영역입니다.

            // Broadcast broadcast = new Broadcast();
            // 
            // broadcast.Send();

            // 이름 공간은 같은 이름의 함수나 변수를 또 다른
            // 공간에 선언하여 중복되지 않도록 선언할 수 있습니다.

            #endregion

            #region 의사 난수의 생성

            // Random random = new Random();
            // 
            // int value = random.Next(0, 3);
            // 
            // Console.WriteLine(value);


            #endregion

            #region UP - DOWN 게임
            // 1. computer가 특정한 숫자를 뽑습니다. 1~30
            // 2. 캐릭터가 선택한 computer가 가지고 있는 값을 입력합니다.
            //    - 틀렸을 때 더 큰 값을 입력했을 때
            //    (HP를 감소시키고 Computer 가지고 있는 값보다 큽니다.)
            //    - 틀렸을 때 더 작은 값을 입력했을 때
            //    (HP를 감소시키고 Computer가 가지고 있는 값보다 작습니다.)
            // 3. 캐릭터가 computer 가지고 있는 값을 똑같이 입력했을 때
            //    - 게임에서 승리하였습니다.
            //    HP가 0 이하로 떨어졌다면
            //    - 게임에서 패배하였습니다.

            // Console.WriteLine("UP - DOWN 게임 시작");
            // Random random = new Random();
            // int computer = random.Next(1, 30);
            // int health = 5;
            // int answer = 0;
            // 
            // while (health > 0)
            // {
            //     Console.WriteLine("Conputer가 가지고 있는 값 : ");
            // 
            //     answer = int.Parse(Console.ReadLine());
            // 
            //     if (computer > answer)
            //     {
            //         Console.WriteLine("Computer가 가지고 있는 값보다 작습니다.");
            //         health--;
            //     }
            //     else if (computer < answer)
            //     {
            // 
            //         Console.WriteLine("Computer 가지고 있는 값보다 큽니다.");
            //         health--;
            //     }
            //     else
            //     {
            //         Console.WriteLine("게임에서 승리하였습니다.");
            //         break;
            //     }
            // 
            //     Console.WriteLine();
            //     #endregion
            // }
            // if (health <= 0)
            // {
            //     Console.WriteLine("게임에서 패배하였습니다.");
            // }
            #endregion
        }
    }

    namespace UnrealEngine
    {
        public class Broadcast
        {
            public void Send()
            {
                Console.WriteLine("Send Message");
            }
        }
    }
}
