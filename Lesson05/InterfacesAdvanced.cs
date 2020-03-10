using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05.Interfaces
{
    interface IHuman
    {
        static string _moveString = "Move";

        string Name { get; set; }

        void Move()
        {
            Console.WriteLine(_moveString);
        }

        void Run();
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    public class Person : IHuman, IPerson
    {
        string IHuman.Name { get; set; } = "Вася";

        public string Name { get; set; } = "Василий Петрович";

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }

        public void Run()
        {
            Console.WriteLine("Я не умею бегать");
        }
    }
}
