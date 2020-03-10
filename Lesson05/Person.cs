using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Person Name: {Name}  Age: {Age}";
        }

        public string ToString(bool useDefaultImplementation)
        {
            return useDefaultImplementation ? base.ToString() : this.ToString();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            if (!(obj is Person other))
                return false;


            return Name == other.Name &&
                   Age == other.Age;
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0 ^
                   Age;
        }

        public static bool operator ==(Person first, Person second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !Equals(first, second);
        }

        private static bool Equals(Person first, Person second)
        {
            return first?.Equals(second) ?? (object)first == (object)second;
        }

    }

    public class Sportsman : Person
    {
        public string Sport { get; set; }

        public Sportsman() { }

        public Sportsman(string name, int age, string sport) : base(name, age)
        {
            Sport = sport;
        }

        public void Run()
        {
            Console.WriteLine("Run Forest, Run!");
        }

        public override string ToString()
        {
            return $"Sportsman Name: {Name}  Age: {Age} Sport {Sport}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Sportsman other))
                return false;

            if (!base.Equals(obj))
                return false;

            return Sport == other.Sport;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^
                   Sport?.GetHashCode() ?? 0;
        }
    }

    public class Soldier : Person
    {
        public string Army { get; set; }

        public Soldier() { }

        public Soldier(string name, int age, string army) : base(name, age)
        {
            Army = army;
        }

        public void Shoot()
        {
            Console.WriteLine("Shoot them all!");
        }

        public override string ToString()
        {
            return $"Soldier Name: {Name}  Age: {Age} Army {Army}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Soldier other))
                return false;

            if (!base.Equals(obj))
                return false;

            return Army == other.Army;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^
                   Army?.GetHashCode() ?? 0;
        }
    }
}
