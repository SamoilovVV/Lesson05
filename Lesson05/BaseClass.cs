using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    public class BaseClass
    {
        public int PublicValue { get; set; }

        protected int ProtectedValue { get; set; }

        internal int InternalValue { get; set; }

        protected internal int ProtectedInternalValue { get; set; }

        private protected int PrivateProtectedValue { get; set;}
    }

    class Derived : BaseClass
    {
        public Derived()
        {
           Console.WriteLine(PrivateProtectedValue);
        }
    }
    internal class AnotherBaseClass
    {
        public int PublicValue { get; set; }

        public int ProtectedValue { get; set; }

        internal int InternalValue { get; set; }

        protected internal int ProtectedInternalValue { get; set; }

        private protected int PrivateProtectedValue { get; set; }
    }
}
