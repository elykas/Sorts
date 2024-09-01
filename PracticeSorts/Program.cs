namespace PracticeSorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 5, 2, 7, 4, 0 };
            int[] sorted = BoobleSort(array);
            int[] selection = SelectionSort(array);
            Console.WriteLine(string.Join(", ", sorted));
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


        public static int[] SelectionSort(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }

              
                if (min != i)
                {
                    int temp = nums[min];
                    nums[min] = nums[i];
                    nums[i] = temp;
                }
            }

            return nums;
        }

    }
}
