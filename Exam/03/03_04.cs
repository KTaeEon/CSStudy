﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class Student
    {
        public static int studentID;
        private string name;
        private string major;
        private int grade;

        public Student(string name, string major, int grade)
        {
            studentID++;
            this.name = name;
            this.major = major;
            this.grade = grade;
        }

        public void StudentInfo()
        {
            Console.WriteLine("==================");
            Console.WriteLine("학번 : " + studentID);
            Console.WriteLine("학번 : " + name);
            Console.WriteLine("학번 : " + major);
            Console.WriteLine("학번 : " + grade);
            Console.WriteLine("------------------");
        }
    }
    internal class _03_04
    {
        static void Ma1in(string[] args)
        {
            Student.studentID = 20201000;

            Student kim = new Student("김유신", "국문과", 1);
            kim.StudentInfo();

            Student lee = new Student("이순신", "경제학과", 1);
            lee.StudentInfo();

            Student lim = new Student("임꺽정", "경영학과", 1);
            lim.StudentInfo();
        }
    }
}
