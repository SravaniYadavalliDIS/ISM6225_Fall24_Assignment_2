using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                if(nums.Length == 0)
                {
                    return new List<int>(); 
                } else
                {
                  
                int n = nums.Length;
                HashSet<int> numSet = new HashSet<int>();

                // Add  numbers in the array to the HashSet
                foreach (int num in nums)
                {
                    if (num > 0 && num <= n)
                    {
                        numSet.Add(num);
                    }
                }

                List<int> missingNumbers = new List<int>();

                // Find the missing numbers by checking against the expected range
                for (int i = 1; i <= n; i++)
                {
                    if (!numSet.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                }

                return missingNumbers; // Return the list of missing numbers
            }

    }


            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                if(nums.Length==0)
                {
                    return new int[0];
                }
                else
                {
                    List<int> evens = new List<int>(); // List to hold even numbers
                    List<int> odds = new List<int>();   // List to hold odd numbers

                    // Traverse the original list and separate evens and odds
                    foreach (var num in nums)
                    {
                        if (num % 2 == 0)
                        {
                            evens.Add(num); // Add even number to the evens list
                        }
                        else
                        {
                            odds.Add(num); // Add odd number to the odds list
                        }
                    }

                    // Combine the even and odd lists
                    evens.AddRange(odds);

                    return evens.ToArray(); // Return the combined list
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                if (nums.Length == 0)
                {
                    return new int[0];
                }
                else
                {
                    List<int> result = new List<int>(); 
                    // Iterate through each element in the array
                    for (int i = 0; i < nums.Length; i++)
                    {
                        // Check each subsequent element
                        for (int j = i + 1; j < nums.Length; j++)
                        {
                            // Check if the current pair adds up to the target
                            if (nums[i] + nums[j] == target)
                            {
                                result.Add(i);
                                result.Add(j);
                            }
                        }
                    }
                    return result.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                //check if array length is less than 3 or not
                if(nums.Length<3)
                {
                    return 0;
                } else
                {
                    int len = nums.Length;
                    Array.Sort(nums);
                    int product1 = nums[len - 1] * nums[len - 2] * nums[len - 3]; // Three largest numbers
                    int product2 = nums[0] * nums[1] * nums[len - 1];//Three smallest numbers
                    return Math.Max(product1, product2);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                string binNumber = "";
                int rem;
                while(decimalNumber>0)
                {
                    rem = decimalNumber % 2;
                    //Adding the remainder to the beginning of the binaryNumber string
                    binNumber = rem.ToString() + binNumber;
                    //update the quotient by dividing it by 2.
                    decimalNumber = decimalNumber / 2;
                }
                return binNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                //check the length of the array
                if (nums.Length == 0)
                {
                    return 0;
                }
                else
                {
                    //sorting the numbers array 
                    Array.Sort(nums);
                    //get the element from first index since it is sorted array in aescending order
                    return nums[0];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                    int rem = 0, rev = 0,temp=x;
                //It will iterate the loop until x>0
                    while (x > 0)
                    {
                        //storing the last digit of the number by using remainder
                        rem = x % 10;
                    // It multiplies the current value of rev by 10  and adds the last digit 
                    rev = rev * 10 + rem;
                       // Remove the last digit by performing integer division
                        x = x / 10;
                    }
                    //compare the original value with the value stored in rev
                    if (rev == temp)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                // In this i have used the recursive function 
                if(n<0)
                {
                    return -1;
                } else if(n==0)
                {
                   return 0;
                } else if(n==1)
                {
                    return 1;
                } else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
