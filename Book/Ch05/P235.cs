using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P235
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Ma1in(string[] args)
        {
            // 리스트(C#제공)라는 클래스안에 Student 요소를 추가한다.
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

 /*           foreach (var item in list)  잘못된 제거식
            {
                if(item.grade > 1)
                {
                    list.Remove(item);
                }
            }
*/           
            for (int i = list.Count - 1; i >= 0; i--)  // 배열의 앞에서부터 제거시 인덱스가 밀려버리니 역 for 문으로 뒤에서부터 요소 제거
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
