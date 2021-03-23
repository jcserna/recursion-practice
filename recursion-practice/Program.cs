using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Summation(5);
            int sd = sumDigits(25);
            Console.WriteLine("Los números suman "+ s);
            Console.WriteLine("Los digitos suman "+sd);
            Console.WriteLine(numPrime(7));
            Console.WriteLine("Existen "+possiblePaths(3)+" posibles caminos");




        }

 //1. Write a program in C# to calculate the sum of numbers from 1 to n using recursion. Go to the editor

        public static int Summation (int n)
        {
            int r = 0;

            if(n > 1)
            {
                r = n+Summation(n - 1);
            }
            
            if(n == 1)
            {
               r= n;
            }

            return r;
        }

 // 2.Write a program in C# to find the sum of digits of a number using recursion. 

        public static int sumDigits (int num)
        {
            int r = 0;
            int res = 0;
            if (num / 10 == 0)
            {
                r = num;
            }

            if (num % 10 != 0)
            {
                res = num % 10;
                r = res + sumDigits(num / 10);
            }


            return r;
        }

        // 3. Write a program in C to check a number is a prime number or not using recursion.

        public static string numPrime(int num) {

            Boolean pri = numPrime(num, num/2);

            string message = "";
            if(pri == true)
                    {
                        message= "Es primo";
                    }
                    else if (pri == false)
                    {
                        message="No es primo";
                    }
            return message;
        }
       static Boolean numPrime(int num, int count)
        {
            if (count == 1)
            {
                return true;
            }

            else if (num % count == 0)
            {
                return false;

            }
            else
            {
                count = count - 1;
                return numPrime(num, count);
            }
            
        }

        //4.how many buildings can spiderman jump
        //spiderman puede saltar dos edificios o uno 
        //si quedan tres edicicios tiene la opcion de dos + 1 o 1+1+1
        //    si quedan dos puede saltar 2 o 1+1


        static int possiblePaths(int buildings)
        {
            if (buildings >= 2)
            {
                return possiblePaths(buildings - 1) + possiblePaths(buildings - 2);
            }
            else if (buildings == 1)
            {
                return possiblePaths(buildings - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}




