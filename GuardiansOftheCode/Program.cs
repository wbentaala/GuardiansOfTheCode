using System;

namespace GuardiansOftheCode
{
    class Program
    {
        static Person _person;
        static void Main(string[] args)
        {
            var player = PrimaryPlayer.Instance;
            Console.WriteLine($"Name : {player.Name} Level : {player.Level}");
            var student = StudentSingleton.Instance;
            Console.WriteLine($"Name: {student.Name}");
            if(int.TryParse("4", out int s))
                Console.WriteLine(s);
            var p = GetPersonInformations(new Person("wassim", 30));
            var p1 = p;
            Console.WriteLine($"p1: Name: {p.Name} Age: {p.Age}");
            p1.Age = 25;
            p1.Name = "Omar";
            Console.WriteLine($"p1: Name: {p.Name} Age: {p.Age}");
            Console.WriteLine($"p2: Name: {p1.Name} Age: {p1.Age}");

            new TestBenchmark().Fibonacci(5);

            Console.ReadKey();
        }

        static ref Person GetPersonInformations(Person person)
        {
            _person = person;
            return ref _person;
        }

    }
}
