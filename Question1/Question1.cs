Console.WriteLine("Name: Emaan Sheikh");
Console.WriteLine("Student ID: 66465");
Console.WriteLine("Class ID: 120703");
Console.WriteLine("Submission date: 27th Oct 2026");
int day;
Console.WriteLine("Enter a number (1-7) to check the day: ");
day = int.Parse(Console.ReadLine());
switch (day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
    Console.WriteLine("Invalid number");
    break;
}
