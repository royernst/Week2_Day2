using System;
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
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string year = "Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec";
            //string[] months = year.Split();

            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //int number = 2;
            //int[] test = new int[number];
            //test[0] = 1;
            //test[1] = 1;
            //test[number] = number;
            //foreach (int section in test)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine().ToUpper();
            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}

            //Console.WriteLine("Would you like to check the patient in for their appointment? Enter Yes/No");
            //string answer = Console.ReadLine().ToLower();
            //while (answer == "yes" || answer == "y")
            //{
            //    Console.WriteLine("PATIENT CHECK-IN SYSTEM");
            //    Console.WriteLine("Please enter patient's full name:");
            //    string fullName = Console.ReadLine();
            //    Console.WriteLine("Please enter patient's 6-digit patient ID:");
            //    string patientID = Console.ReadLine();
            //    Console.WriteLine("Please enter client's appointment time:");
            //    string appointmentTime = Console.ReadLine();
            //    Console.WriteLine("Would you like to check another patient in for their appointment? Enter Yes/No");
            //    answer = Console.ReadLine().ToLower();
            //}

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to play the game? (YES/NO)");

            //}


            //string classAdd;
            //do
            //{
            //    Console.WriteLine("What class would you like to add?");
            //    string classInput = Console.ReadLine();
            //    Console.WriteLine("What was the letter grade for that class? (No + or - grades)");
            //    string classGrade = Console.ReadLine();
            //    Console.WriteLine("Do you have another class you would like to add? (Yes/No)");
            //    classAdd = Console.ReadLine().ToLower();
            //} while (classAdd == "yes");

            for (int i = 1; i <= 20; i ++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
