using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Program
    {
        // 카드 덱을 저장하는 리스트
        static List<string> deck = new List<string>();
        // 플레이어와 딜러의 코인
        static int playerCoins = 500;
        static int dealerCoins = 500;
        static Random random = new Random();

        static void Main()
        {
            // 게임 설명
            Console.WriteLine("안녕하세요. 이 게임은 블랙잭 룰을 적용한 카드게임 입니다.");
            Console.WriteLine("");
            Console.WriteLine("플레이어와 딜러는 각각 500 코인을 가지고 게임을 시작합니다.");
            Console.WriteLine("");
            Console.WriteLine("플레이어가 원하는 만큼 금액을 제시하면, 딜러도 같은 금액을 제시합니다.");
            Console.WriteLine("");
            Console.WriteLine("승리한다면 양쪽이 제시한 금액 모두를 가져갑니다. 먼저 모든 코인을 잃은 쪽이 패배합니다.");
            Console.WriteLine("");
            Console.WriteLine("A는 1로만 계산합니다.");
            Console.WriteLine("");
            Console.WriteLine("게임을 시작하려면 엔터를 누르세요.");
            Console.ReadLine(); // 게임 시작 대기

            InitializeDeck(); // 덱 초기화

            while (playerCoins > 0 && dealerCoins > 0) // 플레이어와 딜러 둘다 0원이 아닐때 게임진행
            {
                PlayRound(); //게임시작 메서드
            }

            // 둘중 한명이 0원이면
            if (playerCoins <= 0) // 플레이어가 0원이 아니면 승리
                Console.WriteLine("플레이어가 모든 코인을 잃었습니다. 패배입니다.");
            else
                Console.WriteLine("딜러가 모든 코인을 잃었습니다. 승리입니다.");
        }

        //for문으로 자주 사용하는 로직과 비슷한 원리
        static void InitializeDeck()
        {
            string[] suits = { "♠", "♣", "♥", "♦" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            // 포리치를 통해 카드를 하나씩 Deck 리스트에 넣어주고 ShuffleDeck()을 통해 랜덤으로 섞어줌
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add($"{suit} {rank}");
                }
            }

            ShuffleDeck();
        }

        // 덱 섞기
        static void ShuffleDeck() // 중요!!!
        {   //모든 카드에 한번씩 반복
            for (int i = 0; i < deck.Count; i++)
            {   //카드의 갯수중 무작위 숫자를 randomIndex에 넣고
                int randomIndex = random.Next(deck.Count);
                // n번째 카드를 temp에 임시저장
                string temp = deck[i];
                // n번째 카드에 randomIndex 카드를 넣고
                deck[i] = deck[randomIndex];
                // randomIndex카드에 임시로 저장해뒀던 n번째카드를 넣어줌
                deck[randomIndex] = temp;
                // 모든 카드의 숫자만큼 반복하며 모두 이 과정을 거침
            }
        }

        //게임 진행 부분
        static void PlayRound()
        {
            Console.Clear();
            Console.WriteLine($"\n플레이어 코인: {playerCoins}, 딜러 코인: {dealerCoins}");
            Console.WriteLine("");
            // 플레이어가 배팅할 금액 입력
            Console.WriteLine("배팅할 금액을 입력하세요: ");
            int betAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (betAmount > playerCoins || betAmount > dealerCoins)
            {
                Console.WriteLine("플레이어 혹은 딜러의 코인이 부족합니다. 다시 확인해주세요.");
                return;
            }

            List<string> playerHand = new List<string>();
            List<string> dealerHand = new List<string>();

            // 플레이어와 딜러가 각각 두 장의 카드를 받음
            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());

            Console.WriteLine($"플레이어 카드: {string.Join(", ", playerHand)}");
            Console.WriteLine($"딜러 카드: {dealerHand[0]}, ??");

            // 플레이어의 행동 선택
            while (true)
            {
                Console.WriteLine("행동을 선택하세요: 1. 히트(카드 추가) 2. 스탠드(카드 유지)");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    playerHand.Add(DrawCard());
                    Console.WriteLine($"플레이어 카드: {string.Join(", ", playerHand)}");

                    if (CalculateHandValue(playerHand) > 21)
                    {
                        Console.WriteLine("플레이어가 21을 초과했습니다! 패배입니다.");
                        playerCoins -= betAmount;
                        dealerCoins += betAmount;
                        return;
                    }
                }
                else if (action == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 1 혹은 2 를 입력해주세요.");
                }
            }

            // 딜러의 턴 (16 이하일 경우 히트)
            while (CalculateHandValue(dealerHand) < 17)
            {
                dealerHand.Add(DrawCard());
            }

            Console.WriteLine($"딜러 카드: {string.Join(", ", dealerHand)}");
            // CalculateHandValue는 가진 카드의 합을 계산하는 함수
            int playerScore = CalculateHandValue(playerHand);
            int dealerScore = CalculateHandValue(dealerHand);

            Console.WriteLine($"플레이어 점수: {playerScore}, 딜러 점수: {dealerScore}");

            // 승패 결정
            if (dealerScore > 21 || playerScore > dealerScore)
            {
                Console.WriteLine("플레이어 승리!");
                playerCoins += betAmount;
                dealerCoins -= betAmount;
            }
            else if (playerScore < dealerScore)
            {
                Console.WriteLine("딜러 승리!");
                playerCoins -= betAmount;
                dealerCoins += betAmount;
            }
            else
            {
                Console.WriteLine("무승부! 배팅 금액이 반환됩니다.");
            }
        }

        // 카드 뽑기 함수
        static string DrawCard()
        {
            if (deck.Count == 0) // 카드가 없다면
            {
                Console.WriteLine("덱에 카드가 부족하여 덱을 재정렬합니다.");
                InitializeDeck(); // 덱 초기화
            }

            string card = deck[0]; // 리스트의 첫번째에 있는것을 card 변수에 넣어주고
            deck.RemoveAt(0); // 해당카드를 지운다.
            return card; // card 값을 반환해줌
        }

        // 핸드의 총 합계를 계산하는 함수 (suit는 볼필요없음) rank만 체크하기 중요부분
        static int CalculateHandValue(List<string> hand)
        {
            int totalValue = 0;
            foreach (string card in hand)
            {
                string rank = card.Split(' ')[1]; // 카드의 랭크 (숫자나 문자를 가져옴)
                if (int.TryParse(rank, out int number))
                {
                    totalValue += number; // 숫자 카드면 숫자 값을 더함
                }
                else if (rank == "A")
                {
                    totalValue += 1; // A는 1로 계산
                }
                else
                {
                    totalValue += 10; // J, Q, K는 10으로 계산
                }
            }
            return totalValue;
        }
    }
}
