using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        YearDate yd = new YearDate(6);
        Console.WriteLine(yd.Day.ToString());
        yd.Day = 5;
        Console.WriteLine(yd.Day.ToString());
        Console.WriteLine("Month");
        Console.WriteLine(yd.Month.ToString());
        yd.Month = 9;
        Console.WriteLine(yd.Month.ToString());
    }
}

class YearDate
{
    public YearDate(int i = 4)
    {
        Day = i;
        Month = 8;
    }
    
    public int Day; //{get;set;}
    public int Month {get;set;}
    
}