using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			const byte sample1 = 0x3A;
			const float acceleration = 9.800f;
			const char integral = '\u222B';
			float mass = 14.9f;
			byte sample2 = 58;
			string greetings, name;
			greetings = "Hello";
			name = "Karen";
			int heartRate, choice;
			heartRate = 85;
			choice = 2;
			double deposits, distance;
			deposits = 135002796;
			distance = 129.763001;
			bool lost, expensive;
			lost = true;
			expensive = true;

			if (sample2 == sample1)
			{
				Console.WriteLine("The samples are equal.");
			}
			else
			{
				Console.WriteLine("The samples are not equal.");
			}

			if (heartRate > 40 && heartRate < 80)
			{
				Console.WriteLine("Heart rate is normal.");
			}
			else
			{
				Console.WriteLine("Heart rate is not normal.");
			}

			if (deposits >= 100000000)
			{
				Console.WriteLine("You are exceedingly wealthy.");
			}
			else
			{
				Console.WriteLine("Sorry you are so poor.");
			}

			float force = mass * acceleration;
			Console.WriteLine("Force = {0}", force);

			Console.WriteLine("{0} is the distance", distance);

			if (lost == true && expensive == true)
			{
				Console.WriteLine("I am really sorry! I will get the manager.");
			}
			if (lost == true && expensive == false)
			{
				Console.WriteLine("Here is coupon for 10% off.");
			}

			switch (choice)
			{
				case 1:
					Console.WriteLine("You chose 1.");
					break;
				case 2:
					Console.WriteLine("You chose 2.");
					break;
				case 3:
					Console.WriteLine("You chose 3.");
					break;
				default:
					Console.WriteLine("You made an unknown choice.");
					break;
			}

			Console.WriteLine("{0} is an integral.", integral);

			for (int i = 5; i <= 10; i++)
			{
				Console.WriteLine("i = {0}", i);
			}

			int age = 0;
			while (age <= 6)
			{
				Console.WriteLine("age = {0}", age);
				age++;
			}

			Console.WriteLine("{0} {1}", greetings, name);

			Console.ReadLine();
		}
	}
}
