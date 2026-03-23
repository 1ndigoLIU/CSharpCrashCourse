using System;
namespace VariableDefinition
{
    class VariableDefinition
    {
        class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;
            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
        
        public static void run()
        {
            // 变量定义 <data_type> <variable_list>;
            int i, j, k;
            char c, ch;
            float f, salary;
            double d;
            
            // 命名规则
            int myVariable = 10;
            string _userName = "John";
            
            // 变量初始化 <data_type> <variable_name> = value;
            int d1 = 3, f1 = 5;    /* 初始化 d 和 f. */
            byte z1 = 22;         /* 初始化 z. */
            double pi = 3.14159; /* 声明 pi 的近似值 */
            char x = 'x';        /* 变量 x 的值为 'x' */
            
            // 变量示例
            short a;
            int b ;
            double c1;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c1 = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c1);
            
            // 常量: 使用 const 关键字来定义
            SampleClass mC = new SampleClass(11, 22);
            Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
            Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
        }
    }
}