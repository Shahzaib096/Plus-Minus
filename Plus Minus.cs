using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal positive, negetive ,zero;
            positive = 0M;
            negetive = 0M;
            zero = 0M;
            decimal positiveResult = 0M;
            decimal negetiveResult = 0M;
            decimal zeroResult = 0M;
           
            int[] myArray = new int[5];
            long total = myArray.Count();
            Console.Write("Enter Array Elements :");
            for(int i=0; i<myArray.Length;i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
                if(myArray[i]>0)
                {
                    positive++;
                }
                else if(myArray[i]<0)
                {
                    negetive++;
                }
                else
                {
                    zero++;
                }
            }
            positiveResult = positive / total;
            Console.WriteLine("Positive :"+positiveResult);
            negetiveResult = negetive / total;
            Console.WriteLine("Positive :" + negetiveResult);
            zeroResult = zero / total;
            Console.WriteLine("Positive :" + zeroResult);
            Console.ReadLine();



        }
    }
}
