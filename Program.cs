using System;

namespace MultiLevelInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            result.Get();
            result.GetFinalScore();
            result.Display();
            result.DisplayFinalResult();
            
        }
    }
}
