using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevelInheritanceDemo
{
    class Student
    {
        int rn;
        string name;
        public void Get()
        {
            Console.WriteLine("Enter rn");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter name");    
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("sportsName is " + name);
        }

    }
    class Sports : Student
    {
        protected int score;
        string sportsName;
        public void Get()
        {
            base.Get();
            Console.WriteLine("Enter score");
            score = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter sportsName");
            sportsName = Console.ReadLine();
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("score is " + score);
            Console.WriteLine("sportsName is " + sportsName);
        }
    }
    class Test : Sports
    {
        int[] marks = new int[3];
        protected int total = 0;
        public void Get()
        {
            base.Get();
            Console.WriteLine("Enter marks");
            for (int i = 0; i < 3; i++)
            {
                marks[i] = Convert.ToByte(Console.ReadLine());
                total += marks[i];
            }
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("total is " + total);
        }
    }

    class Result : Test
    {
        int finalscore;
        
        public void GetFinalScore()
        {
            finalscore = score + total;
            
        }
        public void DisplayFinalResult ()
        {
            Console.WriteLine("finalscore " + finalscore);
        }
    }
}
