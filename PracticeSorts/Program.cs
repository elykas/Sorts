namespace PracticeSorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 5, 2, 7, 4, 0 };
            int[] sorted = BoobleSort(array);
            Console.WriteLine(string.Join(", ", sorted));

        }


        public static int[] BoobleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length -1 ; j++)
                {
                    if (nums[j] > nums[j +1])
                    {
                        int temp = nums[j +1];
                        nums[j +1] = nums[j];
                        nums[j] = temp;
                    }
                }
                
            }
            return nums;
        }
    }
}
