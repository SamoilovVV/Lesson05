using System;
using System.Collections.Generic;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInterfaces();
            //NullChecking();
            //Casts();
            //ObjectToString();
            //WorkingWithTypes();
            //ObjectsReferenceEquality();
            //ObjectsValueEquality();
            //UserConversions();
            //WorkingWithStructures();
            //Modificators();
            //TestRecords();
            //TestStaticMembers();

            //TestNonGenerics();
            //TestGenerics();
            //TestStaticGenerics();
            //TestGenericMethods();

            //TestStaticGenerics2();

        }

        public static void NullChecking()
        {
            
            ShowPersonName2(null);
            Person p = new Person("Елена", 25);
            ShowPersonName2(p);
        }

        public static void ShowPersonName(Person person)
        {
            //string personName = "Неизвестно";
            //if (person != null)
            //{
            //    personName = person.Name;
            //}
            //string personName = person?.Name;

            Console.WriteLine($"Имя: {person?.Name}");
        }

        public static void ShowPersonName2(Person person)
        {
            //string personName = "Неизвестно";
            //if (person != null)
            //{
            //    personName = person.Name;
            //}

            string personName = person?.Name ?? "Неизвестно";

            Console.WriteLine($"Имя: {personName}");
        }

        public static void Casts()
        {
            object p = new Soldier("Коля", 18, "ВДВ"); // Упаковка

            var pp = (Person)p; // Распаковка

            var person = p as Person;
            if (person != null)
            {
                Console.WriteLine(person.Name);
            }

            if (p is Person)
            {
                var person1 = (Person)p;
                Console.WriteLine(person1.Name);
            }

            if (p is Person person2)
            {
                Console.WriteLine(person2.Name);
            }

            object a = 3;
            if (a is int i)
            {
                Console.WriteLine(i);
            }
        }

        static void ObjectToString()
        {
            // ToString
            Person person = new Person("Вася", 20);
            Console.WriteLine($"Переопределение ToString: {person}");

            Console.WriteLine($"Базовый ToString: {person.ToString(useDefaultImplementation: true)}");

            Console.WriteLine($"Type: {person.GetType()}"); 
        }

        static void WorkingWithTypes()
        {
            object p = new Sportsman("Коля", 18, "Баскетбол");
            Console.WriteLine($"Type: {p.GetType()}");

            if (p.GetType() == typeof(Soldier))
            {
                Console.WriteLine("Объект p класса Soldier");
            }
            else if (p.GetType() == typeof(Person))
            {
                Console.WriteLine("Объект p класса Person");
            }
            else if (p.GetType() == typeof(Sportsman))
            {
                Console.WriteLine("Объект p класса Sportsman"); // Сработает этот вариант
            }

            if (p is Soldier)
            {
                Console.WriteLine("Объект p класса Soldier");
            }
            else if (p is Person)
            {
                Console.WriteLine("Объект p класса Person"); // Сработает этот вариант
            }
            else if (p is Sportsman)
            {
                Console.WriteLine("Объект p класса Sportsman");
            }

            var soldier = new Soldier("Вова", 21, "ВДВ");
            var sportsman = new Sportsman("Пётр", 22, "баскетбол");
            SwitchWithWhenStatement(p as Person);
            SwitchWithWhenStatement(soldier);
            SwitchWithWhenStatement(sportsman);
        }

        private static void SwitchTypeStatement(Person person)
        {
            switch (person)
            {
                case Soldier soldier:
                    Console.WriteLine($"{person.Name} — солдат, служит в {soldier.Army}");
                    break;
                case Sportsman sportsman:
                    Console.WriteLine($"{person.Name} — спортсмен, занимается {sportsman.Sport}");
                    break;
                case null:
                    Console.WriteLine("Произошла трагическая ошибка!\nЧеловека не существует.");
                    break;
                default:
                    Console.WriteLine($"{person.Name} обычный человек");
                    break;
            }
        }

        private static void SwitchWithWhenStatement(Person person)
        {
            switch (person)
            {
                case Person p when string.IsNullOrWhiteSpace(p.Name):
                    Console.WriteLine("Обнаружен человек без имени!");
                    break;
                case Soldier soldier when string.IsNullOrEmpty(soldier.Army):
                case Sportsman sportsman when string.IsNullOrWhiteSpace(sportsman.Sport):
                    Console.WriteLine("Неверно заполнены данные!");
                    break;

                case Soldier soldier:
                    Console.WriteLine($"{person.Name} — солдат, служит в {soldier.Army}");
                    break;
                case Sportsman sportsman:
                    Console.WriteLine($"{person.Name} — спортсмен, занимается {sportsman.Sport}");
                    break;
                case null:
                    Console.WriteLine("Произошла трагическая ошибка!\nЧеловека не существует.");
                    break;
                default:
                    Console.WriteLine($"{person.Name} обычный человек");
                    break;
            }
        }

        static void ObjectsReferenceEquality()
        {
            Person person1 = new Person("Вася", 21);
            Person person2 = new Person("Вася", 21);
            CheckPersonsRefEquality(person1, person2);
            Person person3 = person1;
            CheckPersonsRefEquality(person1, person3);
        }

        static void CheckPersonsRefEquality(Person person1, Person person2)
        {
            Console.WriteLine(person1 != person2 
                ? $"{person1} не {person2}" 
                : $"{person1} и {person2} - один и тот же человек");
        }

        static void ObjectsValueEquality()
        {
            Person person1 = new Person("Вася", 21);
            Person person2 = new Person("Вася", 21);
            CheckPersonsValEquality(person1, person2);
            Person person3 = person1;
            CheckPersonsValEquality(person1, person3);
        }

        static void CheckPersonsValEquality(Person person1, Person person2)
        {
            Console.WriteLine(object.Equals(person1, person2)
                ? $"{person1} и {person2} - один и тот же человек" 
                : $"{person1} не {person2}");
        }

        public static void UserConversions()
        {
            var counter1 = new Counter { Seconds = 25 };

            int x = (int)counter1;
            Console.WriteLine(x);

            x += 25;
            Counter counter2 = x;
            Console.WriteLine(counter2.Seconds);
        }

        public static void WorkingWithStructures()
        {
            var timer1 = new Timer();

            var timer2 = new Timer(1, 30, 25);
        }

        public static void Modificators()
        {
            Console.WriteLine(MathLib.PI);

            const double PI = 3.14;
            Console.WriteLine(PI);

            //MathLib math = new MathLib();
            //Console.WriteLine(math.K);
        }

        public static void TestRecords()
        {
            var person = new PersonRecord
            {
                Name = "Вася",
                Age = 27
            };

            Console.WriteLine(person);

            var anotherPerson = person;
            Console.WriteLine(anotherPerson);

            CheckPersonsEquality(person, anotherPerson);

            var someOtherPerson = person with { Name = "Петя" };
            Console.WriteLine(someOtherPerson);

            CheckPersonsEquality(person, someOtherPerson);

            var newPerson = new PersonRecord()
            {
                Name = "Петя",
                Age = 27
            };

            Console.WriteLine(newPerson);

            CheckPersonsEquality(newPerson, someOtherPerson);
        }

        private static void CheckPersonsEquality(PersonRecord pr1, PersonRecord pr2)
        {
            Console.WriteLine(pr1 == pr2 ? "Это один и тот же человек" : "Это разные люди" );
        }

        public static void TestStaticMembers()
        {
            Console.WriteLine(Account.Bonus);      // 100
            Account.Bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.TotalSum);   // 450

            Account.Bonus -= 100;
            Account account2 = new Account(1000);
            Console.WriteLine(account2.TotalSum);   // 1200

            Console.ReadKey();
        }

        public static void TestInterfaces()
        {
            var person = new Interfaces.Person();

            Console.WriteLine(person.Name);

            var human = person as Interfaces.IHuman;
            Console.WriteLine(human.Name);
        }

        public static void TestNonGenerics()
        {
            var user1 = new User
            { Id = 1, Name = "Вася", Age = 25 };

            var user2 = new User
            { Id = "5556", Name = "Алёна", Age = 22 };

            int id1 = (int)user1.Id;
            Console.WriteLine(id1);

            string id2 = user2.Id as string;
            Console.WriteLine(id2);
        }

        public static void TestGenerics()
        {
            var user1 = new User<int> 
            { Id = 1, Name = "Вася", Age = 25 };

            var user2 = new User<string>
            { Id = "5556", Name = "Алёна", Age = 22 };

            var id1 = user1.Id;
            Console.WriteLine(id1);

            string id2 = user2.Id;
            Console.WriteLine(id2);
        }

        public static void TestStaticGenerics()
        {
            SessionUser<int>.Session = 555;
            var user1 = new SessionUser<int>
            { Id = 1, Name = "Вася", Age = 25 };

            var user2 = new SessionUser<string>
            { Id = "5556", Name = "Алёна", Age = 22 };
            SessionUser<string>.Session = "777";

            Console.WriteLine(SessionUser<int>.Session);
            Console.WriteLine(SessionUser<string>.Session);
        }

        public static void TestStaticGenerics2()
        {
            AdvancedSessionUser<int, string>.Session = 555;

            var user = new AdvancedSessionUser<int, string>
            { Id = "1", Name = "Вася", Age = 25 };

            Console.WriteLine($"User Id{user.Id} in" +
                $" session {AdvancedSessionUser<int, string>.Session}");

            List<int> list1 = new List<int> { 1, 2, 3 };
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
        }

        public static void TestGenericMethods()
        {
            int x = 3;
            int y = 99;
            Console.WriteLine($"ДО: x={x}\t y={y}");
            Swap<int>(ref x, ref y); 
            Console.WriteLine($"ДО:x={x}\t y={y}");

            string s1 = "hello";
            string s2 = "bye";
            Console.WriteLine($"ДО:s1={s1}\t s2={s2}");
            Swap<string>(ref s1, ref s2); 
            Console.WriteLine($"ПОСЛЕ: s1={s1}\t s2={s2}");

            SwapValueTypes(ref x, ref y);
            Console.WriteLine($"ПОСЛЕ:x={x}\t y={y}");
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void SwapValueTypes<T>(ref T x, ref T y) where T : struct
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
