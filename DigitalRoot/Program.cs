using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("456789");
            DigitalRoot("4521");
            DigitalRoot("369852");
            //Keeps the console open
            Console.ReadKey();
        }
        //Creating the function for digital root
        static void DigitalRoot(string rootThis)
        {
            //Setting up the variable for the output
            int result = 0;
            //Printing to the console our input
            Console.WriteLine("Input: " + rootThis);
            //Taking our string and turning it into
            //an integer
            int input = int.Parse(rootThis);
            //Setting up a loop to run through our string 
            //and add newly made integers and add them together
            while (rootThis.Length > 1)
            {
                //Setting the variable for the 
                //total of our intial string
                int total = 0;
                //Takes all the numbers in our input and adds 
                //them together and then adds the digits in the 
                //result to get our root
                foreach (char num in rootThis)
                {
                    //Changes each char into a string
                    string numString = num.ToString();
                    //Taking that string and converting it
                    //into numbers
                    int trueNum = int.Parse(numString);
                    //Adding the numbers together and adding
                    //that to the total
                    total += trueNum;
                    //Making the input equal to the total of our 
                    //intial string
                    input = total;
                    //Making the final number equal
                    //to the input
                    result = input;
                    //Converting back into a string
                    rootThis = input.ToString();
                }
            }
            //Printing to the console our digital root
            Console.WriteLine("Output: " + result);
        }
    }
}
