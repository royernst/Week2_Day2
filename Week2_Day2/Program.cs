﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] newArray = new int[arraySize];
            //Console.WriteLine("The array is of length " + newArray.Length);

            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "May"));

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));

            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);

            //string[] names = { "John", "Paul", "George", "Ringo:" };
            //Console.WriteLine(Array.IndexOf(names, "John"));

            //int[] luckyNumbers = { 4, 3, 2, 1, 4, 3, 2, 1 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumbers, 4));

            //char[] alphabet = { 'a', 'b', 'c', 'd' };
            //Console.WriteLine(alphabet[0]);
            //Array.Reverse(alphabet);
            //Console.WriteLine(alphabet[0]);

            //string[] students = { "Roy", "JD", "Brian", "Kaitie", "Raz", "Monica" };
            //Array.Sort(students);
            //Console.WriteLine(students[0] + " \n" + students[5]);

            //for ( int i = 0; i <= 10; i += 2 )
            //{
            //    //Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //   // Console.WriteLine(counter);
            //}

            //string greetings = "My name is Roy";
            //string[] words = greetings.Split();

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //for( int i = 1; i <= 10; i ++)
            //{
            //    Console.WriteLine(i);
            //}

            //for( int counter = 0; counter <= 500; counter += 2)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();

            ////Console.WriteLine(words[0]);

            //for (int i = 0; i < words.Length;)
            //{
            //    Console.WriteLine(i);
            //}

            //string week = "Monday Tuesday Wednesday";
            //string[] days = week.Split();
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            string story = "Once upon a time";
            string[] storyWords = story.Split();
            Array.Reverse(storyWords);
            for (int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }
        }
    }
}
