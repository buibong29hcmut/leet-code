public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {

        HashSet<string> sequences = new HashSet<string>();
        for(int i = 0; i <=s.Length - 10; i++)
        {
            string item = s.Substring(i, 10);
            if (sequences.Contains(item))
            {
                continue;
            }
            sequences.Add(item);
        }
        return sequences.ToList(); 
    }
}
