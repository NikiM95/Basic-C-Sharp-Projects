﻿using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //// * LISTS *

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        List<string> strList = new List<string>();
        strList.Add("Hello");
        strList.Add("Niki");
        strList.Remove("Niki");

        Console.WriteLine(strList[0]);
        Console.ReadLine();


        //// * ARRAYS *
        //byte[] byteArray = new byte[5000]


        //// Do This
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// Or this -> more flexible
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //// Or this -> dont have to say you are creating a new int array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


    }
}

