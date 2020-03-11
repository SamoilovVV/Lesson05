using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    public record PersonRecord
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public override string ToString()
        {
            return $"Person Name: {Name}  Age: {Age}";
        }
    }
}
