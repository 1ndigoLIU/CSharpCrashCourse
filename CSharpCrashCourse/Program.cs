using System;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /* 我的第一个 C# 程序*/
            Console.WriteLine("Hello World");
            
            // 值类型
            // sizeof: 字节长度(1字节=8bits)
            Console.WriteLine("Size of int: {0}", sizeof(int));
            
            //引用类型
            object obj;
            obj = 100; // 装箱 boxing: 当一个值类型转换为对象类型时，被称为 装箱
            int num = (int)obj; // 拆箱: 当一个对象类型转换为值类型时，被称为 拆箱
            Console.WriteLine("Value of num: " + num);
            
            Console.ReadKey();
        }
    }
}