//Using implicits

using System.Diagnostics;

int firstNumber;
int secondNumber;
string operation;
int result;

Console.WriteLine("Welcome to my calculator");

Console.WriteLine("Enter the first number");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You entered: " + firstNumber);

Console.WriteLine("What type of operation would you like to do?");
Console.WriteLine("Enter a for addition");
Console.WriteLine("Enter s for subtraction");
Console.WriteLine("Enter m for multiplication");
Console.WriteLine("Enter d for division");
operation = Console.ReadLine();
Console.WriteLine("You chose: " + operation);

Console.WriteLine("Enter the second number");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You entered: " + secondNumber);

switch(operation)
    {
    case "a":
        result = firstNumber + secondNumber;
        break;
    case "s":
        result = firstNumber - secondNumber;
        break;
    case "m":
        result = firstNumber * secondNumber;
        break;
    case "d":
        result = firstNumber / secondNumber;
        break;
    default:
        result = secondNumber; 
        break;
}
Console.WriteLine("The result is: " + result);
Console.ReadKey();