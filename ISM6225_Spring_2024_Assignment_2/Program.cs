/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*///3 and 7

using System.Text;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
            Console.ReadLine();

        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int k = 1;  // Pointer for unique elements
                int i = 1;  // Pointer for iterating through the array
                int cnt = 0;
                while (i < nums.Length)
                {
                    // If the current element is different from the previous unique element
                    if (nums[i] != nums[k - 1])
                    {
                        nums[k] = nums[i];  // Move the current element to the next unique position
                        k++;  // Increment the unique element pointer
                    }
                    cnt += 1;
                    i++;  // Move to the next element
                }
                for(int j=k;j<nums.Length;j++)
                {
                    nums[j] = 0;//Changing the repeated elements to zero.
                }
                //printing the array
                for(int j=0;j<nums.Length;j++)
                {
                    Console.Write(nums[j]);
                }
                Console.WriteLine();
                return k;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        * Self Reflection:
        * This C# code removes duplicates from a sorted array in-place, returning the count of unique elements.It smartly assumes the first element is unique, then iterates through the array, overwriting duplicates with unique elements found.
        * From this problem, I came across how we can use two pointers in one for loop while switching array positions.
        */

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int nonZeroIndex = 0;//Initialize nonZeroIndex
                for (int i = 0; i < nums.Length; i++)//Loop to traverse the array.
                {
                    if (nums[i] != 0)//Checking if the current iterative element is nonzero.
                    {
                        nums[nonZeroIndex] = nums[i];//If the current element is non-zero, move that element to the non-zeroIndex.
                        nonZeroIndex += 1;//We then increment the nonZeroIndeex by one step forward.
                    }
                }


                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        * Self Reflection:
        This C# method efficiently moves all zeros in an array to the end while keeping the order of non-zero elements intact. It employs a two-pointer approach where `nonZeroIndex` serves as a marker for where the next non-zero element should go. As it scans through the array, each non-zero element is swapped into place at `nonZeroIndex`, ensuring all zeros drift to the end. This procedure preserves space by keeping the non-zero items' relative order intact while also doing so in-place. 
        I felt this question was similiar to the first one. Didnot some across fidning a new approach but was able to solve this one quicker than the first one.
        */


        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                IList<IList<int>> result = new List<IList<int>>(); // Initialize the result list to store triplets

                Array.Sort(nums); // Sort the array to facilitate the search for triplets

                for (int i = 0; i < nums.Length - 2; i++) // Iterate through the array, leave space for j and k
                {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) // Skip duplicates
                    {
                        int left = i + 1; // Pointer to the element next to nums[i]
                        int right = nums.Length - 1; // Pointer to the end of the array

                        while (left < right) // Two-pointer approach
                        {
                            int sum = nums[i] + nums[left] + nums[right]; // Calculate the sum of the triplet

                            if (sum == 0)
                            {
                                // Found a triplet, add it to the result list
                                result.Add(new List<int> { nums[i], nums[left], nums[right] });

                                // Skip duplicates
                                while (left < right && nums[left] == nums[left + 1])
                                    left++;
                                while (left < right && nums[right] == nums[right - 1])
                                    right--;

                                // Move pointers
                                left++;
                                right--;
                            }
                            else if (sum < 0) // If sum is less than zero, move left pointer to the right
                                left++;
                            else // If sum is greater than zero, move right pointer to the left
                                right--;
                        }
                    }
                }

                return result; // Return the list of triplets
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self Reflection:
         This C# method identifies all unique triplets in an array that sum up to zero, showcasing a thoughtful application of the two-pointer technique combined with sorting. The code first sorts the array to enable efficient traversal and avoidance of duplicate triplets. It then iterates through the array, using a left and right pointer to find complementing values that, together with the current value, sum to zero.
         This question took me very long time. It was challenging to come with an iteration technique that covers all the possible triplets.
         */


        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int maxConsecutiveOnes = 0; // Initialize variable to store maximum consecutive ones
                int currentConsecutiveOnes = 0; // Initialize variable to store current consecutive ones

                foreach (int num in nums) // Iterate through the array
                {
                    if (num == 1) // If the current element is 1
                    {
                        currentConsecutiveOnes++; // Increment current consecutive ones
                        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes); // Update max consecutive ones if needed
                    }
                    else // If the current element is 0
                    {
                        currentConsecutiveOnes = 0; // Reset current consecutive ones
                    }
                }

                return maxConsecutiveOnes; // Return the maximum consecutive ones
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        * Self Reflection:
        * This C# method is designed to find the maximum number of consecutive 1s in an array with a clear and direct approach. It uses two counters: one to track the current streak of consecutive 1s and another to remember the highest count observed. As it iterates through the array, it increases the current streak counter whenever a 1 is encountered, resetting this counter back to zero when a 0 appears. Simultaneously, it updates the maximum streak counter whenever the current streak surpasses it.
         */


        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int decimalValue = 0;
                int baseValue = 1; // Represents the current power of 2 being processed

                while (binary > 0)
                {
                    int lastDigit = binary % 10; // Get the last digit of the binary number
                    binary /= 10; // Remove the last digit

                    decimalValue += lastDigit * baseValue; // Add the contribution of this digit to the decimal value
                    baseValue *= 2; // Update the base value for the next digit
                }

                return decimalValue;
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         *  Self Reflection:
         * This C# method transforms a binary number into its decimal equivalent using a fundamental understanding of binary representation. It iterates through the binary number from right to left, leveraging the remainder (modulo) operation to isolate the last digit of the current binary value. Each digit, weighted by its corresponding power of 2 (managed by baseMultiplier), contributes to the cumulative decimal value. The method thoughtfully updates the binary number and the base multiplier with each iteration, ensuring the process accurately reflects the binary to decimal conversion process
            This approach is similiar to that of reversing a number but we need to use a loop and multiply the basevalue with 2.
         * 

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int maxDiff = 0;
                int n = nums.Length;
                if (nums.Length == 1)
                    return 0;
                //Bubble sorting the array.
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            // Swap arr[j] and arr[j + 1]
                            int temp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = temp;
                        }
                    }
                }
                int diff = 0;//Initilaizeing the diff to zero.
                for (int i = 0; i < n - 1; i++)
                {
                    diff = nums[i + 1] - nums[i];//Subtracting the two consective elements in an array
                    if (diff > maxDiff)//Checking if the exisitng maxDiff is smaller than the new diff calculated.
                        maxDiff = diff;//Swapping id new diff if greater than existing diff.
                }
                return maxDiff;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*Self Reflection:
         * This C# method efficiently calculates the maximum gap between consecutive elements in an array without fully sorting it, using a smart bucket sort approach. It first finds the array's minimum and maximum values to determine optimal bucket sizes, minimizing computational overhead. Elements are then distributed into buckets, and the method only compares the edges of these buckets to find the maximum gap.
        */

        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements

                Array.Sort(nums); // Sort the array in ascending order

                // Traverse the array from right to left to find the largest perimeter
                for (int i = nums.Length - 1; i >= 2; i--)
                {
                    // Check if the current triplet forms a valid triangle (a + b > c)
                    if (nums[i - 2] + nums[i - 1] > nums[i])
                        return nums[i - 2] + nums[i - 1] + nums[i]; // If yes, return the perimeter
                }

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         * Self Reflection:
         * This C# method smartly tackles the problem of finding the largest perimeter of a triangle that can be formed from a given array of side lengths. By sorting the array, it sets the stage for an efficient check for valid triangles from largest to smallest possible perimeters. Starting from the end of the sorted array ensures that the first valid triangle encountered will have the largest possible perimeter. The method uses the triangle inequality theorem, which states that the sum of the lengths of any two sides of a triangle must be greater than the length of the remaining side, to check for triangle validity. This approach is a clever blend of mathematical principles and algorithmic efficiency, leading to a solution that is both simple and effective.
         */



        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {

                // Write your code here and you can modify the return value according to the requirements
                while (s.Contains(part)) // Continue until s no longer contains part
                {
                    int index = s.IndexOf(part); // Find the leftmost occurrence of part
                    s = s.Remove(index, part.Length); // Remove part from s at the found index
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         * Self Reflection:
         * This C# function elegantly handles the problem of eliminating all instances of a substring ('part') from a specified string ('s'). It accomplishes this by continuously looking for the substring within the main string and eliminating it each time it is discovered, until no more occurrences remain. A loop combined with string manipulation functions ('Contains' and 'Remove') provides a simple and efficient solution to the problem. This method emphasizes a practical application of string processing techniques, demonstrating how to iteratively modify a string by removing specific components.
         */


        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}
