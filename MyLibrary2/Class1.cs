namespace MyLibrary2
{
    public static class A 
    {
        public static double AVG(this int[] arr)
        {

            double avg = 0,count=0;
            double result=0;

            foreach(int i in arr)
            {
                count++;
                avg += i;
            }
            result = avg / count;
            return result;
        }
        public static double SUM(this int[] arr)
        {
            double sum = 0;
            foreach(double i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public static double MAX(this int[] arr)
        {
            int max = arr[0];
           for(int i=0;i<arr.Length;i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }              

            }
            return max;
        }

        public static double MIN(this int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }

            }
            return min;
        }


    }
}