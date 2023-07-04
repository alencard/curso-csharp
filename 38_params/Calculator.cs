namespace _38_params
{
    static class Calculator
    {
        public static int Sum(params int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
