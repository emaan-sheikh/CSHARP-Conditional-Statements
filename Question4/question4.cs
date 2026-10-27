Console.WriteLine("Enter first number: ");
double num1=double.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
double num2= double.Parse(Console.ReadLine());
Console.WriteLine("Enter operator(+,-,*,/): ");
char op= char.Parse(Console.ReadLine());

switch (operator)
{
  case '+':
Console.WriteLine(num1 + num2);
break;
case '-':
Console.WriteLine(num1 - num2);
break;
case '*':
Console.WriteLine(num1 * num2);
break;
case '/':
Console.WriteLine(num1 / num2);
break;
default:
Console.WriteLine("Invalid operator.");
break;
}
