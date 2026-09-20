Console.Write("Hello!");

bool exit = false;


while (!exit)
{
    Console.WriteLine("\nInput the first number");
    int firstNumber = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Input the second number");
    int secondNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("What do you want to do with these numbers?");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");
    string method = Console.ReadLine().ToLower();

    int result;
    switch (method)
    {
        case "a":
            result = firstNumber + secondNumber;
            printEquation(firstNumber, secondNumber, "+", result);
            break;
        case "s":
            result = firstNumber - secondNumber;
            printEquation(firstNumber, secondNumber, "-", result);
            break;
        case "m":
            result = firstNumber * secondNumber;
            printEquation(firstNumber, secondNumber, "*", result);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void printEquation(int firstNumber, int secondNumber, string @operator, int result)
{
    Console.WriteLine(firstNumber + " " + @operator + "  " +  secondNumber + " = " + result);
}