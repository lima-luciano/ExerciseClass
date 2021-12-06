using System;

namespace ExerciseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalData p1, p2;

            p1 = new PersonalData();
            p2 = new PersonalData();

            Console.WriteLine("First person personal data");
            p1.name = Console.ReadLine();
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Person personal data");
            p2.name = Console.ReadLine();
            p2.age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("First person data");
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.WriteLine("Second person data");
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.age);

            if (p1.age > p2.age)
            {
                Console.WriteLine("Older person is: " + p1.name);
            }
            else
            {
                Console.WriteLine("Older person is: " + p2.name);
            }

        }
    }
}
