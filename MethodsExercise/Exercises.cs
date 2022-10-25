using System;

namespace MethodsExercise
{
    public class Exercises
    {
        public static void Exercise1()
        {

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
            Console.WriteLine();

            Console.WriteLine($"Would you like a nice little store, {name}?");
            var story = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"There once was a person named {name} who lived in a {color} house that was three stories tall. {name} had two roomates. " +
            $"One was a kangaroo and the other was a {animal}. They enjoyed spending time together going to movies and concerts. {name} really enjoyed" +
                $" loud and aggressive rock concerts. One time they went to see {band} and {name} got rather rowdy in the pit. He channeled his spirit animal the {scaryAnimal}" +
                $" and opened the pit all the way up. Everyone was moshing and going wild. They all had a blast, but by the end {name} was all bruised up. It was totally worth it, he said. " +
                $" So they began their long walk home to their three story {color} castle.");
            Console.ReadLine();
        }

        public static void Exercise2()
        {
            var result = Add(10, 44);
            Console.WriteLine(result);

            var difference = Subtract(14, 19);
            Console.WriteLine(difference);

            var product = Multiply(34343, 2828);
            Console.WriteLine(product);

            var quotient = Divide(10, 2);
            Console.WriteLine(quotient);
        }

        public static void Exercise2_BOnus()
        {
            var paramsResult = (Add(1, 1, 1, 1, 1));
            Console.WriteLine(paramsResult);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Add(params int[] numbers)
        {
            //return array.Sum();
            int result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

    }
}

