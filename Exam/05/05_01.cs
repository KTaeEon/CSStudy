using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/28
 * 이름 : 김태언
 * 내용 : 컬렉션 연습문제
 */
namespace Exam._05
{
    internal class _05_01
    {
        static void Ma1in(string[] args)
        {
            List<int> list = new List<int> { 3, 6, 2, 2, 2, 7 };

            HashSet<int> hset = new HashSet<int>(list);
            SortedSet<int> sset = new SortedSet<int>(hset);
            Stack<int> stack = new Stack<int>(sset);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
