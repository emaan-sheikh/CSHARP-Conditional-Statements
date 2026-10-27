Console.WriteLine("Name: Emaan Sheikh");
Console.WriteLine("Student ID: 66465");
Console.WriteLine("Class ID: 120703");
Console.WriteLine("Submission date: 27th Oct 2026");
/*declaring variable*/
int day;
Console.WriteLine("Enter a number (1-7) to check the day: ");
day = int.Parse(Console.ReadLine());
/*Conditional statement*/
switch (day)
{
    /*when user enters 1*/
  case 1:
    Console.WriteLine("Monday");
    break;
    /*when user enters 2*/
  case 2:
    Console.WriteLine("Tuesday");
    break;
    /*when user enters 3*/
  case 3:
    Console.WriteLine("Wednesday");
    break;
    /*when user enters 4*/
  case 4:
    Console.WriteLine("Thursday");
    break;
    /*when user enters 5*/
  case 5:
    Console.WriteLine("Friday");
    break;
    /*when user enters 6*/
  case 6:
    Console.WriteLine("Saturday");
    break;
    /*when user enters 7*/
  case 7:
    Console.WriteLine("Sunday");
    break;
    /*when user enters any number other than 1-7*/
  default:
    Console.WriteLine("Invalid number");
    break;
}
/*program ends*/
