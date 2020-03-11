using System;

using Lesson05;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseClass classFromLesson05 = new BaseClass();

            Console.WriteLine(classFromLesson05.PublicValue);
        }
    }
    
    class Derived : BaseClass
    {
        public Derived()
        {
            Console.WriteLine(ProtectedInternalValue);
        }
    }
}
