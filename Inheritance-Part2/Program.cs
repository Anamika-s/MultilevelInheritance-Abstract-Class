using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemos
{
    class Student
    {
        int rn;
        string name;
        public Student() { }
        public Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RollNo is {rn}\nName is {name}");
        }
    }

    class Sports : Student
    {
        string sportsName;
        protected int score;
        public Sports() { }
        public Sports(int score, string sportsName)
        {
            this.score = score;
            this.sportsName = sportsName;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter score");
            score = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter sportsName");
            sportsName = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"score is {score}\nsportsName is {sportsName}");
        }
    }

    class Test : Sports
    {
        int[] marks = new int[5];
        protected int totalMarks;
        public Test()
        {
            marks = new int[] { 0, 0, 0, 0, 0 };
        }
        public Test(int[] marks)
        {
           Array.Copy(marks, this.marks, marks.Length);
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Marks");
            for (int i = 0; i < 5; i++)
                marks[i] = Byte.Parse(Console.ReadLine());
            CalculateTotalMarks();

        }
        public void CalculateTotalMarks()
        {
            foreach (int temp in marks)
                totalMarks += temp;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Total Marks are {totalMarks}");
        }
    }

    class Result : Test
    {
        int totalScore;
        public void CalculateTotalScore()
        {
            base.GetDetails();
            totalScore = totalMarks + score;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
        }
    }
    class MultilevelInheritance
    {
        static void Main()
        {
            Result result = new Result();
           
            result.CalculateTotalScore();
            result.DisplayDetails();
        }
    }
}
