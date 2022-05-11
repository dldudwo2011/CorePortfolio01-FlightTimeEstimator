/* 
 * Purpose: Write a program that reads an estimated flight time and an actual flight time and then print whether the
 *           estimate time is too large, acceptable, or too small. Output needs to indicate the amount of the overestimate 
 *           or underestimate as well.
 *           
 * Input: Estimated flight time (int) and an actual flight time (int)
 * 
 * Process: Write 2 separate messages that ask user for the inputs using Console.Writeline() method.
 * 
 *          Create 2 int variables that will store estimated flight time and an actual flight time
 *          and name them respectively estFT and actFT
 *          
 *          Store the user input values in estFT and actFT variable using Console.Readline() method
 *          and use int.parse() method to convert string to int.
 *          
 *          Write 8 if statements to figure out what category of 8 categories(0-29, 30-59, 60-89, 90-119, 120-179, 180-239, 240-359, 360 or more) 
 *          the value of estFT(User input) fall into. 
 *          
 *          Then, write 2 separate if statements within each of the if statements. 
 *          
 *          One of them will compare the value of estFT and actFT
 *          and find out if the amount of difference is bigger than the Acceptable Error Margin of that category(one of 1, 2, 3, 4, 6, 8, 13 , 17).
 *          
 *          Other one will find out if the amount of difference smaller or equal to the Acceptable Error Margin of that category(one of 1, 2, 3, 4, 6, 8, 13 , 17).
 *          
 *          Make sure to store the value of the amount of difference in a variable named "diffAmt" for future use, and make sure the amount of difference is
 *          always a positive value by using math.abs() function.
 *          
 *          If the amount of difference is bigger than the Acceptable Error Margin, check if the estimated flight time is overestimated of underestimated by
 *          writing 2 separate if statements. 
 *         
 *          One of the if statements will compare if the estFT is greater than actFT, and if estFT is greater than actFT, 
 *          use formula (Amount of Difference - Acceptable Error Margin) to find out the amount of the overestimate(Use diffAmt variable for Amount of Difference)
 *          and print "Estimated flight time is too big and overestimated by (Amount of the overestimate) minutes"  to command line using String Interpolation
 *          
 *          The other if statements will compare if the estFT is smaller than actFT, and if estFT is smaller than actFT, 
 *          use formula (Amount of Difference - Acceptable Error Margin) to find out the amount of the underestimate(Use diffAmt variable for Amount of Difference)
 *          and print "Estimated flight time is too small and underestimated by (Amount of the underestimate) minutes"  to command line using String Interpolation
 *          
 *          If the amount of difference is smaller or equal to the Accceptable Error Margin, print a message saying "Estimated flight time is acceptable" by using Console.Writeline() method.
 * 
 * Output: If estimate time is too large, it will output "Estimated flight time is too big and overestimated by (Amount of the overestimate) minutes".
 *
 *         If estimated time is too small, it will output "Estimated flight time is too small and underestimated by (Amount of the underestimate) minutes".
 *     
 *         Else, it will output "Estimated flight time is acceptable".
 *      
 * Test plan
 * 
 * Test case 1: 0-29
 * Test data: Estimated flight time = 14  Actual flight time = 9
 * Expected result: "Estimated flight time is too big and overestimated by 4 minutes"
 * 
 * Test case 2: 30-59
 * Test data: Estimated flight time = 35  Actual flight time = 36
 * Expected result: "Estimated flight time is acceptable"
 * 
 * Test case 3: 60-89
 * Test data: Estimated flight time = 77  Actual flight time = 82
 * Expected result: "Estimated flight time is too small and underestimated by 2 minutes"
 * 
 * Test case 4: 90-119
 * Test data: Estimated flight time = 110  Actual flight time = 103
 * Expected result: "Estimated flight time is too big and overestimated by 3 minutes"
 * 
 * Test case 5: 120-179
 * Test data: Estimated flight time = 148  Actual flight time = 144
 * Expected result: "Estimated flight time is acceptable"
 * 
 * Test case 6: 180-239
 * Test data: Estimated flight time = 191  Actual flight time = 220
 * Expected result: "Estimated flight time is too small and underestimated by 21 minutes"
 * 
 * Test case 7: 240-359
 * Test data: Estimated flight time = 285  Actual flight time = 240
 * Expected result: "Estimated flight time is too big and overestimated by 32 minutes"
 * 
 * Test case 8: 360 or more
 * Test data: Estimated flight time = 652  Actual flight time = 660
 * Expected result: "Estimated flight time is acceptable"
 * 
 * Author: Youngjae Lee
 * 
 * Last modified date: 2021 Feb 01
*/

using System;

namespace CorePortfolio01_Youngjae_Lee
{
    class Program
    {
        static void Main(string[] args)
        {   //ask user for estimated flight time
            Console.WriteLine("Enter estimated flight time: ");

            //get the input (estimated flight time) and parse it to int value, then storing it to estFT variable
            int estFT = int.Parse(Console.ReadLine());

            //ask user for actual flight time
            Console.WriteLine("Enter actual flight time: ");

            //get the input (actual flight time) and parse it to int value, then storing it to actFT variable
            int actFT = int.Parse(Console.ReadLine());

            //if statement for range 0-29
            if (0 <= estFT && estFT <= 29)
            {   
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 1)
                {   
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {   
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 1} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 1} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }

            }
            //if statement for range 30-59
            else if (estFT <= 59)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 2)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 2} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 2} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }
            //if statement for range 60-89
            else if (estFT <= 89)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 3)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 3} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 3} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }
            //if statement for range 90-119
            else if (estFT <= 119)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 4)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 4} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 4} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }
            //if statement for range 120-179
            else if (estFT <= 179)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 6)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 6} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 6} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }

            }
            //if statement for range 180-239
            else if (estFT <= 239)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 8)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 8} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 8} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }
            //if statement for range 240-359
            else if (estFT <= 359)
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 13)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 13} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 13} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }
            //if statement for 360 or higher
            else
            {
                //calculate the amount of difference and math.abs() it to make sure it is positive. Then store in diffAMT variable
                int diffAmt = Math.Abs(estFT - actFT);

                //if the amount of difference is bigger than the Acceptable Error Margin (Error)
                if (diffAmt > 17)
                {
                    //if the estFT is greater than actFT (Overestimate)
                    if (estFT > actFT)
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too big and overestimated by {diffAmt - 17} minutes");
                    }

                    //if the estFT is smaller than actFT (Underestimate)
                    else
                    {
                        //Output
                        Console.WriteLine($"Estimated flight time is too small and underestimated by {diffAmt - 17} minutes");
                    }
                }

                //If the amount of difference is smaller or equal to the Accceptable Error Margin (No error)
                else
                {
                    //Output
                    Console.WriteLine("Estimated flight time is acceptable");
                }
            }

        }
    }
}
