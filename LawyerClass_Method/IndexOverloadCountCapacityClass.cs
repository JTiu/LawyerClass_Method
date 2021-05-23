﻿using System;

namespace LawyerClass_Method
{
    public class TestPrintIndex<T>
    {
        private T[] arrayOfTowns1; //array indicated by the T[], followed by name, need a constructor
        public int Capacity ////As a developer, I want a #3 Capacity: How many? ten.
        {
            get
            {
                return arrayOfTowns1.Length;
            }

        }
        public int Count //Enter array, determine how many positions
        {
            get
            {
                int count = 0; //start at 0 position

                foreach (var item in arrayOfTowns1) //Loop thru items, each item, if not null, add item to count// for each loop does not care about index postion
                {
                    if (item != null)
                    {
                        count++;

                    }
                    else
                    {
                        return count;
                    }
                }
                return count; //array is full. until anything is added, count is zero
            }

        }
        //public CourthouseRoute(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k, string l, string m)
        public TestPrintIndex()//initializes the array with length of 10 items. Meets user story#1 
        //    //As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //    //capacity is ten at this moment
        {
            arrayOfTowns1 = new T[10];

        }

        public void Add(T item) //does not return, so 'void' because will always be able to add a new value by 3 step process to double the capacvity if array is full. 
                                //Remove method will return a bool to indicate t/f if removal method is successful
        {

            int findIndex = FindNullIndexToAdd(); //method to find next open position
            if (findIndex >= 0)
            {
                arrayOfTowns1[findIndex] = item;

            }
            else//if the array is full, i.e., -1
            {
                findIndex = arrayOfTowns1.Length;

                IncreaseCapacity();//activated when array was full, will double the length of the 'capacity'. three part process in the below method 'Increase capacity.  1. create doubled capacity, 2.move using for loop 3. update array to point to new array with double the capicity
                arrayOfTowns1[findIndex] = item;//finds next open index position (should be ten for the first new incoming item, then 11 to 19, until full). adds new item to the new array
            }
        }

        private void IncreaseCapacity()//3 steps
        {
            T[] newArray = new T[2 * arrayOfTowns1.Length];//step one

            for (int i = 0; i < arrayOfTowns1.Length; i++)//step 2
            {
                newArray[i] = arrayOfTowns1[i]; //copies all items to the new array
            }
            arrayOfTowns1 = newArray;//new  array has double the capacity of the prior array; step 3
        }

        private int FindNullIndexToAdd()//will use a for loop to find index position (not a foreach loop, as above
        {
            for (int i = 0; i < arrayOfTowns1.Length; i++)
            {
                if (arrayOfTowns1[i] == null)//check with ==
                {
                    return i;//returns the next open slot.  if initial add, goeos to [0], subsequent additions go to next available slot, up to length-1; when full , will have a different result
                }
            }
            return -1;//-1 will indicate that there are no null postions to fill, array is full (ten)
        }

        //#7 As a developer, I want to be able to override the ToString method that converts the contents of the custom list to a string.
        public override string ToString()//need to create a string to hold the result
        {
            string result = string.Empty;//created empty string
            foreach (var item in arrayOfTowns1)//run 'for loop' on item through items, adding everything to the string, adding all non-empty (not null), items to the 'result' of the ToString method
            {
                if (item != null)
                {
                    result += "\nadd, to array: "; result += item.ToString();

                }
            }
            return result;
        }
        public TestPrintIndex<string> Index()
        {
            TestPrintIndex<string> AddToIndex = new TestPrintIndex<string>();
            AddToIndex.Add("Las Cruces");
            AddToIndex.Add("Mesilla");
            AddToIndex.Add("Roswell");

            Console.WriteLine($"An array of three New Mexico Courthouses, for index check:\n{AddToIndex}");
            Console.WriteLine($"\nfirst town, by index is: {AddToIndex.arrayOfTowns1[0]}");
            Console.WriteLine($"second town, by index is: {AddToIndex.arrayOfTowns1[1]}");
            Console.WriteLine($"third town, by index is: {AddToIndex.arrayOfTowns1[2]}");

            return AddToIndex;
        }
        public TestPrintIndex<string> CheckCapacityAndCount()
        {
            TestPrintIndex<string> Array = new TestPrintIndex<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");

            Console.WriteLine($"An array of three New Mexico Courthouses, for capacity & count check:\n{Array}");
            Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
            Array.Add("Albuquerque");
            Array.Add("Santa Fe");
            Array.Add("Rio Rancho");
            Array.Add("Hobbs");
            Array.Add("Alamogordo");
            Array.Add("Farmington");
            Array.Add("Clovis");
            Array.Add("White Sands");
            Array.Add("Truth or Consequences");
            Array.Add("Cloudcroft");
            Console.WriteLine($"\nA new array of Courthouses, for capacity check:\n{Array}");
            Console.WriteLine($"\nNow, capacity is: {Array.Capacity}");
            Console.WriteLine($"\nNow, count is: {Array.Count}");
            return Array;
        }
        public TestPrintIndex<string> OverloadingOperators()
        {
            TestPrintIndex<string> firstArrayForOverload = new TestPrintIndex<string>();
            firstArrayForOverload.Add("Las Cruces");
            firstArrayForOverload.Add("Mesilla");
            firstArrayForOverload.Add("Roswell");
            Console.WriteLine($"\nAn array, for capacity check:\n{firstArrayForOverload}, capacity: {firstArrayForOverload.Capacity}");
            Console.WriteLine($"\ncountcheck:\n{firstArrayForOverload.Count}");
            TestPrintIndex<string> secondArrayForOverload = new TestPrintIndex<string>();
            secondArrayForOverload.Add("El Paso");
            secondArrayForOverload.Add("Amarillo");
            secondArrayForOverload.Add("Fort Worth");
            
            Console.WriteLine($"\nAn array, for capacity check:\n{secondArrayForOverload}, capacity: {secondArrayForOverload.Capacity}");
            Console.WriteLine($"\ncountcheck:\n{firstArrayForOverload.Count}");
            return firstArrayForOverload;
            return secondArrayForOverload;
        }

    }






}