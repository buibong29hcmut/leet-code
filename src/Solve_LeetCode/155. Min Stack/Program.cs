public class MinStack: IComparer<int>
{
    private Stack<int> stack;
    private Stack<int> minstack;
    private int Min=0;
    public MinStack()
    {
        stack = new();
        minstack = new();
        minstack.Push(0);
    }

    public void Push(int val)
    {  
          
        stack.Push(val);
        if(Compare(val, minstack.Peek()) < 0)
        {
            minstack.Push(val);
        }
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
       return stack.Peek();
    }

    public int GetMin()
    {
        return minstack.Peek();
    }

    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }

}
