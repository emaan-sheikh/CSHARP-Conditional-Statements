Console.WriteLine("Student Name: Emaan Sheikh");
Console.WriteLine("Student ID: 66465");
Console.WriteLine("Course ID: 120703");
Console.WriteLine("Submission date: 28th Oct 2026");

Console.WriteLine("Student Name: Emaan Sheikh");
Console.WriteLine("Student ID: 66465");
Console.WriteLine("Course ID: 120703");
Console.WriteLine("Submission date: 28th Oct 2026");

Console.WriteLine("Enter any year to check if it is leap year or not: ");
/*declaration and user input*/
int year= int.Parse(Console.ReadLine());

/*leap year special condition*/
/*divisible by 400*/
if(year % 400==0)
{
  Console.WriteLine("It is a leap year.");
}
/*divisible by 100*/
else if (year % 100 == 0)
{
  Console.WriteLine("It is not a leap year.");
}
/*divisible by 4*/
else if (year % 4 == 0)
{
  Console.WriteLine("It is a leap year.");
}
else
{
  Console.WriteLine("It is not a leap year.");
}
