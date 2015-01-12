// -------------------------------------------------------------------
// Department of Electrical and Computer Engineering
// University of Waterloo
//
// Student Name:     Andrew Boettger
// Userid:           apboettg
//
// Assignment:       Weekly Assignment 6
// Submission Date:  11/3
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work.
//
// Acknowledgements:
// <INSERT AN ITEMIZED LIST OF ACKNOWLEDGEMENTS IF APPLICABLE>
// -------------------------------------------------------------------

using System;
using System.IO;

	class Innovate
	{
	
		static void Main()
		{
	
		int innovateCounter = 0;
		int entrepreneurCounter = 0;
		
		string filePath = "StrategicPlan.txt";
		
		StreamReader reader = new StreamReader(filePath);
		
		int run = 0;
		
		bool checkLine = false;
		bool checkInnovate = false;
		bool checkEntrepreneur = false;
		int lineCounter= 0;
		
		int lineEnd = 0;
		int runMax = 0;
		
		
		while (!reader.EndOfStream)
		{
		
		string line = (reader.ReadLine()).ToLower();
		
		if (line == null)
		{
		}
		else
		{
		
		string[] lineSplit = line.Split();
		
		for (int i=0; i < lineSplit.Length; i++)
		{
		
		if (lineSplit[i].StartsWith("innova") || lineSplit[i].Contains("Innova") )
		{
		checkLine = true;
		checkInnovate = true;
		}
		
		
		if (lineSplit[i].StartsWith("entrepre") || lineSplit[i].Contains("Entrepre"))
		{
		checkLine = true;
		checkEntrepreneur = true;
		}
		
		
		}
		
		if (checkEntrepreneur == true)
		{
		entrepreneurCounter++;
		}
		if (checkInnovate == true)
		{
		innovateCounter++;
		}
		
		
		
		if (checkLine == false)
		{
		
		run++;
		
		
		}
		else
		{
		
		if (run > runMax)
		{
		runMax = run;
		run = 0;
		lineEnd = lineCounter;
				
		}
		else
		{
		run=0;
		}
		
		}
			
		
		checkLine=false;
		checkEntrepreneur= false;
		checkInnovate=false;
		lineCounter++;
		
		
		
		
		
		}
		
		}
		Console.WriteLine("Lines containing 'innova': " + innovateCounter);
		Console.WriteLine("Lines containing 'entrepre': " + entrepreneurCounter);
		Console.WriteLine("The longest run is " + ((lineEnd - runMax)+1)+ " to " + lineEnd);
		
		
		}
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	