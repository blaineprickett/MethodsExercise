namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            _ = Sum(2, 6);


            // Q & A - Exercise 1

            Console.WriteLine("Hello, what is your name?");
                var name = Console.ReadLine();
            Console.WriteLine($"It's very nice to meet you, {name}.");
            Console.ReadLine();
            Console.WriteLine($"What is your favorite color, {name}");
                var color = Console.ReadLine();
            Console.WriteLine($"What about your favorite animal, {name}");
                var animal = Console.ReadLine();
            Console.WriteLine("What is one animal that you think is scary?");
                var scaryAnimal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band?");
                var band = Console.ReadLine();
            Console.WriteLine("Here is a fun little story for you.");

            // Fun Story 

            Console.WriteLine($"There once was a person named {name} who lived in a {color} house that was three stories tall. {name} had two roomates. " +
                $"One was a kangaroo and the other was a {animal}. They enjoyed spending time together going to movies and concerts. {name} really enjoyed" +
                $" loud and aggressive rock concerts. One time they went to see {band} and {name} got rather rowdy in the pit. He channeled his spirit animal the {scaryAnimal}" +
                $" and opened the pit all the way up. Everyone was moshing and going wild. They all had a blast, but by the end {name} was all bruised up. It was totally worth it, he said. " +
                $" So they began their long walk home to their three story {color} castle.");
            Console.ReadLine();

            // Exercise 2




        }

    }
}