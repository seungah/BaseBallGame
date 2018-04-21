using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGameWindows
{
    class BaseballGameEngine
    {
        int[] quiz = new int[3];
        int strike = 0; //초기화 해주는 습관을 가지자.
        int ball = 0;

        internal void init()
        {
            //quiz 내기
            //1~9까지 중복없이 배열을 만들기
            //랜덤하게 두자리를 뽑아 교체한다.
            //quiz배열에 넣기
            int[] temp = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random(); //랜덤객체 만들기
            for (int n = 0; n < 100; n++)
            {
                int i = rand.Next(0, temp.Length); // 0,8로 랜덤을 줬을시 8은 들어가지 않으므로 0,9로 지정해줘야한다.
                int j = rand.Next(0, temp.Length);
                int t = temp[i];
                temp[i] = temp[j];
                temp[j] = t;

            }

            quiz[0] = temp[0];
            quiz[1] = temp[1];
            quiz[2] = temp[2];
            return;
        }

        internal int GetQuizLength() //문제 길이 돌려주기
        {
            return quiz.Length;
        }

        internal void Play(string input)
        {
            //quiz랑 input이랑 비교해서 strike, ball 판정하기
            //input을 int[]로 바꾸자
            //quiz를 for문으로 돌고
            //input을 for문으로 돌고
            //하나씩 꺼내어 숫자가 같으면
            //자리수가 같으면 strike++
            //자리수가 다르면 ball++

            strike = 0;
            ball = 0;
            int[] inputArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i] - '0';
                //-'0'일때 문자를 입력받으면 에러가 난다 (만약에 a를 넣으면 17, 아스키 17번째는 이상한 기호이므로 오류)
                //아스키코드에서 '0'이 48이기 때문에 각각 숫자에서 48을 빼면 원래 숫자가 생긴다
            }
            for (int i = 0; i < quiz.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (quiz[i] == inputArray[j])
                    {
                        if (i == j)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }
            return;
        }


        internal int Getstrike()
        {
            return strike;

        }

        internal int Getball()
        {
            return ball;
        }

        internal string GetQuiz()
        {
            return String.Format("{0} {1} {2}", quiz[0], quiz[1], quiz[2]);
        }
    }
}
