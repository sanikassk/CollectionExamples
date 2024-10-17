namespace GenericStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (int member in stack)
            {
                Console.WriteLine(member);

            }
        }
    }

}
