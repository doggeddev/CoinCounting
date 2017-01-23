using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounting
{
    class Program
    {
        //change making 

       
        static int[] coinsAvailble = {25, 10, 5, 1 }; //quarters, dimes, nickels, and pennies.

        static void Main(string[] args)
        {
            Console.WriteLine(getIdealCoinCount(coinsAvailble, 30));
            Console.ReadLine();
        }

        static int getIdealCoinCount(int[] coins, int targetAmount)
        {
            //what is my base case?? null values, zero value, or 1??
            
            if(targetAmount <= 1)
            {
                return targetAmount;
            }

            int index = 0;
            while (index < coins.Length)
            {
                if (targetAmount >= coins[index])
                {
                    Console.WriteLine(coins[index]); //for debugging. Might consider returning a list to make program useful.

                    return getIdealCoinCount(coins, targetAmount - coins[index]);
                }
                index++;
            }
            //if an error occurs, -1 will be returned.
            return -1;
        }
    }
}
