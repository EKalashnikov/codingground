//Ways to define properties
using System.IO;
using System;

class YearDate
{
    public YearDate(int i = 4)
    {
        Day = i;
        Month = 8;
        Year = 2014;
    }
    
    public int Day; //public variable instead of property
    public int Month {get;set;} //simpliest way to difine propery
    private int year;// here and below full way to define the property
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }
    
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Day");
        YearDate yd = new YearDate(6);
        Console.WriteLine(yd.Day.ToString());
        yd.Day = 5;
        Console.WriteLine(yd.Day.ToString());
        
        Console.WriteLine("Month");
        Console.WriteLine(yd.Month.ToString());
        yd.Month = 9;
        Console.WriteLine(yd.Month.ToString());
        
        Console.WriteLine("Year");
        Console.WriteLine(yd.Year.ToString());
        yd.Year = 2016;
        Console.WriteLine(yd.Year.ToString());
    }
}

