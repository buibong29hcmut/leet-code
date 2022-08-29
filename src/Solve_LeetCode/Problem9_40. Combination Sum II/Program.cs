public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> result= new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(candidates, result, new List<int>(), target, 0);
        return result;
    }
    public void BackTrack(int[] candidates, List<IList<int>> result,List<int> curr,int target, int start)
    {
        if (target == 0)
        {
            result.Add(new List<int>(curr));
         
        }
        if (target < 0)
        {
            return;
        }

        int prev = -1;
        for (int i = start; i < candidates.Length; i++)l
        {
            if (prev != candidates[i])
            { // each time start from different element
                curr.Add(candidates[i]);
                BackTrack(candidates, result, curr, target - candidates[i],start+1); // and use next element only
                curr.RemoveAt(curr.Count - 1);
                prev = candidates[i];
            }
        }
    }
}