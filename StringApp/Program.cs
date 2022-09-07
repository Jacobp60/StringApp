/*
 * String Interpolation Practice   
 * Author: Jacob Perez
 * Date: 09-06-2022
 * Class: .Net
 * 
 */




namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a date variable
            var date = DateTime.Now;
            // String Interpolation practice
            Console.WriteLine($"1.{date,40:MMMM d, yyyy}");
            Console.WriteLine($"2.{date:yyyy.MM.dd}");
            Console.WriteLine($"3.Day {date:dd} of {date:MMMM,yyyy}" );
            Console.WriteLine($"4.Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");
            Console.WriteLine($"5.{date,10:dddd}");
            Console.WriteLine($"6.{date,10:t}{date,10:dddd}");
            Console.WriteLine($"7.h:{date:hh}, m:{date:mm}, s:{date:ss}");
            Console.WriteLine($"8.{date:yyyy.MM.dd.HH.mm.ss}");

            //Last part is playing with Math.pi and String interpolation
            var pi1 = Math.PI;
            var pi2 = Math.PI;
            Console.WriteLine("---------------------");
            Console.WriteLine($"{pi1:C}");
            Console.WriteLine($"{pi2,10:N3}");

        }
    }
}