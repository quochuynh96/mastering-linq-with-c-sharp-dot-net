using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MasteringLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init IEnumerable
            var a = Enumerable.Empty<int>();
            var b = Enumerable.Repeat(0, 100);
            var c = Enumerable.Range(0, 100);

            // Cast
            var d = new ArrayList();
            d.Add(1);
            d.Add(2);
            d.Add(3);
            d.Add(4);
            // Console.WriteLine(d.Cast<int>().Sum());

            // To
            var e = b.ToArray();
            //var f = b.ToDictionary(x => x, y => y);

            // As
            var g = new[] { 1, 2, 3 };
            var h = g.AsEnumerable();

            // Select
            var i = "This is nice sentence";
            //i.Split().Select(w => new {Word = w, Size = w.Length}).Print();

            //Enumerable.Range(0, 10).Select(_ => 10).Print();
            var j = new[] { "This is nice sentence", "is nice sentence", "This is sentence" };
            //j.Select(s => s.Split()).Print();

            // SelectMany
            var k = new[] { "a", "b", "c", "d" };
            var l = new[] { "1", "2", "3", "4" };

            //k.SelectMany(_ => l, (k1,l1) => $"{k1} {l1}").Print();

            // OfType
            object[] m = { 1, 2.2, 3.3, 4, 5.4, 6, 7, 89, "test", "of" };
            //m.OfType<int>().Print();
            //m.OfType<double>().Print();
            //m.OfType<string>().Print();

            // OrderBy
            var n = Enumerable.Range(0, 10).Select(_ => (new Random()).Next(100));
            var joinNumber = new Func<IEnumerable<int>, string>(values => string.Join(",", values.ToArray()));
            IOrderedEnumerable<int> o = n.OrderBy(x => x);
            //IOrderedEnumerable<int> o = n.OrderByDescending(x => x);
            //joinNumber(o).Print();

            //ThenBy
            var u = new[]
            {
                new Person("Adam", 90),
                new Person("Adam", 30),
                new Person("Adam", 50),
                new Person("Levi", 20),
                new Person("Luis", 47),
                new Person("John", 20),
                new Person("Lane", 20),
                new Person("Steve", 20)
            };

            //u.OrderBy(p => p.Name)
            //    .ThenBy(p => p.Age)
            //    .Print();

            // Reverse
            //(new string(i.Reverse().ToArray())).Print();

            // GroupBy
            //u.GroupBy(p => p.Name);
            //u.GroupBy(p => p.Age < 30);
            var v = u.GroupBy(p => p.Age, p => p.Name);
            //foreach (var item in v)
            //{
            //    Console.WriteLine($"There people are {item.Key} years old: ");
            //    foreach (var name in item)
            //    {
            //        Console.WriteLine($"- {name}");
            //    }
            //}

            // Distinct
            var t = "HheElllllllllllllllllllllloooooooooooooooooooooooo";
            //(new string(t.Distinct().ToArray())).Print();

            // Intersect
            var y = "help";
            //t.Intersect(y).Print();
            //t.Union(y).Print();
            //t.Except(y).Print();

            var x = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Console.WriteLine("Are all numbers > 0?" + x.All(x1 => x1 > 0));
            // Console.WriteLine("Are all numbers > 2?" + x.All(x1 => x1 > 2));
            // Console.WriteLine(x.Any(x1 => x1 > 2));
            // Console.WriteLine(x.Contains(2));


            // Join and GroupJoin
            var people = new Person[]
            {
                new Person("Jane",10),
                new Person("John",20),
                new Person("Chris",30),
                new Person("Rudy",40),
                new Person("Kane",50)
            };

            var emails = new Email[]
            {
                new Email("Jane", "jane1@gmail.com"),
                new Email("Jane", "jane2@gmail.com"),
                new Email("Jane", "jane3@hotmail.com"),
                new Email("Chris", "chris@mail.com"),
                new Email("Kane", string.Empty)
            };

            //people.Join(emails,
            //    x => x.Name,
            //    y => y.Name,
            //    (p, m) => new { Name = p.Name, Age = p.Age, Mail = m.EmailAddress })
            //    .Print();

            //people.GroupJoin(emails,
            //    x => x.Name,
            //    y => y.Name,
            //    (p, m) => new { Name = p.Name, Email = m.Select(n => n.EmailAddress).ToList() })
            //    .Print();

            // SequenceEqual
            var z = new int[] { 1, 2, 3 };
            var w = new int[] { 1, 2, 3 };
            var a1 = new int[] { 1, 2, 3 };
            Console.WriteLine(z == w);
            Console.WriteLine(z.Equals(w));
            Console.WriteLine(z.SequenceEqual(w));
            Console.WriteLine(z.SequenceEqual(a1));

            // In NUnit we have Assert.That(z, Is.EqualTo(w)); => PASS
            // If we want to ignore the order of list, use Is.EquivalentTo 
        }
    }
}
