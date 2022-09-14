Console.WriteLine("----------------------------------------------");
Console.WriteLine("Enter the first number: ");
Console.WriteLine("----------------------------------------------");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Enter the second number: ");
Console.WriteLine("----------------------------------------------");
var b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");
int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"{a}/{b} is {quotient} remainder of {remainder}");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("----------------------------------------------");

Console.WriteLine("What is the radius of your circle ?");
Console.WriteLine("----------------------------------------------");
var radius = double.Parse(Console.ReadLine());
var area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("----------------------------------------------");
Console.WriteLine($"The area of your circle is: {area}");
Console.WriteLine("----------------------------------------------");