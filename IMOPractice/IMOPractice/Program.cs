using System;
using System.Collections.Generic;

namespace IMOPractice
{
	class MainClass
	{
		public static Dictionary <string, string> states = new Dictionary<string, string>();

		public static void Main (string[] args)
		{
			//Declaring, Initializing, and Concatenating Strings in a function
			Console.WriteLine("Let's put some strings together: " + concatenate("Hello", "World"));

			//For loops and while loops doing the exact opposite calculation
			Console.WriteLine("Looping 5 around still results in: " + loopAround(5));

			//Adding all of the elements of an array if the element at a specific index is above 5
			int[] list = new int[7] {1, 8, 7, 3, 2, 5, 10};
			Console.WriteLine("The sum of elements >5 is: " + arraySum(list));

			//Switch Statement mapping number of cars and risk of an accident
			Console.WriteLine("The rate of an accident for 4 cars is: " + accidents(4));

			//Switching the format of a DateTime object
			Console.WriteLine ("Switch format from " + DateTime.Now + " to " + changeDateFormat(DateTime.Now));

			//Using a Dictionary to print state names
			states.Add("IL", "Illinois");
			states.Add("TX", "Texas");
			states.Add("FL", "Florida");
			states.Add("CA", "California");
			states.Add("IN", "Indiana");
			string[] abbreviations = new string[3] {"IL", "FL", "IN"};
			Console.WriteLine("States in the array are: " + getStates(abbreviations, states));

			//Getting input from the user
			Console.WriteLine("Your name is: " + getName());

			//Topics covered: Decleration, Initialization, Collections, User Input, Arrays, String Handling, Global Variables,
			//Switch Statements, If statements, For/While loops, DateTime, Mathematical Expressions, Functions
		}


		/*
		 * Function concatenating two strings with the word cruel in between
		 * Parameter: two strings a and b
		 * Return: Concatenated string
		 */
		public static string concatenate(string a, string b)
		{
			string description = "Cruel";
			return a + " " + description + " " + b;
		}


		/*
		 * Function showing two different loops doing the exact opposite calculations
		 * Parameter: a number
		 * Return: the same number after going through the loops
		 */
		public static int loopAround(int number)
		{
			int loopLength = 10;
			for (int i = 0; i < loopLength; i++) {
				number += i;
			}
			while (loopLength != 0) {
				loopLength --;
				number -= loopLength;
			}
			return number;
		}


		/*
		 * Function iterating through an array and adds elements over the value of 5
		 * Parameter: an array
		 * Return: summation of all values of elements above 5
		 */
		public static int arraySum(int[] array)
		{
			int total = 0;
			for (int position = 0; position < array.Length; position++) {
				if (array [position] > 5) {
					total += array [position];
				}
			}
			return total;
		}


		/*
		 * Switch statement mapping number of cars to accident rate
		 * Parameter: number of cars
		 * Return: rate of an accident occurring
		 */
		public static double accidents(int cars)
		{
			switch (cars)
			{
				case 0:
					return 0;
				case 1:
					return 0;
				case 2:
					return 0.2;
				case 3:
					return 0.3;
				case 4:
					return 0.5;
				case 5:
					return 0.75;
				case 6:
					return 0.9;
				default:
					return 1;
			}
		}


		/*
		 * Format change of a DateTime value
		 * Parameter: a datetime of the current time
		 * Return: a new format with year/month/day
		 */
		public static string changeDateFormat(DateTime d)
		{
			return String.Format("{0:yyyy/M/d}", d);
		}


		/*
		 * Get the states given abbreviations using a dictionary
		 * Parameter: list of abbreviations and a dictionary that takes abbreviations and gives state names
		 * Return: a listing off the states
		 */
		public static string getStates(string[] abbreviations, Dictionary<string, string> states)
		{
			string stateList = states[abbreviations[0]];
			for (int x = 1; x < abbreviations.Length; x++) {
				stateList += ", " + states [abbreviations [x]];
			}
			return stateList;
		}


		/*
		 * Get input from the user to write his/her name
		 * Parameter: None
		 * Return: User name as inputted
		 */
		public static string getName()
		{
			Console.Write("Enter your name: ");
			return Console.ReadLine();
		}
	}
}
