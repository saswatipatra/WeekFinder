using System;

public class Example
{
   public static void Main()
   {
       Console.WriteLine("Enter the year ");
       int year = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter the date ");
       int date = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter the month ");
       int month = int.Parse(Console.ReadLine());
      DateTime dateValue = new DateTime(year,month,date);
      Console.WriteLine(dateValue.ToString("dddd"));    
   }
}
