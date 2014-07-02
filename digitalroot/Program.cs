using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        /// <summary>
        /// takes a string input of numbers, add all the digits of the number and returns the sum as a string
        /// </summary>
        /// <param name="rootX"></param>
        /// <returns>string total of the digits</returns>
        static string rooter(string rootX)
        {
            int x = 0;  // int to store the total
            List<int> list = new List<int>(); //list to store the digits
            for (int i = 0; i < rootX.Length; i++)  //loop through each index of rootX
            {
                int num = Convert.ToInt32(rootX[i].ToString());//converts current index to a number
                list.Add(num);//adds that number to the list
            }
            foreach (var item in list)//for each number in the list
            {
                x += item;//adds number value to the total
            }
            return Convert.ToString(x); // returns the total

        }
        /// <summary>
        /// Takes string input and calls rooter method until Digital Root is found
        /// </summary>
        /// <param name="rootThis"></param>
        /// <returns>int digital root</returns>
        static int DigitalRoot(string rootThis)
        {
            while (rootThis.Length > 1)//loops until rootThis is only one digit in length
            {
                rootThis = rooter(rootThis);//asigns rootThis to the output of rooter function
            }
            return Convert.ToInt32(rootThis);
        }

        static void Main(string[] args)
        {
            int z = DigitalRoot("31337");
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
            
}