﻿using System;
using System.Linq;
using System.IO;


namespace Deliverable2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("heads or tails? ");
			string headsOrTailsGuess = Console.ReadLine();

			Console.Write("Pick a number of coin flips ");
			int numberOfFlips = int.Parse(Console.ReadLine());

			//Random flip generator
			Random rnd = new Random();
			using (StringWriter stringWriter = new StringWriter())

				for (int i = 0; i < numberOfFlips; i++)
				{
					if (rnd.Next() % 2 == 0)
					{
						Console.WriteLine("heads");
					}
					else
					{
						Console.WriteLine("tails");
					}
					
					string consoleOutput = stringWriter.ToString();

				
				}
		}
	}
}
