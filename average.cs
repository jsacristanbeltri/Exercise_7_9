//Author: Jorge Sacristan

using System;

//This class will calculate the average of marks that the user will input .
public class AverageMarks
{
	public static void Main()
	{
		double totalMarks = 0, userMark, countMarks = 0, averageMarks;
		string inputUser;

		Console.Write("Insert a mark: ");
		inputUser = Console.ReadLine();	 

		while(inputUser != "end")			
		{  
			userMark=Convert.ToDouble(s);
			countMarks++;   
			totalMarks += userMark;  
		
			Console.Write("Insert a mark: ");
			inputUser = Console.ReadLine();
		}
		
		if(countMarks != 0)
		{
			averageMarks = totalMarks / countMarks;  
			Console.WriteLine("The average is {0}.",d);

		}
	}
}
