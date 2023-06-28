class Program
{
    static void Main(string[] args)
    {
        // Get user input
        string name = UserInput("What is your name?");
        string favoriteColor = UserInput("What is your favorite color?");
        string favoriteAnimal = UserInput("What is your favorite animal?");
        string favoriteBand = UserInput("What is your favorite band?");

        string story = CreateStory(name, favoriteColor, favoriteAnimal, favoriteBand);

        Console.WriteLine();
        Console.WriteLine(story);

        // Call the add method
        int sum = Add(10, 5);
        Console.WriteLine("10 + 5 = {0}", sum);

        // Call the subtract method
        int difference = Subtract(10, 5);
        Console.WriteLine("10 - 5 = {0}", difference);

        // Call the multiply method
        int product = Multiply(10, 5);
        Console.WriteLine("10 * 5 = {0}", product);

        // Call the divide method
        int quotient = Divide(10, 5);
        Console.WriteLine("10 / 5 = {0}", quotient);

        // Call the modulus method
        int modulus = Modulus(10, 5);
        Console.WriteLine("10 % 5 = {0}", modulus);
    }

    static string UserInput(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
    }

    static string CreateStory(string name, string favoriteColor, string favoriteAnimal, string favoriteBand)
    {
        // Create a story using string interpolation
        return $"Once upon a time, there was a person named {name} who loved the color {favoriteColor}. They had a pet {favoriteAnimal} and their favorite band was {favoriteBand}.\n";

    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }

    static int Modulus(int a, int b)
    {
        return a % b;
    }
}

