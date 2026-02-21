using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your monthly fee:");
        double monthlyFee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter days to late:");
        int daysLate = Convert.ToInt32(Console.ReadLine());
        if(daysLate == 0)
        {
            Console.WriteLine("tax is 0$");
            double t_fee = monthlyFee + 0;
            Console.WriteLine("total fee is:" + t_fee+"$");
        }
        else if (daysLate == 1 | daysLate == 2 | daysLate == 3)
        {
            Console.WriteLine("tax is 1$");
            double t_fee = monthlyFee + 1;
            Console.WriteLine("total fee is:"+t_fee+"$");
        }
        else if(daysLate == 4 | daysLate == 5 | daysLate == 6)
        {
            Console.WriteLine("tax is 2$");
            double t_fee = monthlyFee + 2;
            Console.WriteLine("total fee is:" + t_fee+"$");
        }
        else if(daysLate > 6)
        {
            Console.WriteLine("tax is 3$");
            double t_fee = monthlyFee + 3;
            Console.WriteLine("total fee is:" + t_fee+"$");
        }
    }
}
