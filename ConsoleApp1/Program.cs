using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

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
            // int[] nums2 = { 3, 1, 2, 4 };
            int[] nums2 = { 2, 2, 3, 3, 4, 2 };
            SortArrayByParity(nums2);
            int[] sortedArray = nums2;
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
            int n = 7;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                HashSet<int> all_nums = new HashSet<int>();
                int l = nums.Length;
                for (int i = 1; i <= l; i++)
                {
                    all_nums.Add(i);
                }

                for (int i = 0; i < l; i++)
                {
                    if (all_nums.Contains(nums[i]))
                    {
                        all_nums.Remove(nums[i]);
                    }
                }

                return new List<int>(all_nums); // Placeholder
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
                int i = 0;
                int j = 1;
                int l = nums.Length;
                while (i < l & j < l)
                {
                    if (nums[i]%2 == 1)
                    {
                        if ((nums[j] % 2 == 0) && (i < j))
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            i++;
                            j++;
                        }

                        else
                        {
                            j++;
                        }
                    }

                    else
                    {
                        i++;
                    }
                }
                //Console.WriteLine(string.Join(",", nums));
                return new int[0]; // Placeholder
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
                int l = nums.Length;
                Hashtable ht = new Hashtable();

                // Populate the hashtable with number values and their indices
                for (int i = 0; i < l; i++)
                {
                    ht[nums[i]] = i;
                }

                // Find the pair of indices that add up to the target
                for (int i = 0; i < l; i++)
                {
                    int complement = target - nums[i];

                    // Check if complement exists and it's not the same index
                    if (ht.ContainsKey(complement) && (int)ht[complement] != i)
                    {
                        return new int[] { i, (int)ht[complement] };
                    }
                }

                return new int[0]; // Return an empty array if no solution is found
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
                int l = nums.Length;
                if(l < 3)
                {
                    return 0;
                }
                else if (l == 3)
                {
                    return (nums[0] * nums[1] * nums[2]);
                };

                Array.Sort(nums);
                // In case we have two negative numbers which on multiplying results in maximum product:
                return Math.Max(nums[0] * nums[1] * nums[l-1], nums[l-1] * nums[l-2] * nums[l-3]);
                 // Placeholder
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
                if (decimalNumber == 0)
                {
                    return "0";
                }

                string binary = "";
                while (decimalNumber > 0)
                {   int remainder = decimalNumber % 2;
                    binary = remainder + binary;
                    decimalNumber /= 2;
                }

                return binary;
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
                int l = nums.Length;
                for ( int i = 1; i<l; i++ ) 
                {
                    if (nums[i] < nums[i-1])
                    {
                        return nums[i];
                    }
                                                           
                }

                return nums[0]; // Placeholder
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
                if (x<0)
                {  
                    return false; 
                }
                int newnum = 0;
                int check = x;
                
                while (x > 0)
                {
                    
                    newnum =  newnum * 10 + (x % 10);
                    x /= 10;
                }

                if (check == newnum)
                    return true;
                return false; // Placeholder
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
                if (n <2)
                {
                    return n;
                }

                return Fibonacci(n - 1) + Fibonacci(n - 2);

                //return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}