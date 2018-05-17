namespace Sum_Of_Sequence
{
    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            var sum = 0;
            if (start > end) return 0;
            for (int i = start; i <= end; i+=step)
            {
                sum += i;
            }
            return sum;
        }
    }
}
