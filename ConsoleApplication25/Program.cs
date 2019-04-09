using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    //使用泛型的栈的示例


    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> StackInt = new MyStack<int>();    //创建构造类，并实例化
            MyStack<string> StackString = new MyStack<string>();

            StackInt.Push(3);
            StackInt.Push(5);
            StackInt.Push(7);
            StackInt.Push(9);
            StackInt.Print();

            StackString.Push("This is fun");
            StackString.Push("Hi there! ");
            StackString.Print();

            Console.ReadKey();

        }
    }

    class MyStack<T>
    {
        T[] StackArray; //泛型数组
        int StackPointer = 0;   //栈初始点
        const int MaxStack = 10;   //栈容量

        bool IsStackFull { get { return StackPointer >= MaxStack; } } //栈是否满
        
        bool IsStackEmpty { get { return StackPointer <= 0; } }   //栈是否空
        
        public void Push(T x)    //入栈
        {
            if (!IsStackFull)     //判断栈是否满
            {
                StackArray[StackPointer++] = x;   //赋值
                
            }
        
        }
        public T Pop()  //出栈
        {
            return (!IsStackEmpty)  //判断栈是否为空
                ? StackArray[--StackPointer]
                : StackArray[0];
        
        }

        public MyStack()  //构造
        {
            StackArray = new T[MaxStack];
        }

        public void Print()
        {
            for (int i = StackPointer-1; i >=0; i--)
            {
                Console.WriteLine("     Value:{0}", StackArray[i]);
            }
        }
    }
}
