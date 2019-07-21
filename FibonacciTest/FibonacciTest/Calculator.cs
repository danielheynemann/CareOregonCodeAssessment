namespace FibonacciTest
{
    public class Calculator
    {
        public int CalculateFibonacci(int position)
        {
            int zeroBasedPosition = position - 1;
            int[] sequence = new int[position];

            sequence[0] = 1;
            sequence[1] = 1;

            for (int counter = 2; counter <= zeroBasedPosition; counter++)
            {
                sequence[counter] = sequence[counter - 2] + sequence[counter - 1];
            }

            return sequence[zeroBasedPosition];
        }
    }
}
