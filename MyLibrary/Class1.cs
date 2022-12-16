namespace MyLibrary
{
    public static class COUNT
    {
      public static int GetDigits(this int num )
        {
            int count = 0;
            while(num!=0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}