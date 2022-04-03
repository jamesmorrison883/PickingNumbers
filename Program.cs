using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //test cases:
            int[] TestCase1 = {1,1,2,2,4,4,5,5,5}; //expected output is 5
            int[] TestCase2 = {4,6,5,3,3,1}; //expected output is 3
            int[] TestCase3 = {1,2,2,3,1,2}; //expected output is 5

            //code:
            
            PickingNumbersOutput(TestCase1);
            PickingNumbersOutput(TestCase2);
            PickingNumbersOutput(TestCase3);

            static void PickingNumbersOutput(int[] inputArray)
            {
                var inputList = inputArray.OrderBy(x => x).ToList();

                var outputCounter = 0; //counter to keep track of substring length+


                for(int i = 0; i < inputList.Count; i++)
                {
                    for(int j = i + 1; j < inputList.Count; j++)
                    {
                        if(Math.Abs(inputList[i]-inputList[j]) <= 1)
                        {
                            if (j - i + 1 > outputCounter)
                            {
                                outputCounter = j - i + 1;
                            }
                        }
                        
                        else
                        {
                            break;
                        }

                        
                    }
                }
                                   
               Console.WriteLine($"The expected output of is {outputCounter}.");              

            }

            


        }
    }
}
