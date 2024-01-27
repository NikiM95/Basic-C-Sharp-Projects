using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Daily Report Assignment Submission

        Console.WriteLine("Pitman Training \n" + "Student Daily Report");
        Console.ReadLine();

        Console.WriteLine("What course are you in? ");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number? ");
        string pageNum = Console.ReadLine();

        //bool helpNeeded = true;
        //Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
        //string answer = Convert.ToString(helpNeeded);
        //Console.ReadLine();

        Console.Write("Were there any positive experiences you’d like to share? Please provide specifics: ");
        string experience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific: ");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today? ");
        string hoursStudy = Console.ReadLine();

        Console.WriteLine("Thank you for your responses. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();

    }
}

