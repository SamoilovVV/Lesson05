using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    public class User
    {
        public object Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class User<T>
    {
        public T Id { get; set; } = default;

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SessionUser<T> 
    {
        public static T Session { get; set; }

        public T Id { get; set; } = default;

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class AdvancedSessionUser<T, U>
    {
        public static T Session { get; set; }

        public U Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Transaction<T> where T : Person, Interfaces.IHuman, new()
    {

    }

    public class AnotherUser<T> : User
    {

    }

    public class UnknownUser<T> : User<T>
    {

    }

    public class KnownUser<T> : User<string>
    {

    }

    public class ConcreteUser : User<int>
    {

    }
}
