//Author: Jorge Sacristan

using System;

//Counters of number of digits,
//countOneDigit is for one digit, countTwoDigit is for 2 digits
//countThreeDigit is for 3 digits and countMoreThanThreeDigit is for more than 3 digits
class digits
{
    static void Main()
    {
        int countOneDigit = 0, countTwoDigit = 0, countThreeDigit = 0, countMoreThanThreeDigit = 0, inputNumberUser = 0;
        String inputUser = "";

        Console.Write("Insert a number: ");
        inputUser = Console.ReadLine();     // read the number as string to check the word "end"

        while (inputUser != "end")
        {
            inputNumberUser = Convert.ToInt32(e);

            if(inputNumberUser != 0)            
            {
                if (inputNumberUser / 10 == 0)
                {
                    countOneDigit++;  // it only has one digit
                }
                else
                {
                    if (inputNumberUser / 100 == 0)
                    {
                        countTwoDigit++;  // the number has 2 digits
                    }
                    else
                    {
                        if (inputNumberUser / 1000 == 0)
                            countThreeDigit++;  // the number has 3 digits
                        else
                            countMoreThanThreeDigit++;  // the number has more than 3 digits
                    }
                }

            }
            inputUser = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", countOneDigit, countTwoDigit, countThreeDigit, countMoreThanThreeDigit); 
    }
}

