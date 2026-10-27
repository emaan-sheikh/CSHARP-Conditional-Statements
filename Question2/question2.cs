Console.WriteLine("Student Name: Emaan Sheikh");
Console.WriteLine("Student ID: 66465");
Console.WriteLine("Course ID: 120703");
Console.WriteLine("Submission date: 28th Oct 2026");



Console.WriteLine("Enter purchase amount: ");
/*amount input*/
double amount= Double.Parse(Console.ReadLine());
/*discount initialisation*/
int discount= 0;
/*discount conditions*/
/*condition 1*/
if(amount >=5000)
{
  discount = 20;
}
  /*condition 2*/
else if (amount >=2000 && amount < 5000)
{
  discount = 10;
/*condition 3*/
else
{
  discount = 0;
}
/*discount amount calculation*/
double discountAmount= amount*discount/100;
/*final amount calculation*/
double finalAmount = amount - discountAmount;
/*outputs*/
Console.WriteLine("Discount percentage: " + discount);
Console.WriteLine("Discount amount: " + discountAmount);
Console.WriteLine("Final payable amount: " + finalAmount);
