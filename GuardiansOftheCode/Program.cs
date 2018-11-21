using System;

namespace GuardiansOftheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = PrimaryPlayer.Instance;
            Console.WriteLine($"Name : {player.Name} Level : {player.Level}");
            var student = StudentSingleton.Instance;
            Console.WriteLine($"Name: {student.Name}");
            Console.ReadKey();
        }
    }
}
