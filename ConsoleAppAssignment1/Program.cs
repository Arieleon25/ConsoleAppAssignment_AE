﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNMENT PART ONE
            Console.WriteLine("Input 4 names: ");

            string[] answerArray1 = new string[4];
            for(int i = 0; i < answerArray1.Length; i++)
            {
                answerArray1[i] = Console.ReadLine();
            }

            Console.WriteLine("\nThis is you string array! \n");

            for (int j = 0; j < answerArray1.Length; j++)
            {
                Console.WriteLine(answerArray1[j]);
            }

            //INFINITE LOOP ASSIGNMENT PART TWO

            //for (; ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}

            // ASSIGNMENT PART THREE

            Console.WriteLine("\nList of years! { 1969, 1970, 1995, 1998, 2004 } \n");

            List<int> yearList = new List<int>() { 1969, 1970, 1995, 1998, 2004 };

            foreach (int year in yearList)
            {
                if (year < 1995)
                {
                    Console.WriteLine("\nYears in array Before 1995: " + year);
                }
            }

            foreach (int year in yearList)
            {
                if (year <= 1995)
                {
                    Console.WriteLine("\nYears in array before or equal to 1995: " + year);
                }
            }

            // ASSIGNMENT PART FOUR

            Console.WriteLine("\nAnime List - input an Anime title\n");

            List<string> animeList = new List<string>() { "Dragon Ball Z", "Attack on Titan", "Demon Slayer", "Naruto", "One Piece", "Pokemon"};
            string animeInput = Console.ReadLine();

            for (int k = 0; k < animeList.Count; k++)
            {
                if (animeList[k] == animeInput)
                {
                    Console.WriteLine(k);
                    break;
                }
                else
                {
                    Console.WriteLine("Text isn't in the list");
                    
                }
            }

            //Console.WriteLine($"{animeList[k]}:{k}");



            // ASSIGNMENT PART FIVE

            Console.WriteLine("\nfruit List - input from list { Apple, Pear, Banana, Orange, Apple, Pineapple } \n");

            List<string> twinList = new List<string>() { "Apple", "Pear", "Banana", "Orange", "Apple", "Pineapple" };
            string fruitInput = Console.ReadLine();
            bool matchExists = false;

            for (int l = 0; l < twinList.Count; l++)
            {
                if (twinList[l] == fruitInput)
                {
                    matchExists = true;
                    Console.WriteLine(l);
                }
            }

            if(matchExists == false)
            {
                Console.WriteLine("Sorry, this is not in the list");
            }

            // ASSIGNMENT PART SIX

            Console.WriteLine("\nColor List\n");

            List<string> colorList = new List<string>() { "Red", "Yellow", "Blue", "Orange", "Green", "Purple", "Gray", "Green", "Red", "White", "Black" };

            foreach (string color in colorList)
            {
                if (color == colorList[7])
                {
                    Console.WriteLine(color + "\nAppeared in the list");
                }
                else if (color == colorList[8])
                {
                    Console.WriteLine(color + "\nAppeared in the list");
                }
                else
                {
                    Console.WriteLine(color);
                }
            }

            Console.ReadLine();
        }
    }
}

