using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        // ** LISTS **
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //List<string> stringList = new List<string>();
        //stringList.Add("Hello");
        //stringList.Add("Niki");
        //stringList.Remove("Niki");

        //Console.WriteLine(stringList[0]);
        //Console.ReadLine();
        // -----------------------------------------------------------------------------------------------------------------------------------------

        // ** ARRAYS ** > use when have a fixed amount that wont change // when storing very large amounts use >> byte[] byteArray = new byte[5050];
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        // OR
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        // OR
        //int[] numArray2 = { 5, 2, 10, 200, 500, 600, 2300 };

        // to change a number in the array
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        // -----------------------------------------------------------------------------------------------------------------------------------------


        // Console App Array Assignment

        // Array of strings
        string[] dayArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        // Prompting the user to select a number to display string at that index
        Console.WriteLine("Select a number between 0 and 6:");
        int arrayAnswer = Convert.ToInt32(Console.ReadLine());
        bool vaildString = false;

        while (!vaildString)
        {
            try
            {
                Console.WriteLine("You picked " + dayArray[arrayAnswer] + "!");
                vaildString = true;
            }
            // Adding a message to display if user picks an idex that doesn't exist
            catch
            {
                Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 6. ");
                arrayAnswer = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();


        // Array of integers
        int[] guessingGame = { 5, 70, 12, 34, 15, 6, 88 };
        // Prompting the user to select a number to display the number at that index
        Console.WriteLine("To win a prize, pick a number between 0 and 6! ");
        int userAns = Convert.ToInt32(Console.ReadLine());

        if (userAns == 3)
        {
            Console.WriteLine("The hidden number behind box " + userAns + " is: " + guessingGame[userAns] + ". Congrats, you win!!" );
        }
        else // Adding a message to display if user picks does not pick index 3
        {
            Console.WriteLine("The hidden number behind box " + userAns + " is: " + guessingGame[userAns] + ". Sorry you lose");
        }
        Console.ReadLine();


        // List of strings
        List<string> snackList = new List<string>()
        {
            "Banana",
            "Orange",
            "Apple",
            "Grapes",
            "Pineapple",
            "Watermelon",
            "Strawberry"
        };
        Console.WriteLine("\nSelect another number between 0 and 6:");
        int listAnswer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You picked " + snackList[listAnswer] + "!, enjoy your snack.");
        Console.ReadLine();






    }
}
