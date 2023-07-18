using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 2, 1 };
        int result = FindThirdMax(nums);
        Console.WriteLine(result);
        Console.ReadLine();
       
    }

    public static int FindThirdMax(int[] nums)
    {
        Array.Sort(nums);  
        Array.Reverse(nums);  

        int distinctMaxCount = 0;
        int? thirdMax = null;

        foreach (int num in nums)
        {
            if (num != thirdMax)
            {
                thirdMax = num;
                distinctMaxCount++;

                if (distinctMaxCount == 3)
                    return thirdMax.Value;
            }
           
        }

        return nums[0];
        
    }
}
