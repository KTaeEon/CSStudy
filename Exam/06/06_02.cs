using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/29
 * 이름 : 김태언
 * 내용 : 파일 입출력 연습문제
 */
namespace Exam._06
{
    internal class _06_02
    {
        static void Ma1in(string[] args)
        {
            string path = "C:\\Users\\502\\Desktop\\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                // 스트림 생성
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                
                for (int x = 2; x <= 9; x++)
                {
                    sw.WriteLine($"{x}단");
                    for (int y = 1; y <= 9; y++)
                    {
                        int z = x * y;
                        sw.WriteLine($"{x} x {y} = {z}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 파일닫기
                sw.Close();
                fs.Close();
            }
            Console.WriteLine("구구단 파일 생성 완료...");
        }
    }
}
