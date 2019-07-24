using System;

namespace WeekDay.Models
{
    public class DayConvertor
    {
        public static bool IsLeapYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // public static Dictionary<string, int> monthKey = new Dictionary<string, int>() { {"Jan", 1}, {"Feb", 4}, {"Mar", 4}, {"Apr", 0}, {"May", 2}, {"June", 5}, {"July", 0}, {"Aug", 3}, {"Sept", 6}, {"Oct", 1}, {"Nov", 4}, {"Dec", 6} };



    }
}