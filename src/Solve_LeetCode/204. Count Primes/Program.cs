public class Solution
{
    public int CountPrimes(int n)
    {
        int count = 0;
        bool[] isNotPrime = new bool[n];

        if (n < 2)
        {
            return count;
        }
        for(int i=2; i<n; i++)
        {
            if (!isNotPrime[i])
            {
                count++;
                for (int k = 2; k * i < n; k++)
                {
                    isNotPrime[k * i] = true;
                }
            }
        }
        return count;
    }
    private bool IsPrime(int n)
    {
        for(int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
                
        }
        return true;
    }
}
