using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
          
          

            try
            {

                /*** User input 1*/


                Console.Write("Enter The Present Date  In This Format .. Month - Day - Year  " + "\n" + "\n" + " You Enter For  Date1:  " );   // prompt user to enter date1

                DateTime inputDate1 = DateTime.Parse(Console.ReadLine());   //user input date1 

                Console.WriteLine("\n");   //indenting line

                /*** End User input 1*/





                /***  User Input 2*/

                Console.Write("\n" + " Enter The Past Date  In This Format .. Month - Day - Year   - Year " + "\n" + "\n" + " You  Enter For Date2:  "); // prompt user to enter date 2

                DateTime inputDate2 = DateTime.Parse(Console.ReadLine());   //user inputDate2  

                Console.WriteLine("\n");   //indenting line

                /*** End  User Input 2*/




                Console.WriteLine("\n");   //indenting line

                Console.Write(" Time Difference between " + inputDate1.ToString() + " and " + inputDate2.ToString() + "\n");   /* Displaying  the time differences */

                Console.WriteLine("\n");  //indenting line



                /*** calculating the differences between Year,Month,Days,Hours,Minutes,Seconds,Milliseconds ***/

                TimeSpan differenceOfTime = inputDate1 - inputDate2;  // calculating date1 and date2 time difference


                int yearDifference = (int)(differenceOfTime.Days / 365.25);   //  calculate the years in leap years

                int monthDifference = (int)(differenceOfTime.Days / 30);      //  calculate the month difference


                Console.WriteLine(" Year Difference  = " + yearDifference.ToString() + " Years " + "\n");  //   year difference 

                Console.WriteLine(" Month  Difference  = " + monthDifference.ToString() + " Months " + "\n");  //    month  difference 

                Console.WriteLine(" Day  Difference  = " + differenceOfTime.TotalDays.ToString() + " Days " + "\n");  //  days difference

                Console.WriteLine(" Hours  Difference  = " + differenceOfTime.TotalHours.ToString() + " Hours " + "\n");  //   hours difference

                Console.WriteLine(" Minutes Difference = " + differenceOfTime.TotalMinutes.ToString() + " Minutes" + "\n");  //  minutes difference

                Console.WriteLine(" Seconds  Difference  = " + differenceOfTime.TotalSeconds.ToString() + " Seconds " + "\n");  // seconds difference

                Console.WriteLine(" Milliseconds  Difference  = " + differenceOfTime.TotalMilliseconds.ToString() + " MilliSeconds" + "\n");  //  milliseconds difference

                Console.WriteLine("Push Enter To Restart Application");

                Console.ReadLine();


            }
            catch  // there also others ways of handling errors by using RegularExpression but I want to keep it simple for now
            {

             Console.WriteLine("\n");

             Console.WriteLine("1.Theres An Error.Please Enter The Month -Day - Year in this format Month-Day-Year");

             Console.WriteLine(  "\n");

             Console.WriteLine("2.Enter A Valid Date");

             Console.WriteLine("\n");

             Console.WriteLine("3.No Letters,Space or Any Characters Allowed");

             Console.WriteLine("\n");

             Console.WriteLine("Press Enter To Restart  Applications"); 
              

            }

            Console.ReadLine();

        }
           
            
    }
}
