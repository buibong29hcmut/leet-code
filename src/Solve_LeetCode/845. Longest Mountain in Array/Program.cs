public class Solution
{
    public int LongestMountain(int[] arr)
    {
        int[] arrInCrease= new int[arr.Length];
        int[] arrDecrease= new int[arr.Length];
        for(int i=1;i<arr.Length;i++)
        {   int countInCrease= 1;   
            for(int j=i;j<arr.Length;j--)
            {
                if (arr[j] > arr[j - 1])
                {
                    countInCrease++;
                    continue;
                }
                break;
            }
            arrInCrease[i]= countInCrease!=1? countInCrease: 0;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            int countDeCrease = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[j - 1])
                {
                    countDeCrease++;
                    continue;
                }
                break;
            }
            arrDecrease[i] = countDeCrease != 1 ? countDeCrease : 0; ;
        }
        int result = 0;
        for(int i=0;i<arr.Length;i++)
        {
            if (arrInCrease[i]!=0&& arrDecrease[i] != 0)
            {
                result = Math.Max(result, arrInCrease[i] + arrDecrease[i]-1);

            }
        }
        return result;
    }
}

