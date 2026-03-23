using System;
using DataType;
using VariableDefinition;

namespace CSharpCrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 我的第一个 C# 程序*/
            Console.WriteLine("Hello World");
            
            DataType.DataType.run();

            VariableDefinition.VariableDefinition.run();
            
            Console.ReadKey();
        }
    }
}